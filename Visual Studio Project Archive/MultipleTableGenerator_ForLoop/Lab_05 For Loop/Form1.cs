using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_05_For_Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            string str = "";
            int ip, sum;

            int parsedValue;
            if (!int.TryParse(tb_num.Text, out parsedValue))
            {
                MessageBox.Show("ใส่ตัวเลขสิโว้ย!! \nPlease input number!"); // แสดงข้อความเตือนถ้าไม่ Input ตัวเลขหรือ Input ตัวอักษร
                return;
            }
            
            ip = Convert.ToInt32(tb_num.Text); // Input

            {
                for (int i = 1; i <= 12; i++) // กำหนดเงื่อนไข For Loop
                {
                    sum = ip * i; // คำนวณ
                    str += ip.ToString() + "x" + i.ToString() + "=" + sum.ToString() + Environment.NewLine; // Output
                    // Environment.NewLine ใช้สำหรับขึ้นบรรทัดใหม่
                }

                tb_show.Text = str;
            } // แสดงผลสูตรคูณใน Textbox
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_num.Clear();
            tb_show.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "";
            int ip;

            int parsedValue;
            if (!int.TryParse(tb_num.Text, out parsedValue))
            {
                MessageBox.Show("ใส่ตัวเลขสิโว้ย!! \nPlease input number!"); // แสดงข้อความเตือนถ้าไม่ Input ตัวเลขหรือ Input ตัวอักษร
                return;
            }

            ip = Convert.ToInt32(tb_num.Text);
            for (int i = 1; i <= ip; i++)
            {
                if (i % 2 == 1)
                {
                    str += i.ToString() + Environment.NewLine;
                }
            }
            tb_show.Text = str;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = "";
            int ip;

            int parsedValue;
            if (!int.TryParse(tb_num.Text, out parsedValue))
            {
                MessageBox.Show("ใส่ตัวเลขสิโว้ย!! \nPlease input number!"); // แสดงข้อความเตือนถ้าไม่ Input ตัวเลขหรือ Input ตัวอักษร
                return;
            }

            ip = Convert.ToInt32(tb_num.Text);
            for (int i = 1; i <= ip; i++)
            {
                if (i % 2 == 0)
                {
                    str += i.ToString() + Environment.NewLine;
                }
            }
            tb_show.Text = str;
        }

        private void tb_show_TextChanged(object sender, EventArgs e)
        {
            tb_show.ScrollBars = ScrollBars.Vertical; //ใส่ Scroll Bars บน Textbox
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}