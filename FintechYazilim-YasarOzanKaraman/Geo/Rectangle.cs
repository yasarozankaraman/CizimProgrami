using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FintechYazilim_YasarOzanKaraman
{
    class Rectangle:Shape
    {
        private int sx,sy,bx,by;
        Bitmap Bm;

        public override void Picture(int x, int y, int cx, int cy)
        {
            sx = x - cx;
            sy = y - cy;    
            Bm= new Bitmap(sx, sy);
            
        }
        public override void Fill(Graphics graphics,SolidBrush brush,int x, int y, int cx, int cy)
        {
            bx = cx;  
            by= cy;
            sx = Math.Abs(x -cx);
            sy= Math.Abs(y - cy);
            graphics.FillRectangle(brush,bx,by,sx,sy);

        }

     
    }
}
