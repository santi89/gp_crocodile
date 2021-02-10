using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleOpenGlControl1_Load(object sender, EventArgs e)
        {

        }
        Graphics g;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            Pen p = new Pen(Color.Pink, 3);
            Pen p1 = new Pen(Color.Red, 4);
            Point pt1 = new Point(200, 250);
            Point pt2 = new Point(150, 200);
            Point pt3 = new Point(120, 250);
            Point pt4 = new Point(200, 350);
            Point pt5 = new Point(280, 250);
            Point pt6 = new Point(250, 200);
            Point[] pt =
            {
                pt1,pt2,pt3,pt4,pt5,pt6
            };

            p1.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            g.FillEllipse(Brushes.Green, 150, 150, 200, 200);
            g.DrawLine(p, 30, 30, 100, 100);

            g.DrawEllipse(p, 300, 300, 400, 400);
            g.DrawRectangle(p, 100, 100, 200, 200);
            g.FillRectangle(Brushes.Blue, 100, 100, 200, 200);

            g.DrawPolygon(p1, pt);
            g.DrawLines(p1, pt);
            Font f = new Font("Saysettha OT", 16);
            g.DrawString("ສະບາຍດີ", f, Brushes.DarkCyan, 100, 200);

            g.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            g.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            Pen p = new Pen(Color.Pink, 3);
            Pen p1 = new Pen(Color.Red, 4);
            Point pt1 = new Point(200, 250);
            Point pt2 = new Point(150, 200);
            Point pt3 = new Point(120, 250);
            Point pt4 = new Point(200, 350);
            Point pt5 = new Point(280, 250);
            Point pt6 = new Point(250, 200);
            Point[] pt =
            {
                pt1,pt2,pt3,pt4,pt5,pt6
            };

            p1.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            g.FillEllipse(Brushes.Green, 150, 150, 200, 200);
            g.DrawLine(p, 30, 30, 100, 100);

            Font f = new Font("Saysettha OT", 16);
            g.DrawString("ສະບາຍດີ", f, Brushes.DarkCyan, 100, 200);

            g.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            Pen p = new Pen(Color.Pink, 3);

            g.DrawRectangle(p, 100, 100, 200, 200);
            g.FillRectangle(Brushes.Blue, 100, 100, 200, 200);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* g.DrawPolygon(p1, pt);*/
            g = this.CreateGraphics();
            Point pt1 = new Point(200, 250);
            Point pt2 = new Point(150, 200);
            Point pt3 = new Point(120, 250);
            Point pt4 = new Point(200, 350);
            Point pt5 = new Point(280, 250);
            Point pt6 = new Point(250, 200);
            Point[] pt =
            {
                pt1,pt2,pt3,pt4,pt5,pt6
            };
            Pen p1 = new Pen(Color.Pink, 3);
            //g.DrawLines(p1, pt);
            g.DrawCurve(p1,pt);
            g.FillClosedCurve(Brushes.Pink, pt, FillMode.Alternate, 0.5f);
            g.DrawClosedCurve(p1, pt ,0.3f,FillMode.Alternate);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(Color.Pink, 3);
            g = this.CreateGraphics();
            g.DrawEllipse(p, 300, 300, 400, 400);

        }
    }
}
