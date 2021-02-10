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
namespace WindowsFormsApp1
{
    public partial class HOMEWORK1 : Form
    {
        Graphics g;
        Pen p;
        float ps;
        Brush b;



        public HOMEWORK1()
        {
            InitializeComponent();
            ps = 1.0f;
            b = new SolidBrush(Color.Orange);
            btncolor.BackColor = ((SolidBrush)b).Color;
        }

        private void HOMEWORK1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            p = new Pen(Color.BlueViolet, ps);
            g.DrawRectangle(p, 50, 50, 200, 200);
            g.FillRectangle(b, 51, 51, 198, 198);
            g.DrawEllipse(p, 50, 250, 100, 200);
            g.FillEllipse(b, 51, 251, 98, 198);
            Font t = new Font("saysetha OT", 16);
            g.DrawString("ວີຊາຄອມພິວເຕີ ກຣາຟຟິກ", t, Brushes.Black, 200, 300);
            g.Dispose();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            p = new Pen(Color.BlueViolet, ps);
            g.DrawRectangle(p, 50, 50, 200, 200);
            g.FillRectangle(b, 51, 51, 198, 198);
            g.DrawEllipse(p, 50, 250, 100, 200);
            g.FillEllipse(b, 51, 251, 98, 198);
            Font t = new Font("saysetha OT", 16);
            g.DrawString("ວີຊາຄອມພິວເຕີ ກຣາຟຟິກ", t, Brushes.Black, 200, 300);
            g.Dispose();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ps = (float)numericUpDown1.Value;
            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            g.Dispose();
        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            if (clr.ShowDialog() == DialogResult.OK)
            {
                btncolor.BackColor = clr.Color;
                b = new SolidBrush(clr.Color);
                Invalidate();
            }
        }

        private void HOMEWORK1_Load(object sender, EventArgs e)
        {

        }
    }
}
