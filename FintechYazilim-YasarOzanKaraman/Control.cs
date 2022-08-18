using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace FintechYazilim_YasarOzanKaraman
{
    public static class ControlExtension
    {
        private static Dictionary<Control, bool> draggables =
                   new Dictionary<Control, bool>();
        private static Size mouseOffset;
   
        public static void Draggable(this Control control, bool enable)
        {
            if (enable)
            {
               
                if (draggables.ContainsKey(control))
                {  
                    return;
                }
                draggables.Add(control, false);

      
                control.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
                control.MouseUp += new MouseEventHandler(pictureBox1_MouseUp);
                control.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);
            }
            else
            {
                if (!draggables.ContainsKey(control))
                {  
                    return;
                }
                // 
                control.MouseDown -= pictureBox1_MouseDown;
                control.MouseUp -= pictureBox1_MouseUp;
                control.MouseMove -= pictureBox1_MouseMove;
                draggables.Remove(control);
            }
        }

        static void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseOffset = new Size(e.Location);
            // turning on dragging
            draggables[(Control)sender] = true;
        }

        static void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            // turning off dragging
            draggables[(Control)sender] = false;
        }

        static void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // only if dragging is turned on
            if (draggables[(Control)sender] == true)
            {
                // calculations of control's new position
                Point newLocationOffset = e.Location - mouseOffset;
                ((Control)sender).Left += newLocationOffset.X;
                ((Control)sender).Top += newLocationOffset.Y;
            }
        }
    }
}

