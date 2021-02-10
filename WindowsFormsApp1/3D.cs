using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;

namespace WindowsFormsApp1
{
    public partial class _3D : Form
    {
        float xeye, yeye, zeye;
        public _3D()
        {
            InitializeComponent();
            simpleOpenGlControl1.InitializeContexts();
            int w = simpleOpenGlControl1.Width;
            int h = simpleOpenGlControl1.Height;
            Gl.glViewport(0, 0, w, h);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45.0f, (double)w / (double)h, 0.1f, 5000.0f);
            xeye = yeye = zeye = 5;
        }

        private void simpleOpenGlControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'i' || e.KeyChar == 'I')
            { xeye -= 0.3f; zeye -= 0.3f; yeye -= 0.1f; }
            if (e.KeyChar == 'o' || e.KeyChar == 'O')
            {       xeye += 0.3f; zeye += 0.3f; yeye += 0.1f; }
            simpleOpenGlControl1.Invalidate();        
        }

        private void simpleOpenGlControl1_Load(object sender, EventArgs e)
        {

        }

        private void _3D_Load(object sender, EventArgs e)
        {

        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClearColor(0.8f,0.8f,0.8f,0);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Glu.gluLookAt(xeye,yeye,zeye, 0, 0, 0, 0, 1, 0);
            //  Gl.glPointSize(5);
            // Gl.glBegin(Gl.GL_POINTS);
            Gl.glLineWidth(5);
            //Gl.glBegin(Gl.GL_LINES);
            //Gl.glBegin(Gl.GL_LINE_LOOP);

            //plane XZ

            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3f(1, 1, 0);
            Gl.glVertex3f(-2, 0, -2);
            Gl.glVertex3f(2, 0, -2);
            Gl.glVertex3f(2, 0, 2);
            Gl.glVertex3f(-2, 0, 2);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_TRIANGLES);

            Gl.glColor3f(1,0,0);
                Gl.glVertex3f(0, 0, 0);
            Gl.glColor3f(0, 1, 0);
            Gl.glVertex3f(0, 0.5f, -0.5f);
            Gl.glColor3f(0, 0, 1);
            Gl.glVertex3f(0.5f, 0.5f, 0);
            Gl.glEnd();
            Gl.glBegin(Gl.GL_LINES);
            //X
            Gl.glColor3f(1, 0, 0);
            Gl.glVertex3f(2, 0, 0);
            Gl.glVertex3f(-2, 0, 0);
            //y
            Gl.glColor3f(0, 1, 0);
            Gl.glVertex3f(0, 2, 0);
            Gl.glVertex3f(0, -2, 0);
            //z
            Gl.glColor3f(0, 0, 1);
            Gl.glVertex3f(0, 0, 2);
            Gl.glVertex3f(0, 0, -2);
            Gl.glEnd();

         

        }
    }
}
