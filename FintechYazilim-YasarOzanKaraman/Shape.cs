using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FintechYazilim_YasarOzanKaraman
{
    class Shape
    {
        private int x, y;
        public int X,Y;
        public virtual void ObjectStart(int sx,int sy)
        {

        }
        public virtual void ObjectFinish(int fx, int fy)
        {

        }
        public virtual void Fill(Graphics graphics,SolidBrush brush,int x,int y,int cx,int cy)
        {

        }
    }
}
