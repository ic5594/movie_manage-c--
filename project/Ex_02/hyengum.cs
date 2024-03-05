using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_02
{
    public partial class hyengum : Form
    {
        public static string label2_static = "";

        public cash ca = null;
        public snackcash sc = null;
        public hyengum()
        {
            InitializeComponent();
        }
        int result;
        private void button1_Click(object sender, EventArgs e)
        {
            result += 50000;
            label6.Text = Convert.ToString(result);
            label12.Text = (Convert.ToInt32(label6.Text) - Convert.ToInt32(label2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result += 10000;
            label6.Text = Convert.ToString(result);
            label12.Text = (Convert.ToInt32(label6.Text) - Convert.ToInt32(label2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result += 5000;
            label6.Text = Convert.ToString(result);
            label12.Text = (Convert.ToInt32(label6.Text) - Convert.ToInt32(label2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result += 1000;
            label6.Text = Convert.ToString(result);
            label12.Text = (Convert.ToInt32(label6.Text) - Convert.ToInt32(label2.Text)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label2.Text) > Convert.ToInt32(label6.Text))
            {
                MessageBox.Show("입금 금액 부족!", "에러", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(label12.Text + "원이 거슬러졌습니다.");
                Close();
            }
            Application.Exit();
        }

        private void hyengum_Load(object sender, EventArgs e)
        {
            /*ca = (cash)Owner;
            sc = (snackcash)Owner;
            string hyengum = ca.c1.c;
            string card2 = sc.snn.snn;
            label2.Text = hyengum;
            label2.Text = card2;*/
            label2.Text = label2_static;
        }
    }

}
