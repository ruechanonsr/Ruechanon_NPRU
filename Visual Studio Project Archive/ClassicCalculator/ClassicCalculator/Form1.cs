using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            // หาผลบวก
            double A, B, sum;
            A = 0;
            B = 0;
            sum = 0;
            int parsedValue;
            if (!int.TryParse(tb_a.Text, out parsedValue))
            {
                // แสดงข้อความเตือนถ้าไม่ Input ตัวเลข
                MessageBox.Show("ใส่ตัวเลขสิโว้ย!! \nPlease input number!"); 
                return;
            }
            if (!int.TryParse(tb_b.Text, out parsedValue))
            {
                MessageBox.Show("ใส่ตัวเลขสิโว้ย!! \nPlease input number!"); 
                return;
            }
            A = Convert.ToDouble(tb_a.Text);
            B = Convert.ToDouble(tb_b.Text);
            sum = A + B;
            tb_sum.Text = sum.ToString();
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            // หาผลลบ
            double A, B, sum;
            A = 0;
            B = 0;
            sum = 0;
            int parsedValue;
            if (!int.TryParse(tb_a.Text, out parsedValue))
            {
                MessageBox.Show("ใส่ตัวเลขสิโว้ย!! \nPlease input number!"); 
                return;
            }
            if (!int.TryParse(tb_b.Text, out parsedValue))
            {
                MessageBox.Show("ใส่ตัวเลขสิโว้ย!! \nPlease input number!"); 
                return;
            }
            A = Convert.ToDouble(tb_a.Text);
            B = Convert.ToDouble(tb_b.Text);
            sum = A - B;
            tb_sum.Text = sum.ToString();
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            // หาผลคูณ
            double A, B, sum;
            A = 0;
            B = 0;
            sum = 0;
            int parsedValue;
            if (!int.TryParse(tb_a.Text, out parsedValue))
            {
                MessageBox.Show("ใส่ตัวเลขสิโว้ย!! \nPlease input number!"); 
                return;
            }
            if (!int.TryParse(tb_b.Text, out parsedValue))
            {
                MessageBox.Show("ใส่ตัวเลขสิโว้ย!! \nPlease input number!"); 
                return;
            }
            A = Convert.ToDouble(tb_a.Text);
            B = Convert.ToDouble(tb_b.Text);
            sum = A * B;
            tb_sum.Text = sum.ToString();
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            // หาผลหาร
            double A, B, sum;
            A = 4;
            B = 2;
            sum = 0;
            int parsedValue;
            if (!int.TryParse(tb_a.Text, out parsedValue))
            {
                MessageBox.Show("ใส่ตัวเลขสิโว้ย!! \nPlease input number!"); 
                return;
            }
            if (!int.TryParse(tb_b.Text, out parsedValue))
            {
                MessageBox.Show("ใส่ตัวเลขสิโว้ย!! \nPlease input number!"); 
                return;
            }
            A = Convert.ToDouble(tb_a.Text);
            B = Convert.ToDouble(tb_b.Text);
            sum = A / B;
            tb_sum.Text = sum.ToString();
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            tb_a.Clear();
            tb_b.Clear();
            tb_sum.Clear();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
