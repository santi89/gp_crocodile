using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Tao.OpenGl;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class floorandlight : Form
    {
        public floorandlight()
        {
            InitializeComponent();
            simpleOpenGlControl1.InitializeContexts();
            simpleOpenGlControl1.SwapBuffers();
            int height = simpleOpenGlControl1.Height;
            int width = simpleOpenGlControl1.Width;
            Gl.glViewport(0, 0, width, height);
            //enable light and shadow
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LIGHT0);
            Gl.glEnable(Gl.GL_LIGHT1);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClearColor(0.8f, 0.8f, 0.8f, 0.8f);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Glu.gluLookAt(10, 5, 10, 0, 0, -10, 0.0, 1.0, 0.0);


            float[] ambient = { 1.0f, 0.5f, 0.05f, 1.0f };
            float[] diffuse = { 0.4f, 0.8f, 0.9f, 1.0f };
            float[] specular = { 0.4f, 0.6f, 0.9f, 1.0f };
            float[] emmit = { 0.1f, 0.0f, 0.3f, 1.0f };
            float[] shininess = { 50.0f };
            
            float[] light0_ambient = { 0.0f, 0.0f, 0.0f, 1.0f };
            float[] light0_diffuse = { 1.0f, 1.0f, 1.0f, 1.0f };
            float[] light0_specular = { 1.0f, 1.0f, 1.0f, 1.0f };
            float[] light0_position = { 0.0f, 1.0f, 0.0f, 0.0f };

            float[] light1_ambient = { 0.2f, 0.8f, 0.2f, 1.0f };
            float[] light1_diffuse = { 0.2f, 0.8f, 0.2f, 1.0f };
            float[] light1_specular = { 1.0f, 1.0f, 1.0f, 1.0f };
            float[] light1_posotion = { 0.0f, 2.0f, 0.0f, 0.0f };
            float[] spot_dicection = { -1.0f, 1.0f, 0.0f };

            Gl.glPushMatrix();
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_EMISSION, ambient);
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_DIFFUSE, diffuse);
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_SPECULAR, specular);
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_EMISSION, emmit);
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_SHININESS, shininess);;

            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_AMBIENT, light0_ambient);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_DIFFUSE, light0_diffuse);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_SPECULAR, light0_specular);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, light0_position);

         
            Gl.glLightfv(Gl.GL_LIGHT1, Gl.GL_AMBIENT, light1_ambient);
            Gl.glLightfv(Gl.GL_LIGHT1, Gl.GL_DIFFUSE, light1_diffuse);
            Gl.glLightfv(Gl.GL_LIGHT1, Gl.GL_SPECULAR, light1_specular);
            Gl.glLightfv(Gl.GL_LIGHT1, Gl.GL_POSITION, light1_posotion);
            //Gl.glLightfv(Gl.GL_LIGHT1, Gl.GL_SPOT_DIRECTION, spot_dicection); 
            Gl.glLightf(Gl.GL_LIGHT1, Gl.GL_CONSTANT_ATTENUATION, 1.5f);
            Gl.glLightf(Gl.GL_LIGHT1, Gl.GL_LINEAR_ATTENUATION, 0.5f);
            Gl.glLightf(Gl.GL_LIGHT1, Gl.GL_QUADRATIC_ATTENUATION, 0.2f);
            Gl.glLightf(Gl.GL_LIGHT1, Gl.GL_SPOT_CUTOFF
                ,45.0f);
            Gl.glLightfv(Gl.GL_LIGHT1, Gl.GL_SPOT_DIRECTION, spot_dicection);
            Gl.glLightf(Gl.GL_LIGHT1, Gl.GL_SPOT_EXPONENT, 2.0f);


            Glu.gluDisk(Glu.gluNewQuadric(), 10, 20, 32, 10);
            Gl.glTranslated(0, 35, 35);
            Glu.gluSphere(Glu.gluNewQuadric(), 10.0f, 32, 32);
            Gl.glTranslated(0, 2, -30);
            Gl.glRotated(170, 1, 0, 0);
            Glu.gluCylinder(Glu.gluNewQuadric(), 2, 10, 20, 30, 30);
            Gl.glPopMatrix();
        }

        private void floorandlight_Load(object sender, EventArgs e)
        {

        }
    }
}
