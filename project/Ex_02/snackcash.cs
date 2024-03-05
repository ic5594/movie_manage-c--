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
    public partial class snackcash : Form
    {
        
        public won snn = null;
        public snack sn = null;

        public snackcash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            card carD = new card();
            carD.Owner = this;
            snn = new won();
            /* snn.snn = label2.Text;*/
            card.label3_static = label2.Text;
            carD.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hyengum hY = new hyengum();
            hY.Owner = this;
            snn = new won();
           /* snn.snn = label2.Text;*/
            hyengum.label2_static = label2.Text;
            hY.Show();
            
        }

        private void snackcash_Load(object sender, EventArgs e)
        {
            sn = (snack)Owner;
            string s = sn.sn1.sn;
            label2.Text = s;
          
        }
    }
    public class won
    {
        public string snn;
    }
}
