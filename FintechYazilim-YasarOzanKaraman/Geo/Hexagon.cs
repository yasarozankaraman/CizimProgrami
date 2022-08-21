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
        private int sx, sy;
        public override PictureBox Pic(SolidBrush brush, int x, int y, int cx, int cy)
        {
            sx = Math.Abs(cx - x);
            sy = Math.Abs(cy - y);
            PictureBox myPicture = new PictureBox();
            myPicture.Location = new Point(x-3*Math.Abs(x - cx), y-2*Math.Abs(y - cy));
            myPicture.Size = new Size(sx * 4, sy * 2);
            var deneme = new Bitmap(sx * 4, sy * 2);
            var graphis = Graphics.FromImage(deneme);
            myPicture.Image = deneme;
            point1 = new Point(myPicture.Width, myPicture.Height/2);
            point2 = new Point(myPicture.Width * 3 / 4,0);
            point3 = new Point(myPicture.Width / 4, 0);
            point4 = new Point(0, myPicture.Height/2);
            point5 = new Point(myPicture.Width/4, myPicture.Height);
            point6 = new Point(myPicture.Width * 3 / 4, myPicture.Height);
            PointF[] curvePoints = { point1, point2, point3, point4, point5, point6 };
            graphis.FillPolygon(brush, curvePoints);
           
            return myPicture;
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
