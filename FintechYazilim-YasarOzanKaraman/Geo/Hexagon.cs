using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FintechYazilim_YasarOzanKaraman
{
    class Hexagon : Shape
    {
        PointF point1, point2, point3, point4, point5, point6;
        public override PictureBox Pic(SolidBrush brush, int x, int y, int cx, int cy)
        {
            throw new NotImplementedException();
        }
        public override void Fill(Graphics graphics, SolidBrush brush, int x, int y, int cx, int cy)
        {
            point1 = new Point(Math.Abs(x+x-cx), cy);
            point2 = new Point(x, Math.Abs(y - 2 * cy));
            point3 = new Point(Math.Abs(x - 2 * (cx)), Math.Abs(y - 2 * cy));
            point4 = new Point(Math.Abs(cx-2*(x-cx)), cy);
            point5 = new Point(Math.Abs(x -2*(cx)), y);
            point6 = new Point(x, y);
            PointF[] curvePoints = { point1, point2, point3, point4, point5, point6 };
            graphics.FillPolygon(brush, curvePoints);
        }
    }
}
