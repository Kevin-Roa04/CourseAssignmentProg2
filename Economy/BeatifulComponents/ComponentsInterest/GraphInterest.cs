using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Economy.BeatifulComponents.ComponentsInterest
{
    public partial class GraphInterest : UserControl
    {

        private int Coord_x = 0, coord_y;
        Graphics graphics;
        private Pen pen = new Pen(color: Color.Black, width: 1);
        public int TotalPeriod { get; set; }

        public GraphInterest()
        {
            InitializeComponent();
            coord_y = (int)(this.pnGraph.Width * .5);
            graphics = pnGraph.CreateGraphics();
        }

        private void pnGraph_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void DrawPlane(int TotalPeriod)
        {
            graphics = pnGraph.CreateGraphics();
            TotalPeriod += 1;
            Point[] points =
             {
               new Point(Coord_x,coord_y),
                new Point(Coord_x+pnGraph.Width,coord_y),
                new Point(Coord_x,coord_y)
            };
            graphics.DrawLines(pen, points);
            int SpaceBetweenNumbers = (int)(double)pnGraph.Width / TotalPeriod;

            Font drawFont = new Font("Arial", 9);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            for (int i = 0; i < TotalPeriod; i++)
            {
                PointF point = new PointF((SpaceBetweenNumbers * i), coord_y - 15);
                graphics.DrawString($"{i}", drawFont, drawBrush, point);

            }
            this.pnGraph.Invalidate();
        }

    }
}
