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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string message;

       
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            movie1_information mv1 = new movie1_information();
            mv1.Owner = this;
            message = pictureBox1.ImageLocation;
            mv1.ShowDialog();
            mv1.Dispose();
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            movie2_information mv2 = new movie2_information();
            mv2.Owner = this;
            message = pictureBox2.ImageLocation;
            mv2.ShowDialog();
            mv2.Dispose();
        }

        private void pictureBox5_DoubleClick(object sender, EventArgs e)
        {
            movie3_information mv3 = new movie3_information();
            mv3.Owner = this;
            message = pictureBox3.ImageLocation;
            mv3.ShowDialog();
            mv3.Dispose();
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            movie4_information mv4 = new movie4_information();
            mv4.Owner = this;
            message = pictureBox4.ImageLocation;
            mv4.ShowDialog();
            mv4.Dispose();
        }

        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            movie5_information mv5 = new movie5_information();
            mv5.Owner = this;
            message = pictureBox5.ImageLocation;
            mv5.ShowDialog();
            mv5.Dispose();
        }

        private void pictureBox6_DoubleClick(object sender, EventArgs e)
        {
            movie6_information mv6 = new movie6_information();
            mv6.Owner = this;
            message = pictureBox6.ImageLocation;
            mv6.ShowDialog();
            mv6.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            time st = new time();
            st.Owner = this;
            st.ShowDialog();
            st.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            snack snackform = new snack();
            snackform.ShowDialog();
            snackform.Dispose();
        }
    }
}
