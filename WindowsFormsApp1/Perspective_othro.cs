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
    public partial class Perspective_othro : Form
    {
        int choice, v = 1;
        int height, width;

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClearColor(0.0f, 0.0f, 0.0f, 0.0f);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            //cleat buffers to preset values
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            if (v == 1)
            {
                Gl.glOrtho(-2.0, 2.0, -2.0, 2.0, -15.0, 15.0);
            }
            else if(v==2)
            {
                Glu.gluPerspective(45.0f, (double)width / (double)height, 0.01f, 5000.0f);
            }
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();//loadthe identity matrix
            Glu.gluLookAt(2, 2, 2, 0, 0, 0, 0, 1, 0);
            if (choice == 1)
            {
                Gl.glColor3f(1.0f, 0.0f, 1.0f);
                Gl.glBegin(Gl.GL_LINE_LOOP);
                Gl.glVertex2d(-1, -1);
                Gl.glVertex2d(0, 1);
                Gl.glVertex2d(1, 1);
                Gl.glEnd();
            }else if (choice==2)
            {

            Gl.glColor3f(1.0f, 0.0f, 1.0f);
                Gl.glBegin(Gl.GL_TRIANGLES);
                Gl.glVertex2d(-1, -1);
                Gl.glVertex2d(0, 1);
                Gl.glVertex2d(1, 1);
                Gl.glEnd();
            }
            else
            {
                MessageBox.Show("drawing nothing");
            }

        }

        private void buttonline_Click(object sender, EventArgs e)
        {
            choice = 1;
            simpleOpenGlControl1.Invalidate();
        }

        private void buttontriangle_Click(object sender, EventArgs e)
        {
            choice = 2;
            simpleOpenGlControl1.Invalidate();
        }

        private void buttonperspective_Click(object sender, EventArgs e)
        {
            v = 2;
            MessageBox.Show("this is perspective viewing");
            simpleOpenGlControl1.Invalidate();
        }

        private void buttonoctho_Click(object sender, EventArgs e)
        {
            v = 1;
            MessageBox.Show("this is othro viewing");

            simpleOpenGlControl1.Invalidate();
        }

        public Perspective_othro()
        {
            InitializeComponent();
            simpleOpenGlControl1.InitializeContexts();
            height = simpleOpenGlControl1.Height;
            width = simpleOpenGlControl1.Width;
            simpleOpenGlControl1.InitializeContexts();
            Gl.glViewport(0, 0, width, height);

        }

        private void Perspective_othro_Load(object sender, EventArgs e)
        {

        }
    }
}
