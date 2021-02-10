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
    public partial class homework4 : Form
    {
        int ps;
        SolidBrush sb;
        Graphics g;
        Pen p;
        public homework4()
        {
            InitializeComponent();
            ps = 2;
            sb = new SolidBrush(Color.OrangeRed);
        }

        private void homework4_Paint(object sender, PaintEventArgs e)
        {
            g = this.CreateGraphics();
            p = new Pen(Color.YellowGreen, ps);
            Point pt1 = new Point(20, 30);
            Point pt2 = new Point(30, 40);
            Point pt3 = new Point(50, 50);
            Point[] pt = { pt1, pt2, pt3 };
            g.DrawCurve(p, pt);
            Point[] ptt = { new Point(50, 50), new Point(80, 80), new Point(125, 80), new Point(200, 50), new Point(140, 20), new Point(80, 20) };
            g.FillClosedCurve(sb, ptt);
            g.DrawClosedCurve(p, ptt);
            g.DrawLine(p, 70, 50, 160, 45);
            g.DrawLine(p, 70, 55, 100, 70);
            g.DrawLine(p, 110, 55, 135, 70);
            g.DrawLine(p, 105, 40, 125, 25);
            g.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            ColorDialog cld = new ColorDialog();
            if (cld.ShowDialog() == DialogResult.OK)
            {
                sb = new SolidBrush(cld.Color);
                Invalidate();
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ps = (int)numericUpDown1.Value;
            Invalidate();

        }
    }
}
