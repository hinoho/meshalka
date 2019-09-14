using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace Мешалка
{
    public partial class Form1 : Form
    {
        delegate void printTemp(string text);
        private printTemp temp;
        delegate void printPorts(string text);
        private printPorts contr;
        delegate void printRotation(string text);
        private printRotation rpm;
        Thread Serial_port;
        Thread writeThread;
        SerialPort port;
        StreamWriter file;
        bool isPortOpen=false;
        String Comment="";

        //инициализация формы
        public Form1()
        {
            InitializeComponent();
        }

        //загрузка формы
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] portnames = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(portnames);
            rpm = new printRotation(Print_rpm);
            contr = new printPorts(Print_temp_contr);
            temp = new printTemp(Print_temp);
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button6.Enabled = false;
        }

         void Open_and_Read_port(object ob)
         {
             string port_name = (string)ob;
             port = new SerialPort(port_name, 9600, Parity.None, 8, StopBits.One);
             port.Open();
             while(true)
             {
                 string text = port.ReadLine();
                 Print_Data(text);
             }
         }

         void writeInFile(object ob)
         {
            StreamWriter file = (StreamWriter)ob;
            while (true)
            {
                if (Comment != "")
                {
                   file.Write((DateTime.Now.ToString("HH:mm:ss"))+"\t" + textBox1.Text + "\t" + label6.Text +"\t" + Comment + "\t" + "\n");
                    Comment = "";
                }
                else
                {
                    file.Write((DateTime.Now.ToString("HH:mm:ss")) + "\t" + textBox1.Text + "\t"  + label6.Text + "\t"+ "\t" + "\n");
                }
                Thread.Sleep(10000);
            }
         }

        void Print_Data(string data)
        {
            string source = data.Substring(0, data.IndexOf('a'));
            source = source.Replace('.', ',');
            double t = Convert.ToDouble(source);
            t = Math.Round(t, 2);
            textBox1.Invoke(temp,  Convert.ToString(t));
            textBox2.Invoke(contr, Convert.ToString(t));
            source = data.Substring((data.IndexOf('a') + 1));
            source = data.Substring((data.IndexOf('d') + 1));
            source = source.Replace('e', '0');
            int div = Convert.ToInt32(source);
            if(div==0)
            {
                label6.Invoke(rpm, "0");
            }
            else
            {
                label6.Invoke(rpm, Convert.ToString(600/div));
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isPortOpen)
            {
                Serial_port.Abort();
                port.Close();
                if (writeThread != null)
                {
                    writeThread.Abort();
                }
            }
        }

        void Print_rpm(string text)
        {
            label6.Text = text;
        }

        void Print_temp_contr(string text)
        {
            textBox2.Text = text;
        }

        void Print_temp(string text)
        {
            textBox1.Text = text;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label6.Text = Convert.ToString(600 / trackBar1.Value);
        }

        //выбор температура
        private void button1_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(textBox1.Text);
            string pos = "3," + Convert.ToString(t);
            Serial_port.Suspend();
            port.WriteLine(pos);
            Serial_port.Resume();
        }

        //установка скорости
        private void button2_Click(object sender, EventArgs e)
        {
            int a = trackBar1.Value;
            string pos = "1," + Convert.ToString(a);
            label6.Text = Convert.ToString(600 / a);
            Serial_port.Suspend();
            port.WriteLine(pos);
            Serial_port.Resume();
            writeProtocol();
        }

        //остановка 
        private void button3_Click(object sender, EventArgs e)
        {
            Serial_port.Suspend();
            port.WriteLine("2,0");
            Serial_port.Resume();
            if (writeThread != null)
            {
                writeThread.Abort();
                file.Write("Варка закончена  " + Convert.ToString(DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss")) + "\n");
                file.Close();
            }
            
        }

        //обновление списка портов
        private void button4_Click(object sender, EventArgs e)
        {
            string[] portnames = SerialPort.GetPortNames();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(portnames);
        }

        //подключение порта
        private void button5_Click(object sender, EventArgs e)
        {
            Serial_port = new Thread(new ParameterizedThreadStart(Open_and_Read_port));
            Serial_port.Start(comboBox1.SelectedItem);
            //isPortOpen = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button6.Enabled = true;
        }

        //добавление комментария
        private void button6_Click(object sender, EventArgs e)
        {
            Comment = richTextBox2.Text;
            richTextBox2.Text = "";
        }

        private void writeProtocol()
        {
            string header = "Время" + "\t" + "Темп. состава(С)" + "\t" + "Скорость мешалки(об/мин)" + "\t" + "Примечание" + "\t" + "\n";
            if (port != null)
            {
                saveFileDialog1 = new SaveFileDialog();
                MessageBox.Show("Выберите файл для записи результатов ");
                saveFileDialog1.Filter = "Текстовые файлы|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    file = new StreamWriter(saveFileDialog1.FileName);
                    file.Write("Варка начата  " + Convert.ToString(DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss")) + "\n");
                    file.Write(header);
                    writeThread = new Thread(new ParameterizedThreadStart(writeInFile));
                    writeThread.Start(file);
                }
            }
            else
            {
                MessageBox.Show("Плата не подключена");
            }
        }
    }
}
