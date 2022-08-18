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
        SolidBrush brusher = new SolidBrush(Color.Black);
        PointF point1, point2, point3,point4;

        private int sx,sy,bx,by;
        Point StartXY;
        Point EndXY;    
        
        public override void Fill(Graphics graphics,SolidBrush brush,int x, int y, int cx, int cy)
        {/*
            point1 = new Point(Math.Abs(x - 2 * cx), Math.Abs(y - 2 * cy));
            point2 = new Point(Math.Abs(x-cx), Math.Abs(y - 2 * cy));
            point3 = new Point(Math.Abs(x-2*cx), y);   
            point4 = new Point(x, y);
            PointF[] curvePoints = { point1, point2, point3,point4 };
            graphics.FillPolygon(brush, curvePoints);*/
            bx = cx;  
            by= cy;
            sx = Math.Abs(x -cx);
            sy= Math.Abs(y - cy);
            graphics.FillRectangle(brush,bx,by,sx,sy);

            

        }

    
    }
}
