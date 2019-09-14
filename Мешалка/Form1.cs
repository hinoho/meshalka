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
        public Form1()
        {
            InitializeComponent();
        }
        delegate void print(string text);
        private print temp;
        delegate void print1(string text);
        private print1 vlaz;
        delegate void print2(string text);
        private print2 tvn;
        delegate void print3(string text);
        private print3 rpm;
        delegate void print4(string text);
        private print4 dav;
        delegate void print5(string text);
        private print5 tok;
        delegate void print6(string text);
        private print6 contr;
        Thread Serial_port;
        Thread Zapis;
        SerialPort port;
        StreamWriter file;
        bool otkr=false;
        String Komment="";
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] portnames = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(portnames);
            temp = new print(Print_temp);
            vlaz = new print1(Print_vlaz);
            tvn = new print2(Print_tvnutri);
            rpm = new print3(Print_rpm);
            dav = new print4(Print_dav);
            contr = new print6(Print_temp_contr);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] portnames = SerialPort.GetPortNames();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(portnames);
        }
        void Print_temp_contr(string text)
        {
            textBox3.Text = text;
        }
        void Print_temp(string text)
        {
            textBox1.Text = text;
        }
        void Print_dav(string text)
        {
            textBox4.Text = text;
        }
       
        void Print_vlaz(string text)
        {
            textBox5.Text = text;
        }
        void Print_rpm(string text)
        {
            textBox2.Text = text;
        }
        void Print_tvnutri(string text)
        {
            textBox6.Text = text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
             Serial_port = new Thread( new ParameterizedThreadStart(Open_and_Read_port));
            Serial_port.Start(comboBox1.SelectedItem);
            otkr = true;
            button3.Enabled = true;
            button2.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
        }
         void Open_and_Read_port(object ob)
        {
            string port_name = (string)ob;
             port = new SerialPort(port_name, 9600, Parity.None, 8, StopBits.One);
            port.Open();
            while(1>0)
            {
                string text = port.ReadLine();
                
                Print_Data(text);
            }

        }
        void zap_v_file(object ob)
        {
            StreamWriter file1 = (StreamWriter)ob;
            while (true)
            {
                if (Komment != "")
                {
                    file1.Write((DateTime.Now.ToString("HH:mm:ss")) + "\t" + textBox2.Text  + Komment + "\t" + "\n");
                    Komment = "";
                }
                else
                {
                    file1.Write((DateTime.Now.ToString("HH:mm:ss")) + "\t"  + textBox2.Text + "\t"+ "\t" + "\n");
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
            textBox3.Invoke(contr, Convert.ToString(t));
            source = data.Substring((data.IndexOf('a')+1));
           // source = source.Replace('.', ',');
           // textBox6.Invoke(tvn, source);
          //  string source1 = data.Substring((data.IndexOf('b') + 1), 5);
           // source1 = source1.Replace('.', ',');
          //  double v = Convert.ToDouble(source1)* 0.07994 * Math.Exp(0.0448 * Convert.ToDouble(source));
           // v = Math.Round(v, 2);
           // textBox5.Invoke(vlaz, Convert.ToString(v));
            //string source2 = data.Substring((data.IndexOf('d')+1));
           // source2 = source2.Remove(source2.IndexOf('e'));
            //source2 = source2.Replace('.', ',');
            int div = Convert.ToInt32(source);
            if(div==0)
            { textBox2.Invoke(rpm, "0"); }
            else
            {
                textBox2.Invoke(rpm, Convert.ToString(600/div));
            }
           
            
          //  string source3 = data.Substring((data.IndexOf('c') + 1),6);
           // source3 = source3.Replace('.', ',');
          //  double p = Convert.ToDouble(source3);
          //  p = Math.Round(p, 2);
           // textBox4.Invoke(dav, Convert.ToString(p));
          
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Serial_port.Suspend();
            port.WriteLine("2,0");
            Serial_port.Resume();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Serial_port.Suspend();
            port.WriteLine("2,0");
            Serial_port.Resume();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (otkr)
            {
                Serial_port.Abort();
                port.Close();
            }
        
           
        }

       

       

        private void button5_Click(object sender, EventArgs e)
        {
            Serial_port.Suspend();
            port.WriteLine("2,1");
            Serial_port.Resume();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            int a = trackBar1.Value;
            string pos = "1," + Convert.ToString(a);
            label3.Text = Convert.ToString(600 / a);
            Serial_port.Suspend();
            port.WriteLine(pos);
            Serial_port.Resume();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string zagolov = "Время" + "\t" + "Темп. состава(С)" + "\t" + "Темп. воздуха(С)" + "\t" + "Скорость мешалки(об/мин)" + "\t" + "Давление(мм рт.ст.)" + "\t" + "Влажность(гр/м3)" + "\t"  +"Примечание"+ "\t" +"\n";
            if (port!=null)
            {
                button7.Enabled = false;
                label16.Visible = true;
                saveFileDialog1 = new SaveFileDialog();
                MessageBox.Show("Выберите файл для записи результатов ");
                saveFileDialog1.Filter = "Текстовые файлы|*.txt";
                if (saveFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    richTextBox1.ReadOnly = true;
                  file = new StreamWriter(saveFileDialog1.FileName);
                    file.Write("Варка начата  " + Convert.ToString(DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss")) + "\n");
                    file.Write("Исходные условия: " + richTextBox1.Text+ "\n");
                    file.Write(zagolov);
                    Zapis = new Thread(new ParameterizedThreadStart(zap_v_file));
                    Zapis.Start(file);

                 
                }
            }
            else
            {
                MessageBox.Show("Плата не подключена");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button7.Enabled = true;
            label16.Visible = false;
            richTextBox1.ReadOnly = false;
            Zapis.Abort();
            file.Write("Варка закончена  " + Convert.ToString(DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss")) + "\n");
            file.Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(600 / trackBar1.Value);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Komment = richTextBox2.Text;
       }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(textBox7.Text)+3;
            string pos = "3," + Convert.ToString(t);
            Serial_port.Suspend();
            port.WriteLine(pos);
            Serial_port.Resume();
        }
    }
}
