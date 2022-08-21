using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FintechYazilim_YasarOzanKaraman
{
    class Ellips:Shape
    {

        private int sx, sy, bx, by;
        public override PictureBox Pic(SolidBrush brush, int x, int y, int cx, int cy)
        {
            sx = Math.Abs(cx - x);
            sy = Math.Abs(cy - y);
            PictureBox myPicture = new PictureBox();
            myPicture.Location = new Point(cx, cy);
            myPicture.Size = new Size(sx, sy);
            var deneme = new Bitmap(sx, sy);
            var graphis = Graphics.FromImage(deneme);
            myPicture.Image = deneme;
            graphis.FillEllipse(brush, 0, 0, sx, sy);
            return myPicture;

        }
        public override void Fill(Graphics graphics, SolidBrush brush, int x, int y, int cx, int cy)
        {
            bx = cx;
            by = cy;
            sx = Math.Abs(x - cx);
            sy = Math.Abs(y - cy);
            graphics.FillEllipse(brush, bx, by, sx, sy);
        }

      
    }
}
