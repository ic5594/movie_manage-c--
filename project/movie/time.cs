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
  
    public partial class time : Form
    {
        public times tm1 = null; //영화A
        public times tm2 = null; //영화B
        public times t1 = null;
        public times id1 = null;
        public string str = "";

        public time()
        {
            InitializeComponent();
        }
        
       
        private void time_Load(object sender, EventArgs e)
        {
         
            SetupDataGridView();
            PopulateDataGridView();
            Form1 mainform = (Form1)Owner;
        }
       

        public void SetupDataGridView()

        {
            this.Controls.Add(dataGridView1);

            dataGridView1.ColumnCount = 4;

            dataGridView1.Columns[0].Name = "등급";
            dataGridView1.Columns[1].Name = "영화";
            dataGridView1.Columns[2].Name = "장르";
            dataGridView1.Columns[2].Name = "러닝타임";

        }

        public void PopulateDataGridView()

        {
            //string a;
            string[] row0 = new string[] { "청소년 관람불가", "랑종", "공포/스릴러/드라마", "131분" };
            string[] row1 = new string[] { "12세이용가", "블랙위도우", "액션/모험/SF", "134분" };
            string[] row2 = new string[] { "12세이용가", "스파이더맨 : 홈커밍", "액션/SF/어드밴처", "133분" };
            string[] row3 = new string[] { "15세이용가", "이스케이프 룸 2: 노 웨이 아웃", "액션/공포/스릴러", "88분" };
            string[] row4 = new string[] { "15세이용가", "콰이어트 플레이스 2", "스릴러", "97분" };
            string[] row5 = new string[] { "12세이용가", "크루엘라", "드라마/범죄/코미디", "133분" };

            object[] rows = new object[] { row0, row1, row2, row3, row4, row5 };

            foreach (string[] rowArray in rows)
            {
                dataGridView1.Rows.Add(rowArray);
            }
            //dataGridView1.Columns.Add(row0[0,]);
/*
            dataGridView1.Rows.Add(row0);
            dataGridView1.Rows.Add(row1);
            dataGridView1.Rows.Add(row2);
            dataGridView1.Rows.Add(row3);
            dataGridView1.Rows.Add(row4);
            dataGridView1.Rows.Add(row5);
*/

            id1 = new times();

            for (int i = 0; i < 4; i++)
            {
                dataGridView1.Columns[i].DisplayIndex = i;
            }
            /*dataGridView1.Columns[0].DisplayIndex = 0;
            dataGridView1.Columns[1].DisplayIndex = 1;
            dataGridView1.Columns[2].DisplayIndex = 2;
            dataGridView1.Columns[2].DisplayIndex = 3;*/


          
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.LightPink || button3.BackColor == Color.LightPink || button4.BackColor == Color.LightPink
                || button5.BackColor == Color.LightPink || button6.BackColor == Color.LightPink || button7.BackColor == Color.LightPink)
            {
                button2.BackColor = SystemColors.ButtonFace;
                button3.BackColor = SystemColors.ButtonFace;
                button4.BackColor = SystemColors.ButtonFace;
                button5.BackColor = SystemColors.ButtonFace;
                button6.BackColor = SystemColors.ButtonFace;
                button7.BackColor = SystemColors.ButtonFace;
            }
            button1.BackColor = Color.LightPink;
            t1 = new times();
            t1.ti = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.LightPink || button3.BackColor == Color.LightPink || button4.BackColor == Color.LightPink
               || button5.BackColor == Color.LightPink || button6.BackColor == Color.LightPink || button7.BackColor == Color.LightPink)
            {
                button1.BackColor = SystemColors.ButtonFace;
                button3.BackColor = SystemColors.ButtonFace;
                button4.BackColor = SystemColors.ButtonFace;
                button5.BackColor = SystemColors.ButtonFace;
                button6.BackColor = SystemColors.ButtonFace;
                button7.BackColor = SystemColors.ButtonFace;
            }
            button2.BackColor = Color.LightPink;
            t1 = new times();
            t1.ti = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.LightPink || button1.BackColor == Color.LightPink || button4.BackColor == Color.LightPink
               || button5.BackColor == Color.LightPink || button6.BackColor == Color.LightPink || button7.BackColor == Color.LightPink)
            {
                button2.BackColor = SystemColors.ButtonFace;
                button1.BackColor = SystemColors.ButtonFace;
                button4.BackColor = SystemColors.ButtonFace;
                button5.BackColor = SystemColors.ButtonFace;
                button6.BackColor = SystemColors.ButtonFace;
                button7.BackColor = SystemColors.ButtonFace;
            }
            button3.BackColor = Color.LightPink;
            t1 = new times();
            t1.ti = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.LightPink || button3.BackColor == Color.LightPink || button1.BackColor == Color.LightPink
               || button5.BackColor == Color.LightPink || button6.BackColor == Color.LightPink || button7.BackColor == Color.LightPink)
            {
                button2.BackColor = SystemColors.ButtonFace;
                button3.BackColor = SystemColors.ButtonFace;
                button1.BackColor = SystemColors.ButtonFace;
                button5.BackColor = SystemColors.ButtonFace;
                button6.BackColor = SystemColors.ButtonFace;
                button7.BackColor = SystemColors.ButtonFace;
            }
            button4.BackColor = Color.LightPink;
            t1 = new times();
            t1.ti = button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.LightPink || button3.BackColor == Color.LightPink || button4.BackColor == Color.LightPink
               || button1.BackColor == Color.LightPink || button6.BackColor == Color.LightPink || button7.BackColor == Color.LightPink)
            {
                button2.BackColor = SystemColors.ButtonFace;
                button3.BackColor = SystemColors.ButtonFace;
                button4.BackColor = SystemColors.ButtonFace;
                button1.BackColor = SystemColors.ButtonFace;
                button6.BackColor = SystemColors.ButtonFace;
                button7.BackColor = SystemColors.ButtonFace;
            }
            button5.BackColor = Color.LightPink;
            t1 = new times();
            t1.ti = button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.LightPink || button3.BackColor == Color.LightPink || button4.BackColor == Color.LightPink
               || button5.BackColor == Color.LightPink || button1.BackColor == Color.LightPink || button7.BackColor == Color.LightPink)
            {
                button2.BackColor = SystemColors.ButtonFace;
                button3.BackColor = SystemColors.ButtonFace;
                button4.BackColor = SystemColors.ButtonFace;
                button5.BackColor = SystemColors.ButtonFace;
                button1.BackColor = SystemColors.ButtonFace;
                button7.BackColor = SystemColors.ButtonFace;
            }
            button6.BackColor = Color.LightPink;
            t1 = new times();
            t1.ti = button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.LightPink || button3.BackColor == Color.LightPink || button4.BackColor == Color.LightPink
               || button5.BackColor == Color.LightPink || button6.BackColor == Color.LightPink || button1.BackColor == Color.LightPink)
            {
                button2.BackColor = SystemColors.ButtonFace;
                button3.BackColor = SystemColors.ButtonFace;
                button4.BackColor = SystemColors.ButtonFace;
                button5.BackColor = SystemColors.ButtonFace;
                button6.BackColor = SystemColors.ButtonFace;
                button1.BackColor = SystemColors.ButtonFace;
            }
            button7.BackColor = Color.LightPink;
            t1 = new times();
            t1.ti = button7.Text;
        }
           // seat.label.Text = dataGridView1.Rows[dataGridView1.CurrentCellAddress.Y].Cells[1].Value.ToString();
            
            

        private void button8_Click(object sender, EventArgs e)
        {
            tm1 = new times();
            tm1.value = dateTimePicker1.Value;//현재 날짜 시간

            tm2 = new times();
            tm2.value = dateTimePicker1.Value;

            seat stform = new seat();
            stform.Owner = this;

            int rowIndex = dataGridView1.CurrentRow.Index;
            id1.id = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString(); // 영화제목
            stform.ShowDialog();
            stform.Dispose();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
    public class times
    {
        public DateTime value;
        public string ti;
        public string id;
        public int num;
    }
}
