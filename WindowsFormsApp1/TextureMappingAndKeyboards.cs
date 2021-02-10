using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using Tao.OpenGl;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TextureMappingAndKeyboards : Form
    {
        SoundPlayer sound;//string soundfile
        double eyex, eyey, eyez, atx, aty, atz;
        double x = 3.8, y = 0.5, z = 3.8; 

        double xrot, yrot, zrot;

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            paint();
        }

        private void button1_Click(object sender, EventArgs e)
        {   play();
                  
        }
        private void play()
        {
            soundfile = @"dog.wav";
            sound = new SoundPlayer(soundfile);
            sound.PlayLooping();
            
        }

        private void drawhuman()
        {
            //draw car
            Gl.glPushMatrix();

            Gl.glColor3f(0, 0.5f, 0.5f);
            Gl.glTranslated(x, y, z);
            Gl.glScaled(0.5, 0.5, 0.5);
            //head
            Gl.glPushMatrix();
            Gl.glTranslated(0, 2.5, 0);
            Gl.glScaled(0.9, 0.8, 0.9);
            Glu.gluSphere(Glu.gluNewQuadric(), 0.5, 30, 30);
            Gl.glPopMatrix();
            //body
            Gl.glPushMatrix();
            Gl.glTranslated(0, 1, 0);
            Gl.glScaled(1, 2.5, 1);
            Glu.gluSphere(Glu.gluNewQuadric(), 0.5, 30, 30);
            Gl.glPopMatrix();

            Gl.glPopMatrix();
        }

        private void drawCar()
        {
            //draw car
            Gl.glPushMatrix();
            Gl.glColor3f(0, 0.5f, 0.5f);
            Gl.glTranslated(x, y, z);
            Gl.glScaled(0.5, 0.5, 0.5);

            //1
            Gl.glPushMatrix();
            Gl.glRotated(xrot1, 1, 0, 0);
            Glu.gluSphere(Glu.gluNewQuadric(), 0.5, 30, 30);
            Gl.glPopMatrix();
            //2
            Gl.glPushMatrix();
            Gl.glTranslated(0, 0, 2);
            Gl.glRotated(xrot1, 1, 0, 0);
            Glu.gluSphere(Glu.gluNewQuadric(), 0.5, 30, 30);
            Gl.glPopMatrix();
            //ceiling car
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glVertex3d(0, 0.6, -1);
            Gl.glVertex3d(0, 0.6, 3);
            Gl.glVertex3d(0, 1.5, 3);
            Gl.glVertex3d(0, 1.5, 2);
            Gl.glVertex3d(0, 2.5, 2);
            Gl.glVertex3d(0, 2.5, -1);
            Gl.glEnd();
            Gl.glPopMatrix();
        }

        private void drawplane()
        {
            //step1
            image = new Bitmap("chicken.jpg");
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
            bitmapdata = image.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            //step2
            Gl.glGenTextures(1, texture);
            Gl.glActiveTexture(Gl.GL_TEXTURE0);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, texture[0]);
            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, (int)Gl.GL_RGB8, image.Width, image.Height, 0, Gl.GL_BGR_EXT, Gl.GL_UNSIGNED_BYTE, bitmapdata.Scan0);
            Gl.glTexParameteri((int)Gl.GL_TEXTURE_2D, (int)Gl.GL_TEXTURE_MIN_FILTER, (int)Gl.GL_NEAREST);//gl_Linear
                                                                                                         //ແຕ້ມແຜ່ນພຽງ
                                                                                                         //step3 change picture
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(-4, 0, -4);
            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(4, 0, -4);
            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(4, 0, 4);
            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(-4, 0, 4);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            image.UnlockBits(bitmapdata);
            image.Dispose();

        }
        private void drawdisk()
        {
            image2 = new Bitmap("dog.jpg");
            Rectangle rect2 = new Rectangle(0, 0, image2.Width, image2.Height);
            bitmapdata2 = image2.LockBits(rect2, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            //step2
            Gl.glGenTextures(1, texture);
            Gl.glActiveTexture(Gl.GL_TEXTURE1);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, texture[1]);
            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, (int)Gl.GL_RGB8, image2.Width, image2.Height, 0, Gl.GL_BGR_EXT, Gl.GL_UNSIGNED_BYTE, bitmapdata2.Scan0);
            Gl.glTexGeni(Gl.GL_S, Gl.GL_TEXTURE_GEN_MODE, Gl.GL_OBJECT_LINEAR);//gl_sphere_map
            Gl.glTexGeni(Gl.GL_T, Gl.GL_TEXTURE_GEN_MODE, Gl.GL_OBJECT_LINEAR);//GL_OBJECT_LINEAR
            Gl.glEnable(Gl.GL_TEXTURE_GEN_S);
            Gl.glEnable(Gl.GL_TEXTURE_GEN_T);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_S, Gl.GL_REPEAT);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_T, Gl.GL_REPEAT);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_NEAREST);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_NEAREST);

            Gl.glPushMatrix();
            Gl.glRotated(xrot1, 0, 1, 0);
            Gl.glScaled(0.5, 0.5, 0.5);
            Glu.gluDisk(Glu.gluNewQuadric(), 0.1, 0.5, 15, 15);
            Glu.gluSphere(Glu.gluNewQuadric(), 1, 30, 30);
            Gl.glPopMatrix();

            Gl.glDisable(Gl.GL_TEXTURE_2D);
            image2.UnlockBits(bitmapdata2);
            image2.Dispose();
        }

        private void simpleOpenGlControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'w' || e.KeyChar == 'W')
            {
                if (x > (-3.5))
                    x -= 0.2;
            }
            if (e.KeyChar == 's' || e.KeyChar == 'W')
            {
                if (x < (3.5))
                    x += 0.2;
            }
            if (e.KeyChar == 'a' || e.KeyChar == 'A')
            {
                if (z > (3.5))
                    z += 0.2;
            }
            if (e.KeyChar == 'd' || e.KeyChar == 'D')
            {
                if (z > (-3.5))
                    z -= 0.2;
            }
            if (e.KeyChar == 'i' || e.KeyChar == 'I')
            {//eyex-=0.8;eyez-=0.8;
                eyex -= 0.8;
            }
            if (e.KeyChar == 'o' || e.KeyChar == 'O')
            {
                //eyex+=0.8;eyez+=0.8;
                eyex += 0.8;
            }
            if (e.KeyChar == 'x' || e.KeyChar == 'X')
            {
                xrot += 15;
            }
            if (e.KeyChar == 'y' || e.KeyChar == 'Y')
            {
                yrot += 15;

            }
            if (e.KeyChar == 'z' || e.KeyChar == 'Z')
            {
                zrot += 15;

            }
            if (e.KeyChar == 'l' || e.KeyChar == 'L')
            {
                eyez -= 0.5;atz -= 0.5;    
            }if (e.KeyChar == 'k' || e.KeyChar == 'K')
            {
                eyez += 0.5;atz += 0.5;    
            }
            simpleOpenGlControl1.Invalidate();
        }

        private void paint()
        {
            Gl.glClearColor(0.8f, 0.8f, 0.8f, 0);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Glu.gluLookAt(eyex, eyey, eyez, atx, aty, atz, 0, 1, 0);
            //begin draw graph
            Gl.glPushMatrix();
            Gl.glRotated(xrot, 1, 0, 0);
            Gl.glRotated(yrot, 0, 1, 0);
            Gl.glRotated(zrot, 0, 0, 1);
            Gl.glColor3f(1, 1, 1);
            drawplane();//pean peing
            Gl.glPushMatrix();
            Gl.glTranslated(0, 0, 4.0);
            drawdisk();
            Gl.glPopMatrix();

            Gl.glPopMatrix();


        }

        double xrot1, xmove, xmove2;
        private void timer1_Tick(object sender, EventArgs e)
        {
            xrot += 15; simpleOpenGlControl1.Invalidate();
        }

        Bitmap image, image2;
        String soundfile;
        BitmapData bitmapdata, bitmapdata2;
        uint[] texture = new uint[2];
        public TextureMappingAndKeyboards()
        {
            InitializeComponent();
            simpleOpenGlControl1.InitializeContexts();
            simpleOpenGlControl1.SwapBuffers();
            int w = simpleOpenGlControl1.Width;
            int h = simpleOpenGlControl1.Height;
            Gl.glViewport(0, 0, w, h);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45.0f, (double)w / (double)h, 0.1f, 5000.0f);
            eyey = 5; eyex = 15; eyez = 0; atx = aty = 0; atz = 0;
            xrot = yrot = zrot = xrot1; xmove = 3.8; xmove2 = 2.0;
            x = 0; y = 0; z = 0;
        }

        private void TextureMappingAndKeyboards_Load(object sender, EventArgs e)
        {
           //play();

        }
    }
}
