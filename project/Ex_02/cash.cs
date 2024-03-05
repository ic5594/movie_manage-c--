using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;


namespace Ex_02
{
    public partial class cash : Form
    {
        public seat t1 = null;
        public seat p = null;
        public result c1 = null;
        public cash()
        {
            InitializeComponent();
        }

        private void cash_Load(object sender, EventArgs e)
        {
            p = (seat)Owner;
            string tt = p.s.s;
            string main = p.s1.s1;
            string humen = p.p.pp;
            int a = 15000;
            int sum = int.Parse(humen) * a;
            label8.Text =  sum.ToString();
             hyeon.Text = tt;
            label6.Text = main;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            card carD = new card();
            carD.Owner = this;
            c1 = new result();
            card.label3_static = label8.Text;
            /*c1.c = label8.Text;*/
            carD.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hyengum hY = new hyengum();
            hY.Owner = this;
            c1 = new result();
            hyengum.label2_static = label8.Text;
           /* c1.c = label8.Text;*/
            hY.Show();
        }
    }
    public class result
    {
        public string c;
    }

}
