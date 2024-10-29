using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_04_Grade_Calculator
{
    public partial class GradeCal : Form
    {
        public GradeCal()
        {
            InitializeComponent();
        }

        private void bt_run_Click(object sender, EventArgs e)
        {
            int a, b, c, d, e1, score;
            string aa, bb, cc, dd, ee;
            aa = tb_a.Text;
            bb = tb_b.Text;
            cc = tb_c.Text;
            dd = tb_d.Text;
            ee = tb_e.Text;

            if ((aa != "") && (bb != "") && (cc != "") && (dd != "") && (ee != ""))
            {
                {
                    a = Convert.ToInt32(tb_a.Text); //คะแนนแต่ละช่อง
                    b = Convert.ToInt32(tb_b.Text);
                    c = Convert.ToInt32(tb_c.Text);
                    d = Convert.ToInt32(tb_d.Text);
                    e1 = Convert.ToInt32(tb_e.Text);
                    score = a + b + c + d + e1; //นำคะแนนทั้งหมดมาบวกกัน

                    if (score > 100)
                    { MessageBox.Show("Your score is over range!!");} //แสดงข้อความเตือนถ้าคะแนนเกิน 100
                    if (score < 50)
                    { 
                        tb_sc.Text = score.ToString(); 
                        tb_grade.Text = ("Grade E"); //แสดงเกรด
                    } 
                    if (score >= 50)
                    { 
                        tb_sc.Text = score.ToString();
                        tb_grade.Text = ("Grade D"); 
                    }
                    if (score >= 60)
                    { 
                        tb_sc.Text = score.ToString(); 
                        tb_grade.Text = ("Grade C"); 
                    }
                    if (score >= 70)
                    { 
                        tb_sc.Text = score.ToString(); 
                        tb_grade.Text = ("Grade B"); 
                    }
                    if (score >= 80)
                    { 
                        tb_sc.Text = score.ToString(); 
                        tb_grade.Text = ("Grade A"); 
                    }
                }
            }
            else { MessageBox.Show("Please input your score!!");} //แสดงข้อความเตือนถ้ามีช่องไหนไม่ใส่คะแนน
        }

        private void bt_cl_Click(object sender, EventArgs e)
        {
            tb_a.Clear();
            tb_b.Clear();
            tb_c.Clear();
            tb_d.Clear();
            tb_e.Clear();
            tb_sc.Clear();
            tb_grade.Clear();
        }

        private void bt_ex_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

