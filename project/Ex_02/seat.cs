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
    

    public partial class seat : Form
    {
        public time t1 = null;
        public people p = null;
        public people s = null;
        public people s1 = null;
        public seat()
        {
            InitializeComponent();
        }

        private void A1_Click(object sender, EventArgs e)
        {
            if (A1.BackColor == Color.Transparent)
            {
                A1.BackColor = Color.RoyalBlue;

            }
            else
            {
                A1.BackColor = Color.Transparent;
            }
        }

        private void A2_Click(object sender, EventArgs e)
        {
            if (A2.BackColor == Color.Transparent)
            {
                A2.BackColor = Color.RoyalBlue;
            }
            else
            {
                A2.BackColor = Color.Transparent;
            }
        }

        private void A3_Click(object sender, EventArgs e)
        {
            if (A3.BackColor == Color.Transparent)
            {
                A3.BackColor = Color.RoyalBlue;
            }
            else
            {
                A3.BackColor = Color.Transparent;
            }
        }

        private void A4_Click(object sender, EventArgs e)
        {
            if (A4.BackColor == Color.Transparent)
            {
                A4.BackColor = Color.RoyalBlue;
            }
            else
            {
                A4.BackColor = Color.Transparent;
            }
        }

        private void A5_Click(object sender, EventArgs e)
        {
            if (A5.BackColor == Color.Transparent)
            {
                A5.BackColor = Color.RoyalBlue;
            }
            else
            {
                A5.BackColor = Color.Transparent;
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (B1.BackColor == Color.Transparent)
            {
                B1.BackColor = Color.RoyalBlue;
            }
            else
            {
                B1.BackColor = Color.Transparent;
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (B2.BackColor == Color.Transparent)
            {
                B2.BackColor = Color.RoyalBlue;
            }
            else
            {
                B2.BackColor = Color.Transparent;
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (B3.BackColor == Color.Transparent)
            {
                B3.BackColor = Color.RoyalBlue;
            }
            else
            {
                B3.BackColor = Color.Transparent;
            }
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (B4.BackColor == Color.Transparent)
            {
                B4.BackColor = Color.RoyalBlue;
            }
            else
            {
                B4.BackColor = Color.Transparent;
            }
        }

        private void B5_Click(object sender, EventArgs e)
        {
            if (B5.BackColor == Color.Transparent)
            {
                B5.BackColor = Color.RoyalBlue;
            }
            else
            {
                B5.BackColor = Color.Transparent;
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            /*
            Button[] bt = new Button[10] { A1, A2, A3, A4, A5,
            B1, B2, B3, B4, B5 };
            for(int i = 0; i<bt.Length; i++)
            {
                bt[i].BackColor = Color.Red;
            }*/
            
            //예약하기

            MessageBox.Show("예약되었습니다.");

            if (A1.BackColor == Color.RoyalBlue)
            {
                A1.BackColor = Color.Red;
                A1.Enabled = false;
            }
            if (A2.BackColor == Color.RoyalBlue)
            {
                A2.BackColor = Color.Red;
                A2.Enabled = false;
            }
            if (A3.BackColor == Color.RoyalBlue)
            {
                A3.BackColor = Color.Red;
                A3.Enabled = false;
            }
            if (A4.BackColor == Color.RoyalBlue)
            {
                A4.BackColor = Color.Red;
                A4.Enabled = false;
            }
            if (A5.BackColor == Color.RoyalBlue)
            {
                A5.BackColor = Color.Red;
                A5.Enabled = false;
            }
            if (B1.BackColor == Color.RoyalBlue)
            {
                B1.BackColor = Color.Red;
                B1.Enabled = false;
            }
            if (B2.BackColor == Color.RoyalBlue)
            {
                B2.BackColor = Color.Red;
                B2.Enabled = false;
            }
            if (B3.BackColor == Color.RoyalBlue)
            {
                B3.BackColor = Color.Red;
                B3.Enabled = false;
            }
            if (B4.BackColor == Color.RoyalBlue)
            {
                B4.BackColor = Color.Red;
                B4.Enabled = false;
            }
            if (B5.BackColor == Color.RoyalBlue)
            {
                B5.BackColor = Color.Red;
                B5.Enabled = false;
            }
            cash cashform = new cash();
            cashform.Owner = this;
            p = new people();
            p.pp = num1.Value.ToString();

            s = new people();
            s.s = label5.Text; //영화 제목
            s1 = new people();
            s1.s1 = label6.Text; // 관람시간
            cashform.ShowDialog();
            cashform.Dispose();
        }

        public string[,] arr = new string[4,5];
        private void button2_Click(object sender, EventArgs e)
        {
            //취소
            int j = 0;
            for (int i = 0; i < 4; i++)
                for (j = 0; j < 5; j++)
                {
                    arr[i, j] = dud.Text + num.Value.ToString();
                    label7.Text = arr[i, j].ToString();

                    if (label7.Text == A1.Name)
                    {
                        A1.BackColor = Color.Transparent;
                        A1.Enabled = true;
                    }
                    else if (label7.Text == A2.Name)
                    {
                        A2.BackColor = Color.Transparent;
                        A2.Enabled = true;
                    }
                    else if (label7.Text == A3.Name)
                    {
                        A3.BackColor = Color.Transparent;
                        A3.Enabled = true;
                    }
                    else if (label7.Text == A4.Name)
                    {
                        A4.BackColor = Color.Transparent;
                        A4.Enabled = true;
                    }
                    else if (label7.Text == A5.Name)
                    {
                        A5.BackColor = Color.Transparent;
                        A5.Enabled = true;
                    }
                    else if (label7.Text == B1.Name)
                    {
                        B1.BackColor = Color.Transparent;
                        B1.Enabled = true;
                    }
                    else if (label7.Text == B2.Name)
                    {
                        B2.BackColor = Color.Transparent;
                        B2.Enabled = true;
                    }
                    else if (label7.Text == B3.Name)
                    {
                        B3.BackColor = Color.Transparent;
                        B3.Enabled = true;
                    }
                    else if (label7.Text == B4.Name)
                    {
                        B4.BackColor = Color.Transparent;
                        B4.Enabled = true;
                    }
                    else if (label7.Text == B5.Name)
                    {
                        B5.BackColor = Color.Transparent;
                        B5.Enabled = true;
                    }
                }
            
           // DateTime dt2 = t1.tm2.value;
        }

        private void seat_Load(object sender, EventArgs e)
        {
            t1 = (time)Owner;
            DateTime dt = t1.tm1.value; //현재 날짜 시간
            string tt = t1.t1.ti; // 시간대 
            string main = t1.id1.id; // 영화제목
            label4.Text = dt.ToString();
            label6.Text = tt;
            label5.Text = main;
        }
    }
    public class people
    {
        public string pp;
        public string s;
        public string s1;
    }
    
}
