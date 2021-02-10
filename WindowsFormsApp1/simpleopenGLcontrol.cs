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
    public partial class simpleopenGLcontrol : Form
    {
        int choice;
        public simpleopenGLcontrol()
        {
            InitializeComponent();
        }

        private void simpleopenGLcontrol_Load(object sender, EventArgs e)
        {

        }
        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClearColor(0.8f, 0.8f, 0.8f, 0.0f);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            if (choice == 1)
            {
                Gl.glColor3f(1.0f, 0.0f, 1.0f);
                Gl.glLineWidth(3);

                Gl.glBegin(Gl.GL_LINE_LOOP);
                Gl.glVertex2d(-1, -1);
                Gl.glVertex2d(0, 1);
                Gl.glVertex2d(1, 1);
                Gl.glEnd();

            }
            else if (choice == 2)
            {
                Gl.glColor3f(0.0f, 1.0f, 1.0f);
                Gl.glBegin(Gl.GL_TRIANGLES);
                Gl.glVertex2d(-0.5, -0.5);
                Gl.glVertex2d(0, 0.5);
                Gl.glVertex2d(0.5, 0.5);
                Gl.glEnd();
            }
            else MessageBox.Show("Drawing Nothing");
           

        }

        private void btndrawline_Click(object sender, EventArgs e)
        {
            choice = 1;
            simpleOpenGlControl1.Invalidate();
        }

        private void triangle_Click(object sender, EventArgs e)
        {
            choice = 2;
            simpleOpenGlControl1.Invalidate();
        }

        private void simpleOpenGlControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
