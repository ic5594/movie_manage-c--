
namespace Ex_02
{
    partial class movie2_information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(movie2_information));
            this.movie2 = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // movie2
            // 
            this.movie2.Location = new System.Drawing.Point(400, 12);
            this.movie2.Name = "movie2";
            this.movie2.Size = new System.Drawing.Size(380, 570);
            this.movie2.TabIndex = 0;
            this.movie2.Text = resources.GetString("movie2.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ex_02.Properties.Resources.블랙위도우;
            this.pictureBox2.Location = new System.Drawing.Point(55, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(290, 410);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // movie2_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 593);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.movie2);
            this.Name = "movie2_information";
            this.Text = "movie2_information";
            this.Load += new System.EventHandler(this.movie2_information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox movie2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}