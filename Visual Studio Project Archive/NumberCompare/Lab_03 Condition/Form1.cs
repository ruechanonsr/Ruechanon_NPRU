using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_03_Condition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_a_Click(object sender, EventArgs e)
        {
            string aa, bb;
            int a, b;
            aa = tb_a.Text;
            bb = tb_b.Text;

            if (aa != "")
            {
                if (bb != "")
                {
                    a = Convert.ToInt32(tb_a.Text);
                    b = Convert.ToInt32(tb_b.Text);
                    if (a > b)
                    { MessageBox.Show(a.ToString() + ">" + b.ToString() + "\n" + "Display"); }
                    if (a < b)
                    { MessageBox.Show(a.ToString() + "<" + b.ToString() + "\n" + "Display"); }
                    else
                    { MessageBox.Show(a.ToString() + "=" + b.ToString() + "\n" + "Display"); }
                }

                else { MessageBox.Show("Please input B!!"); }
            }
            else { MessageBox.Show("Please input A!!");}
        }

        private void bt_ex_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_a.Clear();
            tb_b.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        }
    }
