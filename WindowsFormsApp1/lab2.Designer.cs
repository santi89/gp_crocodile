namespace WindowsFormsApp1
{
    partial class lab2
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
            this.btncomplement = new System.Windows.Forms.Button();
            this.btnintersect = new System.Windows.Forms.Button();
            this.btnunion = new System.Windows.Forms.Button();
            this.btnexclude = new System.Windows.Forms.Button();
            this.btnxor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncomplement
            // 
            this.btncomplement.Location = new System.Drawing.Point(816, 45);
            this.btncomplement.Name = "btncomplement";
            this.btncomplement.Size = new System.Drawing.Size(113, 40);
            this.btncomplement.TabIndex = 0;
            this.btncomplement.Text = "Complement";
            this.btncomplement.UseVisualStyleBackColor = true;
            this.btncomplement.Click += new System.EventHandler(this.btncomplement_Click);
            // 
            // btnintersect
            // 
            this.btnintersect.Location = new System.Drawing.Point(816, 106);
            this.btnintersect.Name = "btnintersect";
            this.btnintersect.Size = new System.Drawing.Size(113, 48);
            this.btnintersect.TabIndex = 1;
            this.btnintersect.Text = "interSect";
            this.btnintersect.UseVisualStyleBackColor = true;
            this.btnintersect.Click += new System.EventHandler(this.btnintersect_Click);
            // 
            // btnunion
            // 
            this.btnunion.Location = new System.Drawing.Point(816, 173);
            this.btnunion.Name = "btnunion";
            this.btnunion.Size = new System.Drawing.Size(113, 42);
            this.btnunion.TabIndex = 2;
            this.btnunion.Text = "Union";
            this.btnunion.UseVisualStyleBackColor = true;
            this.btnunion.Click += new System.EventHandler(this.btnunion_Click);
            // 
            // btnexclude
            // 
            this.btnexclude.Location = new System.Drawing.Point(816, 234);
            this.btnexclude.Name = "btnexclude";
            this.btnexclude.Size = new System.Drawing.Size(113, 56);
            this.btnexclude.TabIndex = 3;
            this.btnexclude.Text = "Exclude";
            this.btnexclude.UseVisualStyleBackColor = true;
            this.btnexclude.Click += new System.EventHandler(this.btnexclude_Click);
            // 
            // btnxor
            // 
            this.btnxor.Location = new System.Drawing.Point(816, 309);
            this.btnxor.Name = "btnxor";
            this.btnxor.Size = new System.Drawing.Size(113, 51);
            this.btnxor.TabIndex = 4;
            this.btnxor.Text = "Xor";
            this.btnxor.UseVisualStyleBackColor = true;
            this.btnxor.Click += new System.EventHandler(this.btnxor_Click);
            // 
            // lab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 664);
            this.Controls.Add(this.btnxor);
            this.Controls.Add(this.btnexclude);
            this.Controls.Add(this.btnunion);
            this.Controls.Add(this.btnintersect);
            this.Controls.Add(this.btncomplement);
            this.Name = "lab2";
            this.Text = "lab2";
            this.Load += new System.EventHandler(this.lab2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncomplement;
        private System.Windows.Forms.Button btnintersect;
        private System.Windows.Forms.Button btnunion;
        private System.Windows.Forms.Button btnexclude;
        private System.Windows.Forms.Button btnxor;
    }
}