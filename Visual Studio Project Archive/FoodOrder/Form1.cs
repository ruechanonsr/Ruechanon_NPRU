using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_a.Clear();
            tb_b.Clear();
            tb_c.Clear();
            tb_d.Clear();
            tb_e.Clear();
            tb_f.Clear();
            tb_sum.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_sum_Click(object sender, EventArgs e)
        {
            //รายการอาหาร
            int total_sum = 0; //ตัวแปรสำหรับเก็บผลรวม

            //กำหนดราคา
            if (tb_a.Text != ""){ 
                total_sum += Convert.ToInt32(tb_a.Text) * 35; 
            } 
            if (tb_b.Text != ""){ 
                total_sum += Convert.ToInt32(tb_b.Text) * 35; 
            }
            if (tb_c.Text != ""){ 
                total_sum += Convert.ToInt32(tb_c.Text) * 30; 
            }
            if (tb_d.Text != ""){
                total_sum += Convert.ToInt32(tb_d.Text) * 30; 
            }
            if (tb_e.Text != ""){ 
                total_sum += Convert.ToInt32(tb_e.Text) * 5; 
            }
            if (tb_f.Text != ""){ 
                total_sum += Convert.ToInt32(tb_f.Text) * 8; 
            } 
            
            tb_sum.Text = total_sum.ToString() + (" บาท"); //ราคารวม
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
