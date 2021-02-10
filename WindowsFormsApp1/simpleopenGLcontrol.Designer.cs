namespace WindowsFormsApp1
{
    partial class simpleopenGLcontrol
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
            this.btndrawline = new System.Windows.Forms.Button();
            this.triangle = new System.Windows.Forms.Button();
            this.simpleOpenGlControl1 = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.SuspendLayout();
            // 
            // btndrawline
            // 
            this.btndrawline.Location = new System.Drawing.Point(739, 21);
            this.btndrawline.Name = "btndrawline";
            this.btndrawline.Size = new System.Drawing.Size(90, 62);
            this.btndrawline.TabIndex = 0;
            this.btndrawline.Text = "buttonline";
            this.btndrawline.UseVisualStyleBackColor = true;
            this.btndrawline.Click += new System.EventHandler(this.btndrawline_Click);
            // 
            // triangle
            // 
            this.triangle.Location = new System.Drawing.Point(739, 101);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(90, 64);
            this.triangle.TabIndex = 1;
            this.triangle.Text = "buttontriangle";
            this.triangle.UseVisualStyleBackColor = true;
            this.triangle.Click += new System.EventHandler(this.triangle_Click);
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
            this.simpleOpenGlControl1.Location = new System.Drawing.Point(12, 12);
            this.simpleOpenGlControl1.Name = "simpleOpenGlControl1";
            this.simpleOpenGlControl1.Size = new System.Drawing.Size(700, 444);
            this.simpleOpenGlControl1.StencilBits = ((byte)(0));
            this.simpleOpenGlControl1.TabIndex = 2;
            this.simpleOpenGlControl1.Load += new System.EventHandler(this.simpleOpenGlControl1_Load);
            this.simpleOpenGlControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.simpleOpenGlControl1_Paint);
            // 
            // simpleopenGLcontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 581);
            this.Controls.Add(this.simpleOpenGlControl1);
            this.Controls.Add(this.triangle);
            this.Controls.Add(this.btndrawline);
            this.Name = "simpleopenGLcontrol";
            this.Text = "simpleopenGLcontrol";
            this.Load += new System.EventHandler(this.simpleopenGLcontrol_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndrawline;
        private System.Windows.Forms.Button triangle;
        private Tao.Platform.Windows.SimpleOpenGlControl simpleOpenGlControl1;
    }
}