using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_08_Group_Radio
{
    public partial class Group_radio : Form
    {
        public Group_radio()
        {
            InitializeComponent();
        }

        private void gb_select_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_input.Clear();
            tb_output.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_output_TextChanged(object sender, EventArgs e)
        {
            tb_output.ScrollBars = ScrollBars.Vertical;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Multiplex Program
            if (rb_multi.Checked)
            {
            string str = "";
            int ip, sum;

            int parsedValue;
            if (!int.TryParse(tb_input.Text, out parsedValue))
            {
                MessageBox.Show("ใส่ตัวเลขสิโว้ย!! \nPlease input number!"); // แสดงข้อความเตือนถ้าไม่ Input ตัวเลข
                return;
            }
            
            ip = Convert.ToInt32(tb_input.Text); // Input
            {
                for (int i = 1; i <= 12; i++) // กำหนดเงื่อนไข For Loop
                {
                    sum = ip * i; // คำนวณ
                    str += ip.ToString() + " x " + i.ToString() + " = " + sum.ToString() + Environment.NewLine; // Output
                    // Environment.NewLine ใช้สำหรับขึ้นบรรทัดใหม่
                }

                tb_output.Text = str; // แสดงผลสูตรคูณใน Textbox
            } }

            // Odd Program
            if (rb_odd.Checked)
            {
                string str = "";
                int ip;

                int parsedValue;
                if (!int.TryParse(tb_input.Text, out parsedValue))
                {
                    MessageBox.Show("ใส่ตัวเลขสิโว้ย!! \nPlease input number!"); 
                    return;
                }

            ip = Convert.ToInt32(tb_input.Text);
            for (int i = 1; i <= ip; i++)
            {
                if (i % 2 == 1)
                {
                    str += i.ToString() + Environment.NewLine;
                }
            }
            tb_output.Text = str;
            }

            // Even Program
            if (rb_even.Checked)
            {
                string str = "";
                int ip;

                int parsedValue;
                if (!int.TryParse(tb_input.Text, out parsedValue))
                {
                    MessageBox.Show("ใส่ตัวเลขสิโว้ย!! \nPlease input number!"); 
                    return;
                }

                ip = Convert.ToInt32(tb_input.Text);
                for (int i = 1; i <= ip; i++)
                {
                    if (i % 2 == 0)
                    {
                        str += i.ToString() + Environment.NewLine;
                    }
                }
                tb_output.Text = str;
            }

            // n! Program
            if (rb_nfact.Checked)
            {
                string str = "";
                int ip, sum = 1;
                int parsedValue;
                if (!int.TryParse(tb_input.Text, out parsedValue))
                {
                    MessageBox.Show("ใส่ตัวเลขสิโว้ย!! \nPlease input number!"); 
                    return;
                }

                ip = Convert.ToInt32(tb_input.Text);
                for (int i = 1; i <= ip; i++)
                {
                    sum = sum * i;
                    str += i.ToString();
                    if (i < ip)
                    {
                        str += " x ";

                    }
                    else { str += " = "; }

                }
                str += sum.ToString();
                tb_output.Text = str;
            }
            }

        private void Group_radio_Load(object sender, EventArgs e)
        {
            gb_select.Enabled = false;
            tb_input.Enabled = false;
            tb_output.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gb_select.Enabled = true;
            tb_input.Enabled = true;
            tb_output.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tb_input_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }
