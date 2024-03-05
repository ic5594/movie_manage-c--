
namespace Ex_02
{
    partial class time
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("서울");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("경기");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("인천");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("강원");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("대전/충청");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("대구");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("부산/울산");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("경상");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("광주/전라/제주");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.급등 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.영화 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(31, 66);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "노드0";
            treeNode1.Text = "서울";
            treeNode2.Name = "노드1";
            treeNode2.Text = "경기";
            treeNode3.Name = "노드2";
            treeNode3.Text = "인천";
            treeNode4.Name = "노드3";
            treeNode4.Text = "강원";
            treeNode5.Name = "노드4";
            treeNode5.Text = "대전/충청";
            treeNode6.Name = "노드5";
            treeNode6.Text = "대구";
            treeNode7.Name = "노드6";
            treeNode7.Text = "부산/울산";
            treeNode8.Name = "노드7";
            treeNode8.Text = "경상";
            treeNode9.Name = "노드8";
            treeNode9.Text = "광주/전라/제주";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(223, 455);
            this.treeView1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(278, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 25);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "10 : 30";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(373, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "12 : 30";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(278, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 52);
            this.button3.TabIndex = 4;
            this.button3.Text = "15 : 30";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(373, 296);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 52);
            this.button4.TabIndex = 5;
            this.button4.Text = "17 : 30";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(468, 296);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 52);
            this.button5.TabIndex = 6;
            this.button5.Text = "19 : 30";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(278, 437);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 52);
            this.button6.TabIndex = 7;
            this.button6.Text = "21 : 30";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(373, 437);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 52);
            this.button7.TabIndex = 8;
            this.button7.Text = "23 : 30";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.급등,
            this.영화,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(587, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(561, 446);
            this.dataGridView1.TabIndex = 9;
            // 
            // 급등
            // 
            this.급등.HeaderText = "등급";
            this.급등.MinimumWidth = 6;
            this.급등.Name = "급등";
            this.급등.Width = 125;
            // 
            // 영화
            // 
            this.영화.HeaderText = "영화";
            this.영화.MinimumWidth = 6;
            this.영화.Name = "영화";
            this.영화.Width = 135;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "장르";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "러닝타임";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(967, 21);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(181, 34);
            this.button8.TabIndex = 10;
            this.button8.Text = "예매하기";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "1관";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "3관";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "5관";
            // 
            // time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 554);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.treeView1);
            this.Name = "time";
            this.Text = "time";
            this.Load += new System.EventHandler(this.time_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 급등;
        private System.Windows.Forms.DataGridViewTextBoxColumn 영화;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}