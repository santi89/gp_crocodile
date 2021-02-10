using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ColorDialogshow : Form
    {
        float r, g, b, eyex, eyey, eyez;

        private void txtR_TextChanged(object sender, EventArgs e)
        {
            r = float.Parse(txtR.Text);
            simpleOpenGlControl1.Invalidate();
        }

        private void txtG_TextChanged(object sender, EventArgs e)
        {
            g = float.Parse(txtG.Text);
            simpleOpenGlControl1.Invalidate();
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            b= float.Parse(txtB.Text);
            simpleOpenGlControl1.Invalidate();
        }

        private void simpleOpenGlControl1_Load(object sender, EventArgs e)
        {

        }

        private void ColorDialogshow_Load(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            simpleOpenGlControl1.Invalidate();
        }

        private void btnSetColor_Click(object sender, EventArgs e)
        {
            ColorDialog clrd = new ColorDialog();
            if (clrd.ShowDialog() == DialogResult.OK)
            {
                //must add .0f to set floating number
                r = clrd.Color.R / 255.0f;
                g = clrd.Color.G / 255.0f;
                b = clrd.Color.B / 255.0f;
                txtR.Text = r.ToString("0.0f");
                txtG.Text = g.ToString("0.0f");
                txtB.Text = b.ToString("0.0f");
            }
            simpleOpenGlControl1.Invalidate();
        }

        float atx, aty, atz;

        public ColorDialogshow()
        {
            InitializeComponent();
            int height = simpleOpenGlControl1.Height;
            int width = simpleOpenGlControl1.Width;
            simpleOpenGlControl1.InitializeContexts();
            Gl.glViewport(0, 0, width, height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glOrtho(-40.0, 40.0, -50.0, 50.0, -150.0, 150.0);
            r = float.Parse(txtR.Text);
            g =float.Parse(txtG.Text);
            b = float.Parse(txtR.Text);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClearColor(r, g, b, 0.0f);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT) ;
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Glu.gluLookAt(eyex, eyey, eyez, atx, aty, atz, 0.0, 1.0, 0.0);
            Gl.glColor3f(0.5f, 1, 0);
            Glu.gluCylinder(Glu.gluNewQuadric(),2,10,20,30,30);
        }
    }
}
