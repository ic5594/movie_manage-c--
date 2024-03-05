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
    public partial class card : Form
    {
        public static string label3_static = "";
        public cash ca = null;
        public snackcash sc = null;
       
        public card()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agree agreE = new agree();
            agreE.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelty penaltY = new panelty();
            penaltY.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false || checkBox2.Checked == false)
            {
                MessageBox.Show("개인정보 및 제3자 제공 동의 \n" +
                    "또는 취소 및 부도 위약금 확인을 체크하세요.");
            }
            else
            {
                DialogResult a = MessageBox.Show("선택카드: " + comboBox1.Text + "\n" +
                                 "카드번호: " + textBox1.Text + "-" + textBox2.Text + "-" + textBox3.Text + "-" + textBox4.Text + "\n\n" +
                                 "결제하시겠습니까?" + "\n" + "결제금액: " + label2.Text + "원"
                                 , "결제 확인"
                                 , MessageBoxButtons.OKCancel
                                 , MessageBoxIcon.Information

                                 );
                if (a == DialogResult.OK)
                {
                    MessageBox.Show("결제가 되었습니다.", "결제 완료");
                    Close();
                    Application.Exit();
                }
                else if (a == DialogResult.Cancel)
                {
                    MessageBox.Show("결제를 취소하였습니다.");
                    Close();
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }

        private void card_Load(object sender, EventArgs e)
        {
           /* ca = (cash)Owner;
            sc = (snackcash)Owner;
            string card1 = ca.c1.c;
            string card2 = sc.snn.snn;
*/
          /*  if(ca==(cash)Owner)
            {
                label2.Text = card1;
            }
            else if(sc ==(snackcash)Owner)
            {
                label2.Text = card2;
            }*/
            //label2.Text = card1;
            label2.Text = label3_static;
            
        }
    }

}
