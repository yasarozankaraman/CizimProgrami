using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FintechYazilim_YasarOzanKaraman
{
    class Triangle:Shape
    {
        PointF point1, point2, point3;
        public override void Picture(int x, int y, int cx, int cy)
        {
            throw new NotImplementedException();
        }
        public override void Fill(Graphics graphics, SolidBrush brush, int x, int y, int cx, int cy)
        {
            point1 = new Point(cx, Math.Abs(y - 2 * cy));
            point2 = new Point(Math.Abs(x - 2 * cx), y);
            point3 = new Point(x, y);
            PointF[] curvePoints = { point1, point2, point3 };
            graphics.FillPolygon(brush, curvePoints);
        }
    }
}
