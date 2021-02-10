namespace WindowsFormsApp1
{
    partial class Perspective_othro
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
            this.simpleOpenGlControl1 = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.buttonline = new System.Windows.Forms.Button();
            this.buttontriangle = new System.Windows.Forms.Button();
            this.buttonperspective = new System.Windows.Forms.Button();
            this.buttonoctho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // simpleOpenGlControl1
            // 
            this.simpleOpenGlControl1.AccumBits = ((byte)(0));
            this.simpleOpenGlControl1.AutoCheckErrors = false;
            this.simpleOpenGlControl1.AutoFinish = false;
            this.simpleOpenGlControl1.AutoMakeCurrent = true;
            this.simpleOpenGlControl1.AutoSwapBuffers = true;
            this.simpleOpenGlControl1.BackColor = System.Drawing.Color.Black;
            this.simpleOpenGlControl1.ColorBits = ((byte)(32));
            this.simpleOpenGlControl1.DepthBits = ((byte)(16));
            this.simpleOpenGlControl1.Location = new System.Drawing.Point(13, 13);
            this.simpleOpenGlControl1.Name = "simpleOpenGlControl1";
            this.simpleOpenGlControl1.Size = new System.Drawing.Size(659, 492);
            this.simpleOpenGlControl1.StencilBits = ((byte)(0));
            this.simpleOpenGlControl1.TabIndex = 0;
            this.simpleOpenGlControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.simpleOpenGlControl1_Paint);
            // 
            // buttonline
            // 
            this.buttonline.Location = new System.Drawing.Point(699, 37);
            this.buttonline.Name = "buttonline";
            this.buttonline.Size = new System.Drawing.Size(114, 41);
            this.buttonline.TabIndex = 1;
            this.buttonline.Text = "line";
            this.buttonline.UseVisualStyleBackColor = true;
            this.buttonline.Click += new System.EventHandler(this.buttonline_Click);
            // 
            // buttontriangle
            // 
            this.buttontriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttontriangle.Location = new System.Drawing.Point(698, 97);
            this.buttontriangle.Name = "buttontriangle";
            this.buttontriangle.Size = new System.Drawing.Size(114, 39);
            this.buttontriangle.TabIndex = 2;
            this.buttontriangle.Text = "triangle";
            this.buttontriangle.UseVisualStyleBackColor = true;
            this.buttontriangle.Click += new System.EventHandler(this.buttontriangle_Click);
            // 
            // buttonperspective
            // 
            this.buttonperspective.Location = new System.Drawing.Point(700, 151);
            this.buttonperspective.Name = "buttonperspective";
            this.buttonperspective.Size = new System.Drawing.Size(112, 48);
            this.buttonperspective.TabIndex = 3;
            this.buttonperspective.Text = "perspective";
            this.buttonperspective.UseVisualStyleBackColor = true;
            this.buttonperspective.Click += new System.EventHandler(this.buttonperspective_Click);
            // 
            // buttonoctho
            // 
            this.buttonoctho.Location = new System.Drawing.Point(698, 220);
            this.buttonoctho.Name = "buttonoctho";
            this.buttonoctho.Size = new System.Drawing.Size(113, 54);
            this.buttonoctho.TabIndex = 4;
            this.buttonoctho.Text = "ortho";
            this.buttonoctho.UseVisualStyleBackColor = true;
            this.buttonoctho.Click += new System.EventHandler(this.buttonoctho_Click);
            // 
            // Perspective_othro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 534);
            this.Controls.Add(this.buttonoctho);
            this.Controls.Add(this.buttonperspective);
            this.Controls.Add(this.buttontriangle);
            this.Controls.Add(this.buttonline);
            this.Controls.Add(this.simpleOpenGlControl1);
            this.Name = "Perspective_othro";
            this.Text = "Perspective_othro";
            this.Load += new System.EventHandler(this.Perspective_othro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl simpleOpenGlControl1;
        private System.Windows.Forms.Button buttonline;
        private System.Windows.Forms.Button buttontriangle;
        private System.Windows.Forms.Button buttonperspective;
        private System.Windows.Forms.Button buttonoctho;
    }
}