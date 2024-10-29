
namespace MySmartHomeProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_baud = new System.Windows.Forms.ComboBox();
            this.combo_port = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_open = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_humi = new System.Windows.Forms.Label();
            this.label_temp = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_ex = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_LEDOFF = new System.Windows.Forms.Button();
            this.bt_LEDON = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.animatedLED1 = new MySmartHomeProject.AnimatedLED();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort3 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combo_baud);
            this.groupBox1.Controls.Add(this.combo_port);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Location = new System.Drawing.Point(28, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port settings";
            // 
            // combo_baud
            // 
            this.combo_baud.FormattingEnabled = true;
            this.combo_baud.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.combo_baud.Location = new System.Drawing.Point(134, 67);
            this.combo_baud.Name = "combo_baud";
            this.combo_baud.Size = new System.Drawing.Size(169, 31);
            this.combo_baud.TabIndex = 3;
            this.combo_baud.Text = "Select";
            this.combo_baud.SelectedIndexChanged += new System.EventHandler(this.combo_baud_SelectedIndexChanged);
            // 
            // combo_port
            // 
            this.combo_port.FormattingEnabled = true;
            this.combo_port.Location = new System.Drawing.Point(134, 30);
            this.combo_port.Name = "combo_port";
            this.combo_port.Size = new System.Drawing.Size(169, 31);
            this.combo_port.TabIndex = 2;
            this.combo_port.Text = "Select";
            this.combo_port.DropDown += new System.EventHandler(this.combo_port_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM PORT";
            // 
            // bt_open
            // 
            this.bt_open.BackColor = System.Drawing.Color.Chartreuse;
            this.bt_open.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_open.Location = new System.Drawing.Point(28, 464);
            this.bt_open.Name = "bt_open";
            this.bt_open.Size = new System.Drawing.Size(102, 46);
            this.bt_open.TabIndex = 2;
            this.bt_open.Text = "ON";
            this.bt_open.UseVisualStyleBackColor = false;
            this.bt_open.Click += new System.EventHandler(this.bt_open_Click);
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.Color.Red;
            this.bt_close.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_close.Location = new System.Drawing.Point(136, 464);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(87, 46);
            this.bt_close.TabIndex = 3;
            this.bt_close.Text = "OFF";
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label_humi);
            this.panel1.Controls.Add(this.label_temp);
            this.panel1.Location = new System.Drawing.Point(365, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 58);
            this.panel1.TabIndex = 4;
            // 
            // label_humi
            // 
            this.label_humi.AutoSize = true;
            this.label_humi.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_humi.Location = new System.Drawing.Point(289, 15);
            this.label_humi.Name = "label_humi";
            this.label_humi.Size = new System.Drawing.Size(206, 31);
            this.label_humi.TabIndex = 6;
            this.label_humi.Text = "Humidity = ... %RH";
            // 
            // label_temp
            // 
            this.label_temp.AutoSize = true;
            this.label_temp.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_temp.Location = new System.Drawing.Point(57, 15);
            this.label_temp.Name = "label_temp";
            this.label_temp.Size = new System.Drawing.Size(215, 31);
            this.label_temp.TabIndex = 5;
            this.label_temp.Text = "Temperature = ... °C";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(365, 200);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Temperature";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Humidity";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(553, 310);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            title3.Name = "Title1";
            title3.Text = "Temperature & Humidity";
            this.chart1.Titles.Add(title3);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(955, 49);
            this.label3.TabIndex = 6;
            this.label3.Text = "Smart Home Project";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(955, 53);
            this.label4.TabIndex = 7;
            this.label4.Text = "Object-oriented Programming";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_ex
            // 
            this.bt_ex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_ex.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ex.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_ex.Location = new System.Drawing.Point(229, 464);
            this.bt_ex.Name = "bt_ex";
            this.bt_ex.Size = new System.Drawing.Size(117, 46);
            this.bt_ex.TabIndex = 8;
            this.bt_ex.Text = "Exit";
            this.bt_ex.UseVisualStyleBackColor = false;
            this.bt_ex.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_LEDOFF);
            this.groupBox2.Controls.Add(this.bt_LEDON);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.animatedLED1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox2.Location = new System.Drawing.Point(28, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 181);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LED Control";
            // 
            // bt_LEDOFF
            // 
            this.bt_LEDOFF.BackColor = System.Drawing.Color.LemonChiffon;
            this.bt_LEDOFF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_LEDOFF.Location = new System.Drawing.Point(164, 118);
            this.bt_LEDOFF.Name = "bt_LEDOFF";
            this.bt_LEDOFF.Size = new System.Drawing.Size(111, 46);
            this.bt_LEDOFF.TabIndex = 10;
            this.bt_LEDOFF.Text = "TURN OFF";
            this.bt_LEDOFF.UseVisualStyleBackColor = false;
            this.bt_LEDOFF.Click += new System.EventHandler(this.bt_LEDOFF_Click);
            // 
            // bt_LEDON
            // 
            this.bt_LEDON.BackColor = System.Drawing.Color.LemonChiffon;
            this.bt_LEDON.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_LEDON.Location = new System.Drawing.Point(38, 118);
            this.bt_LEDON.Name = "bt_LEDON";
            this.bt_LEDON.Size = new System.Drawing.Size(120, 46);
            this.bt_LEDON.TabIndex = 11;
            this.bt_LEDON.Text = "TURN ON";
            this.bt_LEDON.UseVisualStyleBackColor = false;
            this.bt_LEDON.Click += new System.EventHandler(this.bt_LEDON_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MySmartHomeProject.Properties.Resources.LED_DARKRED;
            this.pictureBox1.Location = new System.Drawing.Point(164, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // animatedLED1
            // 
            this.animatedLED1.BackColor = System.Drawing.Color.DarkRed;
            this.animatedLED1.Location = new System.Drawing.Point(78, 29);
            this.animatedLED1.Name = "animatedLED1";
            this.animatedLED1.Size = new System.Drawing.Size(80, 79);
            this.animatedLED1.TabIndex = 0;
            this.animatedLED1.Text = "animatedLED1";
            this.animatedLED1.UseVisualStyleBackColor = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(28, 435);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(318, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(946, 540);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bt_ex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_open);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Smart Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combo_baud;
        private System.Windows.Forms.ComboBox combo_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_open;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_humi;
        private System.Windows.Forms.Label label_temp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_ex;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AnimatedLED animatedLED1;
        private System.Windows.Forms.Button bt_LEDOFF;
        private System.Windows.Forms.Button bt_LEDON;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.IO.Ports.SerialPort serialPort3;
    }
}

