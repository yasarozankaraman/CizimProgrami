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

        private int r;

        private int sx, sy, bx, by;
        public override void Picture(int x, int y, int cx, int cy)
        {
            throw new NotImplementedException();
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
