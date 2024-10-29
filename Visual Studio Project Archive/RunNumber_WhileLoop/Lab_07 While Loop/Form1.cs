using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_07_While_Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_run_Click(object sender, EventArgs e)
        {
            int i, j = 1;
            i = Convert.ToInt32(tb_input.Text);
            while (j < i)
            {
                tb_output.Text += j.ToString() + Environment.NewLine;
                j++;
            }
        }
    }
}
