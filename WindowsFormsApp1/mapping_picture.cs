using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;
using System.Media;


namespace WindowsFormsApp1
{
    public partial class mapping_picture : Form
    {
        SoundPlayer splay;
        Bitmap image= new Bitmap("123.jpg");
        public mapping_picture()
        {
            InitializeComponent();
            simpleOpenGlControl1.InitializeContexts();
            simpleOpenGlControl1.SwapBuffers();
            int w = simpleOpenGlControl1.Width;
            int h = simpleOpenGlControl1.Height;
            Gl.glViewport(0, 0, w, h);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (double)(w / h), 0.1, 5000);

        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClearColor(0.8f, 0.8f, 0.8f, 0.0f);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Glu.gluLookAt(4, 4, 4, 0, 0, -1, 0, 1, 0);

            //Texture Mapping //step1
            //Gl.glEnable(Gl.GL_TEXTURE_2D);
            //image = new Bitmap("123.jpg");
            //BitmapData bitmapdata;
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
            BitmapData bitmapdata = image.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            //step2
            uint[] texture = new uint[1];
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glGenTextures(1, texture);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, texture[0]);
            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, (int)Gl.GL_RGB8, image.Width, image.Height, 0,
                            Gl.GL_BGR_EXT, Gl.GL_UNSIGNED_BYTE, bitmapdata.Scan0);
            Gl.glTexParameteri((int)Gl.GL_TEXTURE_2D, (int)Gl.GL_TEXTURE_MIN_FILTER, (int)Gl.GL_NEAREST);//GL_LINEAR
                                                                                                         //step3
            float sz = 2.0f;
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(-sz, -sz, 0.0f);

            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(sz, -sz, 0.0f);

            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(sz, sz, 0.0f);

            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(-sz, sz, 0.0f);
            Gl.glEnd();

            image.UnlockBits(bitmapdata);
            image.Dispose();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            image = new Bitmap("chicken.jpg");
            splay = new SoundPlayer(@"chicken.wav");
        
            splay.Play();
            simpleOpenGlControl1.Invalidate();
        }

        private void rdcat_CheckedChanged(object sender, EventArgs e)
        {

            image = new Bitmap("cat.jpg");
            splay = new SoundPlayer(@"cat.wav");
            splay.Play();
            simpleOpenGlControl1.Invalidate();



        }

        private void rddog_CheckedChanged(object sender, EventArgs e)
        {
            image = new Bitmap("dog.jpg");
            splay = new SoundPlayer(@"dog.wav");
            splay.Play();
            simpleOpenGlControl1.Invalidate();
        }

        private void rdbird_CheckedChanged(object sender, EventArgs e)
        {
            image = new Bitmap("bird.jpg");
            splay = new SoundPlayer(@"eagle.wav");
            splay.Play();
            simpleOpenGlControl1.Invalidate();
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            if (splay != null)
            {
                splay.Play();
            }
        }

        private void btnpause_Click(object sender, EventArgs e)
        {
            if (splay != null)
                splay.Stop();
        }

        private void mapping_picture_Load(object sender, EventArgs e)
        {

        }
    }
}
