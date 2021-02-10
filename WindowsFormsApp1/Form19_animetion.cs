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
    public partial class Form19_animetion : Form
    { 
        double r1,r2,r3,c1,c2,c3,eyez,eyey,eyex,atz,atx,aty;

        private void Form19_animetion_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void simpleOpenGlControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar =='o' ||e.KeyChar == 'O')
            {
                eyex += 0.8;eyez += 0.8;
                simpleOpenGlControl1.Invalidate();
            }
            if (e.KeyChar == 'i' || e.KeyChar == 'I')
            {
                eyex -= 0.8; eyez -= 0.8;
                simpleOpenGlControl1.Invalidate();
            }
            simpleOpenGlControl1.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (c1 <= 20)
                c1 += 0.1;
            else c1 = -30;

            if (c2 <= 20)
                c2 += 0.3;
            else c2 = -20;

            if (c3 <= 20)
                c3 += 0.2;
            else c3 = -25; 
            
            if (r1 > 0)
                r1 -= 1;
            else r1 = 10;

            if (r2 > 0)
                r2 -= 2;
            else r2 = 8;

            if (r3 > 0)
                r3 -=2;
            else r3 = 13;

            simpleOpenGlControl1.Invalidate();
        }

        public Form19_animetion()
        {
            InitializeComponent();
            simpleOpenGlControl1.InitializeContexts();
            int w = simpleOpenGlControl1.Width;
            int h = simpleOpenGlControl1.Height;

            Gl.glViewport(0, 0, w, h);

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();

            Glu.gluPerspective(45.0f, (double)w /h, 0.01f, 5000.0f);

            eyex = 0; eyez = 40.0f;eyey = 30;
            atx = 0; aty=0; atz = -1;
            c1 = -2; c2 = -10; c3 = -5; r1 = 10;r2 = 8;r3 = 8;

        }
        private void cloud()
        {
            //cloud
            Gl.glPushMatrix();
            Gl.glColor3f(0.8f, 0.8f, 0.8f);
            Gl.glTranslated(0, 15, 15);
            Gl.glScaled(1, 0.2, 1.0);
            Glu.gluSphere(Glu.gluNewQuadric(), 5, 30, 30);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glColor3f(0.75f, 0.75f, 0.75f);
            Gl.glTranslated(10, 15, 15);
            Gl.glScaled(1, 0.2, 1.0);
            Glu.gluSphere(Glu.gluNewQuadric(), 5, 30, 30);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glColor3f(0.8f, 0.8f, 0.8f);
            Gl.glTranslated(5, 15, 10);
            Gl.glScaled(1, 0.2, 1.0);
            Glu.gluSphere(Glu.gluNewQuadric(), 5, 30, 30);
            Gl.glPopMatrix();

            //rainfall1
            Gl.glPushMatrix();
            Gl.glTranslated(5, r1, 10);
            raindrop();
            Gl.glPopMatrix();
            //rinfall2
            Gl.glPushMatrix();
            Gl.glTranslated(5, r2, 13);
            raindrop();
            Gl.glPopMatrix();
            //rinfall3
            Gl.glPushMatrix();
            Gl.glTranslated(13, r3, 13);
            raindrop();
            Gl.glPopMatrix();
            //rinfall4
            Gl.glPushMatrix();
            Gl.glTranslated(-13, r3, 13);
            raindrop();
            Gl.glPopMatrix();
            //rinfall4
            Gl.glPushMatrix();
            Gl.glTranslated(-13, r2, 13);
            raindrop();
            Gl.glPopMatrix();
            //rinfall4
            Gl.glPushMatrix();
            Gl.glTranslated(-5, r2, 13);
            raindrop();
            Gl.glPopMatrix();


        }
        private void raindrop()
        {
            Gl.glPopMatrix();
            Gl.glColor3f(0.85f, 0.85f, 0.85f);
            Glu.gluSphere(Glu.gluNewQuadric(), 0.3, 15, 15);
            Gl.glRotated(90, 1, 0, 0);
            Glu.gluCylinder(Glu.gluNewQuadric(), 0.3, 0, 1, 15, 15);
            Gl.glPopMatrix();
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {

            Gl.glClearColor(0.0f, 0.0f, 0.0f, 0.0f);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Glu.gluLookAt(eyex, eyey, eyez, atx, aty, atz, 0.0, 1.0, 0.0);

            //drawing a plane
            Gl.glPushMatrix();

            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3f(0.2f, 0.8f, 0.5f);

            Gl.glVertex3f(-20.0f, 0.0f, 20.0f);
            Gl.glVertex3f(20.0f, 0.0f, 20.0f);
            Gl.glVertex3f(20.0f, 0.0f, -20.0f);
            Gl.glVertex3f(-20.0f, 0.0f, -20.0f);

            Gl.glEnd();

            Gl.glPopMatrix();


            //cloud1
            Gl.glPushMatrix();
            Gl.glTranslated(-5, 5, c1);
            cloud();
            Gl.glPopMatrix();
            //cloud2
            Gl.glPushMatrix();
            Gl.glTranslated(11, 6.5, c2);
            cloud();
            Gl.glPopMatrix();
            //cloud3
            Gl.glPushMatrix();
            Gl.glTranslated(8, 9, c3);
            cloud();
            Gl.glPopMatrix();

        }
    }



}
