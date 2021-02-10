using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class homework3 : Form
    {
        Graphics g;
        SolidBrush b;
        Pen p;
        Bitmap im, bmp;
        int ps;



        public void homework4()
        {
            g = this.CreateGraphics();
            p = new Pen(Color.YellowGreen, ps);
            Point pt1 = new Point(20, 30);
            Point pt2 = new Point(30, 40);
            Point pt3 = new Point(50, 50);
            Point[] pt = { pt1, pt2, pt3 };
            g.DrawCurve(p, pt);
            Point[] ptt = { new Point(50, 50), new Point(80, 80), new Point(125, 80), new Point(200, 50), new Point(140, 20), new Point(80, 20) };
            g.FillClosedCurve(b, ptt);
            g.DrawClosedCurve(p, ptt);
            g.DrawLine(p, 70, 50, 160, 45);
            g.DrawLine(p, 70, 55, 100, 70);
            g.DrawLine(p, 110, 55, 135, 70);
            g.DrawLine(p, 105, 40, 125, 25);
            g.Dispose();
        }

        public homework3()
        {
            InitializeComponent();
            b = new SolidBrush(Color.Orange);
            btncolor.BackColor = ((SolidBrush)b).Color;
            p = new Pen(b.Color, 3);
            im = new Bitmap("E:\\work\\Graphic\\WindowsFormsApp1\\WindowsFormsApp1\\animal.jpg");
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
 bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.DrawImage(im, 10, 10, 200, 200);
            g.DrawRectangle(p, 10, 10, 200, 200);
            e.Graphics.DrawImage(bmp, 0, 0);
            pictureBox1.Image = bmp;
            g.Dispose();
            Invalidate();
        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            if (clr.ShowDialog() == DialogResult.OK)
            {
                btncolor.BackColor = clr.Color;
                b = new SolidBrush(clr.Color);
                p = new Pen(clr.Color, 3);
                pictureBox1.Invalidate();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "save drawed image";
            sf.DefaultExt = "*.jpg";
            sf.Filter = "Jpeg Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|BNP Files(*.bmp)|*bmp";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(sf.FileName);
            }
        }

        private void cmbline_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbline.SelectedItem == "Dash")
            {
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                pictureBox1.Refresh();
            }
            if (cmbline.SelectedItem == "Dashdot")
            {
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
                pictureBox1.Refresh();
            }
            if (cmbline.SelectedItem == "Dashdotdot")
            {
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
                pictureBox1.Refresh();
                   }
            if (cmbline.SelectedItem=="Solid")
            {
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                pictureBox1.Refresh();
            }
        }

        private void homework3_Load(object sender, EventArgs e)
        {
            cmbline.Items.Add("Dash");
            cmbline.Items.Add("DashDot");
            cmbline.Items.Add("DashDotDot");
            cmbline.Items.Add("Solid");
        }

       

        private void homework3_Paint(object sender, PaintEventArgs e)
        {
           // homework4();

        }
    }
}
