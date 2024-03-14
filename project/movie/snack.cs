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
    public partial class snack : Form
    {
        public snack1 sn1 = null;
        public snack()
        {
            InitializeComponent();
        }

        public int sum;
        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "감자튀김 ";
            sum += int.Parse(2000.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "나쵸 ";
            sum += int.Parse(3000.ToString());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "맛밤 ";
            sum += int.Parse(2500.ToString());
        }
        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = "소떡소떡 ";
            sum += int.Parse(2500.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label4.Text = "프레즐 ";
            sum += int.Parse(3000.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label4.Text = "츄러스 ";
            sum += int.Parse(3000.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label4.Text = "치즈볼 ";
            sum += int.Parse(3000.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label4.Text = "콜팝 ";
            sum += int.Parse(3000.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label4.Text = "팝콘 ";
            sum += int.Parse(7000.ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label4.Text = "핫도그 ";
            sum += int.Parse(3000.ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label5.Text = sum.ToString();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            snackcash snackcashform = new snackcash();
            snackcashform.Owner = this;
            sn1 = new snack1();
            sn1.sn = label5.Text;
            
            snackcashform.ShowDialog();
            snackcashform.Dispose();
        }

        private void snack_Load(object sender, EventArgs e)
        {

        }
    }
    public class snack1
    {
        public string sn;
    }
}
