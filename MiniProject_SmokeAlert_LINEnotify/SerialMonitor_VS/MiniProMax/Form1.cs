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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace MiniProMax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] buffer = new byte[serialPort1.BytesToRead];
            int bytesRead = serialPort1.Read(buffer, 0, buffer.Length);
            string data = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            Debug.WriteLine("Data received: " + data); // Add this line
            BeginInvoke(new Action(() => {
                if (textBox1.Enabled && textBox1.Visible)
                {
                    textBox1.AppendText(data);
                }
            }));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = combo_port.Text;
                serialPort1.BaudRate = Convert.ToInt32(combo_baud.Text);
                serialPort1.Open();
                Debug.WriteLine("Serial port opened"); // Add this line
                button1.Enabled = false;
                button2.Enabled = true;

                MessageBox.Show("Connection Success");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (serialPort1.IsOpen)
                {
                    try
                    {
                        serialPort1.Close();
                        Debug.WriteLine("Serial port closed"); // Add this line
                        button1.Enabled = true;
                        button2.Enabled = false;

                        MessageBox.Show("Disconnected");
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
        }
    }
}
