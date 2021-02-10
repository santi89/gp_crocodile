using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class fish : Form
    {
        public fish()
        {
            InitializeComponent();
        }

        private void fish_Load(object sender, EventArgs e)
        {

        }
        private void seewave()
        {
            gp = CreateGraphics();
            Pen ps = new Pen(Color.LightBlue, 2);

            Point p1 = new Point(250, 300);//be up line
            Point p2= new Point(250, 320);
            Point p3 = new Point(220, 340);

            Point p4 = new Point(250, 340);//be drown line
            Point p5 = new Point(300, 300);
            Point p6 = new Point(220, 340);
            Point[] arrPSW = { p1,p2,p3,p4,p5};

            gp.DrawCurve(ps, arrPSW);
        }
        private void fishdraw()
        {

            gp = CreateGraphics();
            Pen p = new Pen(Color.Black, 3);
            Pen p1 = new Pen(Color.Black, 1);

            Point pt4c = new Point(475, 150);
            Point pt4b = new Point(440, 190);
            Point pt4a = new Point(440, 170);

            Point pt3b = new Point(460, 155);
            Point pt3a = new Point(420, 190);

            Point pt2b = new Point(430, 160);
            Point pt2a = new Point(390, 180);

            Point pt1b = new Point(325, 235);
            Point pt1a = new Point(340, 290);
            Point pt1 = new Point(290, 270);
            Point pt2 = new Point(244, 290);
            Point pt3 = new Point(265, 250);

            Point pt4 = new Point(300, 220);
            Point pt5 = new Point(317, 195);

            Point pt6 = new Point(335, 150);
            Point pt7 = new Point(375, 90);
            Point pt8 = new Point(360, 50);//wing
            Point pt9 = new Point(420, 77);
            Point pt10 = new Point(470, 76);
            Point pt11 = new Point(500, 85);
            Point pt13 = new Point(520, 110);
            Point pt12 = new Point(550, 130);//head
            Point pt14 = new Point(530, 140);


            Point ps1 = new Point(530, 140);
            Point ps2 = new Point(530, 140);
            Point ps3 = new Point(500, 135);

            Point[] ps = { ps1, ps2, ps3 };

            Point[] pt = { pt14, pt12, pt13, pt11, pt10, pt9, pt8, pt7, pt6, pt5, pt4, pt3, pt2, pt1, pt1a, pt1b, pt2a, pt2b, pt3a, pt3b, pt14 };

            Point[] pp = { pt4a, pt4b, pt4c };
            gp.DrawClosedCurve(p, pp);
            gp.FillClosedCurve(Brushes.CadetBlue, pp);
            // gp.DrawPolygon(p1, pt);
            gp.DrawClosedCurve(p, pt, 0.5f, FillMode.Alternate);
            gp.FillClosedCurve(Brushes.SkyBlue, pt);
            //  gp.DrawCurve(p,pt,0.3f);
            gp.DrawEllipse(p, 490, 110, 10, 10);
            gp.FillEllipse(Brushes.LightBlue, 490, 110, 10, 10);
            gp.DrawEllipse(p, 495, 110, 5, 5);

            gp.DrawCurve(p1, ps, 1f);

        }
        Graphics gp;
        private void fish_Paint(object sender, PaintEventArgs e)
        {
            seewave();
            fishdraw();

        }
    }
}
