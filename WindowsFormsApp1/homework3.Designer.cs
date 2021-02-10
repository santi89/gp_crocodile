namespace WindowsFormsApp1
{
    partial class homework3
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
            this.btnsave = new System.Windows.Forms.Button();
            this.btncolor = new System.Windows.Forms.Button();
            this.cmbline = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(756, 46);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(88, 31);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncolor
            // 
            this.btncolor.Location = new System.Drawing.Point(756, 97);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(88, 31);
            this.btncolor.TabIndex = 0;
            this.btncolor.Text = "button1";
            this.btncolor.UseVisualStyleBackColor = true;
            this.btncolor.Click += new System.EventHandler(this.btncolor_Click);
            // 
            // cmbline
            // 
            this.cmbline.FormattingEnabled = true;
            this.cmbline.Location = new System.Drawing.Point(754, 143);
            this.cmbline.Name = "cmbline";
            this.cmbline.Size = new System.Drawing.Size(90, 24);
            this.cmbline.TabIndex = 1;
            this.cmbline.SelectedIndexChanged += new System.EventHandler(this.cmbline_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 137);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // homework3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 581);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbline);
            this.Controls.Add(this.btncolor);
            this.Controls.Add(this.btnsave);
            this.Name = "homework3";
            this.Text = "homework3";
            this.Load += new System.EventHandler(this.homework3_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.homework3_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncolor;
        private System.Windows.Forms.ComboBox cmbline;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}