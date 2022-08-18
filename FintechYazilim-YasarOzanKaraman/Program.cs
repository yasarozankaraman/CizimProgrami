using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FintechYazilim_YasarOzanKaraman
{
     public class Dragger
    {
        private readonly Form _parent;
        private Panel _dragee;

        public Dragger(Form parent)
        {
            _parent = parent;
        }

        public void MouseMoved(object sender, MouseEventArgs e)
        {
            if (_dragee != null)
            {
                _dragee.Location = _parent.PointToClient(Cursor.Position);
            }
        }

        public void StartDragging(Panel panel)
        {
            _dragee = panel;
        }

        public void StopDragging()
        {
            _dragee = null;
        }
    }

    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
