﻿namespace Мешалка
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(127, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Подключить порт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(124, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Остановить мешалку";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 32);
            this.comboBox1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(31, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(289, 36);
            this.button4.TabIndex = 5;
            this.button4.Text = "Обновить список портов";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(481, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 181);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Соединение с платой";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "COM-порт:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(223, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 29);
            this.textBox1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 122);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Монитор датчиков";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(299, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 24);
            this.label14.TabIndex = 23;
            this.label14.Text = "мм рт. ст.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(381, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 24);
            this.label13.TabIndex = 22;
            this.label13.Text = "об/мин";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(156, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 24);
            this.label12.TabIndex = 21;
            this.label12.Text = "°С\r\n";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(381, 202);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(58, 29);
            this.textBox6.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(62, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 24);
            this.label11.TabIndex = 19;
            this.label11.Text = "воздуха:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(309, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "г/м^3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(287, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "°С\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(213, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 24);
            this.label6.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(240, 218);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(53, 29);
            this.textBox5.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Абсолютная влажность:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(212, 170);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(81, 29);
            this.textBox4.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Давление в сосуде:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(294, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(81, 29);
            this.textBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Скорость вращения мешалки :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Температура состава:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.trackBar1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(469, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 174);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Управление мешалкой";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(190, 82);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 25);
            this.label18.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(250, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 25);
            this.label15.TabIndex = 19;
            this.label15.Text = "об/мин";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(31, 34);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Minimum = 3;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(267, 45);
            this.trackBar1.TabIndex = 18;
            this.trackBar1.Value = 30;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Скорость мешалки:";
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(67, 122);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(181, 31);
            this.button6.TabIndex = 16;
            this.button6.Text = "Установить скорость";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.richTextBox1);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(12, 215);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(429, 242);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Запись отчета";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(129, 115);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(183, 24);
            this.label17.TabIndex = 21;
            this.label17.Text = "Исходные условия:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(28, 142);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(374, 96);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(81, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(260, 25);
            this.label16.TabIndex = 19;
            this.label16.Text = "Запись показаний ведётся";
            this.label16.Visible = false;
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(221, 29);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(181, 49);
            this.button8.TabIndex = 18;
            this.button8.Text = "Закончить запись протокола";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(11, 29);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(181, 49);
            this.button7.TabIndex = 17;
            this.button7.Text = "Включить запись протокола";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.textBox7);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(834, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(371, 231);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Управление нагревом";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(49, 194);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(278, 25);
            this.label23.TabIndex = 20;
            this.label23.Text = "Температура установлена";
            this.label23.Visible = false;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(220, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 59);
            this.button3.TabIndex = 18;
            this.button3.Text = "Установить температуру";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.ForeColor = System.Drawing.Color.Red;
            this.textBox7.Location = new System.Drawing.Point(112, 77);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(58, 29);
            this.textBox7.TabIndex = 17;
            this.textBox7.Text = "N/A";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.ForeColor = System.Drawing.Color.Green;
            this.textBox3.Location = new System.Drawing.Point(186, 133);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(58, 29);
            this.textBox3.TabIndex = 16;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(16, 136);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(164, 24);
            this.label22.TabIndex = 15;
            this.label22.Text = "-контролируемая";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(16, 80);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 24);
            this.label21.TabIndex = 14;
            this.label21.Text = "-целевая";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(6, 38);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(211, 24);
            this.label19.TabIndex = 13;
            this.label19.Text = "Температура состава:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(190, 82);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 25);
            this.label20.TabIndex = 12;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button5);
            this.groupBox6.Controls.Add(this.richTextBox2);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.Location = new System.Drawing.Point(834, 283);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(371, 174);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Комментарии";
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(87, 134);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(214, 31);
            this.button5.TabIndex = 22;
            this.button5.Text = "Добавить коментарий";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(20, 30);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(345, 96);
            this.richTextBox2.TabIndex = 21;
            this.richTextBox2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 472);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Роботическая мозгомешалка v2.0  ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

