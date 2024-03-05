
namespace Ex_02
{
    partial class movie1_information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(movie1_information));
            this.movie1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // movie1
            // 
            this.movie1.Location = new System.Drawing.Point(400, 11);
            this.movie1.Name = "movie1";
            this.movie1.Size = new System.Drawing.Size(380, 570);
            this.movie1.TabIndex = 0;
            this.movie1.Text = resources.GetString("movie1.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ex_02.Properties.Resources.랑종;
            this.pictureBox1.Location = new System.Drawing.Point(44, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 410);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // movie1_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 593);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.movie1);
            this.Name = "movie1_information";
            this.Text = "movie1_information";
            this.Load += new System.EventHandler(this.movie1_information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox movie1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}