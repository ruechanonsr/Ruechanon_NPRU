using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_06_Pyramid_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(tb_num.Text);
            int c = 1;

            for (int i = n; i >= 1; i--)
            {
                for (int s = i - 1; s >= 1; s--)
                {
                    tb_output.Text = tb_output.Text + "";
                }
                for (int t = 1; t <= c; t++)
                {
                    tb_output.Text = tb_output.Text + "* " + "";
                }
                c++;
                tb_output.Text = tb_output.Text + System.Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_num.Clear();
            tb_output.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(tb_num.Text);
            int c = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int s = 1; s <= n; s++)
                {
                    tb_output.Text = tb_output.Text + " ";
                }
                for (int t = 1; t <= c; t++)
                {
                    tb_output.Text = tb_output.Text + "*" + " ";
                }
                c++;
                tb_output.Text = tb_output.Text + System.Environment.NewLine;
            }
        }
    }
}
