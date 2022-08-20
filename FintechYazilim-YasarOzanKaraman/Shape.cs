using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FintechYazilim_YasarOzanKaraman
{
    abstract class Shape
    {
        public abstract void Fill(Graphics graphics, SolidBrush brush, int x, int y, int cx, int cy);
        public abstract void Picture(int x, int y, int cx, int cy);
    }
}
