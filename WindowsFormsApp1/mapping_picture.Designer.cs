namespace WindowsFormsApp1
{
    partial class mapping_picture
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
            this.btnplay = new System.Windows.Forms.Button();
            this.btnpause = new System.Windows.Forms.Button();
            this.rdchick = new System.Windows.Forms.RadioButton();
            this.rdcat = new System.Windows.Forms.RadioButton();
            this.rddog = new System.Windows.Forms.RadioButton();
            this.rdbird = new System.Windows.Forms.RadioButton();
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
            this.simpleOpenGlControl1.Location = new System.Drawing.Point(3, 69);
            this.simpleOpenGlControl1.Name = "simpleOpenGlControl1";
            this.simpleOpenGlControl1.Size = new System.Drawing.Size(995, 612);
            this.simpleOpenGlControl1.StencilBits = ((byte)(0));
            this.simpleOpenGlControl1.TabIndex = 0;
            this.simpleOpenGlControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.simpleOpenGlControl1_Paint);
            // 
            // btnplay
            // 
            this.btnplay.Location = new System.Drawing.Point(1051, 31);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(91, 31);
            this.btnplay.TabIndex = 1;
            this.btnplay.Text = "Play";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // btnpause
            // 
            this.btnpause.Location = new System.Drawing.Point(1049, 86);
            this.btnpause.Name = "btnpause";
            this.btnpause.Size = new System.Drawing.Size(92, 30);
            this.btnpause.TabIndex = 2;
            this.btnpause.Text = "Pause";
            this.btnpause.UseVisualStyleBackColor = true;
            this.btnpause.Click += new System.EventHandler(this.btnpause_Click);
            // 
            // rdchick
            // 
            this.rdchick.AutoSize = true;
            this.rdchick.Location = new System.Drawing.Point(651, 12);
            this.rdchick.Name = "rdchick";
            this.rdchick.Size = new System.Drawing.Size(77, 21);
            this.rdchick.TabIndex = 3;
            this.rdchick.TabStop = true;
            this.rdchick.Text = "chicken";
            this.rdchick.UseVisualStyleBackColor = true;
            this.rdchick.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdcat
            // 
            this.rdcat.AutoSize = true;
            this.rdcat.Location = new System.Drawing.Point(524, 12);
            this.rdcat.Name = "rdcat";
            this.rdcat.Size = new System.Drawing.Size(48, 21);
            this.rdcat.TabIndex = 4;
            this.rdcat.TabStop = true;
            this.rdcat.Text = "cat";
            this.rdcat.UseVisualStyleBackColor = true;
            this.rdcat.CheckedChanged += new System.EventHandler(this.rdcat_CheckedChanged);
            // 
            // rddog
            // 
            this.rddog.AutoSize = true;
            this.rddog.Location = new System.Drawing.Point(374, 12);
            this.rddog.Name = "rddog";
            this.rddog.Size = new System.Drawing.Size(53, 21);
            this.rddog.TabIndex = 5;
            this.rddog.TabStop = true;
            this.rddog.Text = "dog";
            this.rddog.UseVisualStyleBackColor = true;
            this.rddog.CheckedChanged += new System.EventHandler(this.rddog_CheckedChanged);
            // 
            // rdbird
            // 
            this.rdbird.AutoSize = true;
            this.rdbird.Location = new System.Drawing.Point(821, 12);
            this.rdbird.Name = "rdbird";
            this.rdbird.Size = new System.Drawing.Size(53, 21);
            this.rdbird.TabIndex = 6;
            this.rdbird.TabStop = true;
            this.rdbird.Text = "bird";
            this.rdbird.UseVisualStyleBackColor = true;
            this.rdbird.CheckedChanged += new System.EventHandler(this.rdbird_CheckedChanged);
            // 
            // mapping_picture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 693);
            this.Controls.Add(this.rdbird);
            this.Controls.Add(this.rddog);
            this.Controls.Add(this.rdcat);
            this.Controls.Add(this.rdchick);
            this.Controls.Add(this.btnpause);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.simpleOpenGlControl1);
            this.Name = "mapping_picture";
            this.Text = "mapping_picture";
            this.Load += new System.EventHandler(this.mapping_picture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl simpleOpenGlControl1;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btnpause;
        private System.Windows.Forms.RadioButton rdchick;
        private System.Windows.Forms.RadioButton rdcat;
        private System.Windows.Forms.RadioButton rddog;
        private System.Windows.Forms.RadioButton rdbird;
    }
}