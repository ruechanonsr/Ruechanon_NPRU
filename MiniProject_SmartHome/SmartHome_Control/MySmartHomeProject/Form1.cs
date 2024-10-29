using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace MySmartHomeProject
{
    public partial class Form1 : Form
    {
        double temp = 0, humi = 0;
        bool updateData = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DHT11 Control
            bt_open.Enabled = true;
            bt_close.Enabled = false;
            chart1.Series["Temperature"].Points.AddXY(1, 1);
            chart1.Series["Humidity"].Points.AddXY(1, 1);

            //LED Control
            bt_LEDON.Enabled = false;
            bt_LEDOFF.Enabled = false;
            progressBar1.Value = 0;
            animatedLED1.BackColor = Color.DarkRed;
            pictureBox1.Image = Properties.Resources.LED_DARKRED;

            combo_baud.Text = "115200";
            string[] portLists = SerialPort.GetPortNames();
            combo_port.Items.AddRange(portLists);
        }

        private void combo_port_DropDown(object sender, EventArgs e)
        {
            string[] portLists = SerialPort.GetPortNames();
            combo_port.Items.Clear();
            combo_port.Items.AddRange(portLists);
        }

        private void bt_open_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = combo_port.Text;
                serialPort1.BaudRate = Convert.ToInt32(combo_baud.Text);
                serialPort1.Open();

                bt_open.Enabled = false;
                bt_close.Enabled = true;
                bt_LEDON.Enabled = true;
                bt_LEDOFF.Enabled = true;
                progressBar1.Value = 100;
                chart1.Series["Temperature"].Points.Clear();
                chart1.Series["Humidity"].Points.Clear();

                MessageBox.Show("Connection Success");
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();

                    bt_open.Enabled = true;
                    bt_close.Enabled = false;
                    bt_LEDON.Enabled = false;
                    bt_LEDOFF.Enabled = false;
                    progressBar1.Value = 0;

                    MessageBox.Show("Disconnected");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string dataIn = serialPort1.ReadTo("\n");
            Data_Parsing(dataIn);

            this.BeginInvoke(new EventHandler(Show_Data));
        }

        private void Data_Parsing(string data)
        {
            sbyte indexOf_startDataCharacter = (sbyte)data.IndexOf("@");
            sbyte indexOfA = (sbyte)data.IndexOf("A");
            sbyte indexOfB = (sbyte)data.IndexOf("B");

            if (indexOfA != -1 && indexOfB != -1 && indexOf_startDataCharacter != -1)
            {
                try
                {
                    string str_temperature = data.Substring(indexOf_startDataCharacter + 1, (indexOfA -
                        indexOf_startDataCharacter) - 1);
                    string str_humidity = data.Substring(indexOfA + 1, (indexOfB - indexOfA) - 1);

                    temp = Convert.ToDouble(str_temperature);
                    humi = Convert.ToDouble(str_humidity);
                    updateData = true;
                }
                catch(Exception)
                {
                    
                }
            }
            else
            {
                updateData = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_LEDON_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("ON#");
                    animatedLED1.BackColor = Color.Red;
                    pictureBox1.Image = Properties.Resources.LED_RED;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void bt_LEDOFF_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("OFF#");
                    animatedLED1.BackColor = Color.DarkRed;
                    pictureBox1.Image = Properties.Resources.LED_DARKRED;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void combo_baud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Show_Data(object sender, EventArgs e)
        {
            if (updateData == true)
            {
                label_temp.Text = string.Format("Temperature = {0}°C", temp.ToString());
                label_humi.Text = string.Format("Humidity = {0}%RH", humi.ToString());

                chart1.Series["Temperature"].Points.Add(temp);
                chart1.Series["Humidity"].Points.Add(humi);
            }
        }
    }
}
