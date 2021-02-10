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
    public partial class lab2 : Form
    {
        
        public lab2()
        {
                        InitializeComponent();
        }
        Region rg1, rg2;
        Graphics g;
        private Region TestRegion(Region region1)
        {
            GraphicsPath path1 = new GraphicsPath();
            Point[] pt =
            {
                new Point(0,0),new Point(0,300),new Point(300,300)
            };
            path1.AddPolygon(pt);
            region1 = new Region(path1);
            return region1;

        }
        private void Drawgrap(Region rg,Graphics g)
        {
            g.Clip = rg;
            Bitmap img = new Bitmap("123.jpg");
            g.DrawImage(img, 30, 0);
        }
        private Region TestRegion2(Region region2)
        {
            GraphicsPath path2 = new GraphicsPath();
            path2.AddEllipse(80, 0, 200, 200);
            region2 = new Region(path2);

            return region2;
        }
        private Region TestComplement (Region rg1, Region rg2)
        {
            
            rg1.Complement(rg2);
            return rg1;
        }
        private Region Testintersect(Region rg1, Region rg2)
        {
         

            rg1.Intersect(rg2);// ສະເພາະຈຸດຕັດ
            return rg1;
        }
        private Region Testunion(Region rg1, Region rg2)
        {
            rg1.Union(rg2);
            return rg1;
        }
        private Region TestExclude(Region rg1, Region rg2)
        {
          
            rg1.Exclude(rg2);
            return rg1;
        }
        private Region TestXor(Region rg1, Region rg2)
        {
            rg1.Xor(rg2);
            return rg1;
        }
        private void btncomplement_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            rg1 = TestRegion(rg1);
            rg2 = TestRegion2(rg2);
            TestComplement(rg1,rg2);
             Drawgrap(rg1,g);
            g.Dispose();
            
        }

        private void btnintersect_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            rg1 = TestRegion(rg1);
            rg2 = TestRegion2(rg2);
            Testintersect(rg1, rg2);
            Drawgrap(rg1, g);
            //Drawgrap(rg2, g);

            g.Dispose();
        }

        private void btnunion_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            rg1 = TestRegion(rg1);
            rg2 = TestRegion2(rg2);
            Testunion(rg1, rg2);

            Drawgrap(rg1, g);
            //Drawgrap(rg2, g);

            g.Dispose();
        }

        private void btnexclude_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            rg1 = TestRegion(rg1);
            rg2 = TestRegion2(rg2);
            TestExclude(rg1, rg2);

            Drawgrap(rg1, g);
            //Drawgrap(rg2, g);

            g.Dispose();
        }

        private void btnxor_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            rg1 = TestRegion(rg1);
            rg2 = TestRegion2(rg2);
            TestXor(rg1, rg2);
            Drawgrap(rg1, g);
            //Drawgrap(rg2, g);
            g.Dispose();
        }

        private void lab2_Load(object sender, EventArgs e)
        {

        }
    }
}
