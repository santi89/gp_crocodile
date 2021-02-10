using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    public partial class labwork : Form
    {
        public labwork()
        {
            InitializeComponent();
        }

        private void DrawArrow(Pen p,Graphics g)
        {
            Point[] pts =
            {
                new Point(50,50),new Point(150,50),
                new Point(150,20),new Point(200,70),
                new Point(150,120),new Point(150,90),
                new Point(50,90)
            };
            g.DrawPolygon(p, pts);
        }
        private Matrix RotateAroundPoint(float angle, Point center)
        {
            Matrix result = new Matrix();
            result.RotateAt(angle,center);
            return result;
        }
        private Matrix Translate(int a,int b)
        {
            Matrix m = new Matrix();
            m.Translate(a, b);
            return m;
        }

        private Matrix ShearingArrow(float x, float y)
        {
            Matrix result = new Matrix();
            result.Shear(x, y);
            return result;
        }
        private Matrix ScaleArrow(float x,float y)
        {
            Matrix result = new Matrix();
            result.Scale(x, y);
            return result;
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            DrawArrow(Pens.Black, g);
            //Matrix m = new Matrix();
            ////m.Translate(100, 100);
            //m.Scale(2, 3);
            //g.Transform = m;
            Point c = new Point(50, 70);
            g.FillEllipse(Brushes.Red, c.X - 3, c.Y - 3, 6, 6);
            g.Transform = RotateAroundPoint(30,c);
            DrawArrow(Pens.DeepPink, g);

            g.Transform = ShearingArrow(1, 2);
            DrawArrow(Pens.Blue, g);

            Graphics g2 = Graphics.FromImage(bmp);
            g2.Transform = Translate(150, 150);
            DrawArrow(Pens.Red, g2);

            g2.Transform = ScaleArrow(2, 3);
            DrawArrow(Pens.BlueViolet, g2);


            pictureBox1.Image = bmp;
            g.Dispose();
            
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Save Drawed Image";
            sf.DefaultExt = "*.jpg";
            sf.Filter = "Jpeg Files(*.jpg)|*.jpg|PNG Files(*.png)|Bitmap Files(*.bmp)|*.bmp";
            if (sf.ShowDialog() == DialogResult.OK)
                {
                pictureBox1.Image.Save(sf.FileName);
                 }
        }

        private void labwork_Load(object sender, EventArgs e)
        {

        }
    }
}
