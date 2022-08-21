using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FintechYazilim_YasarOzanKaraman
{
    class Triangle:Shape
    {
        PointF point1, point2, point3;
        int sx, sy;
        public override PictureBox Pic(SolidBrush brush,int x, int y, int cx, int cy)
        {
            sx = Math.Abs(cx - x);
            sy = Math.Abs(cy - y);
            PictureBox myPicture = new PictureBox();
            myPicture.Location= new Point(cx, cy);
            myPicture.Size = new Size(sx,sy);
            var deneme = new Bitmap(sx, sy);
            var graphis = Graphics.FromImage(deneme);
            myPicture.Image = deneme;
            point1 = new Point(x / 2, 0);
            point2 = new Point(0, y);
            point3 = new Point(x, y);
            PointF[] curvePoints = { point1, point2, point3 };
            graphis.FillPolygon(brush, curvePoints);
            // graphis.FillRectangle(brush, cx, cy, sx, sy);

            return myPicture;
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
