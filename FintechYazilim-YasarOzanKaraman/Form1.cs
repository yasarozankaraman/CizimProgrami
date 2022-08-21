using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using FintechYazilim_YasarOzanKaraman;
using System.Diagnostics;

namespace FintechYazilim_YasarOzanKaraman
{
    public partial class Form1 : Form
    {

        Bitmap bm;
        Graphics g;
        bool paint = false;
        bool control = false;
        int x, y, cx, cy, sx, sy;
        int index;
        SolidBrush brusher = new SolidBrush(Color.Black);
        Rectangle myRectangle = new Rectangle();
        Ellips myEllips = new Ellips();
        Triangle myTri = new Triangle();
        Hexagon myHex = new Hexagon();
        PictureBox myPicture;
        List<PictureBox> pictureBoxList = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox1.Image = bm;

        }
        private Control activeControl;
        private Point previousPosition;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Refresh();
            x = e.X;
            y = e.Y;
            sx = e.X - cx;
            sy = e.Y - cy;

        }
        public void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sx = Math.Abs(cx - x);
            sy = Math.Abs(cy - y);

            if (index == 1)
            {
                Rectangle myRectangle = new Rectangle();
                myPicture = myRectangle.Pic(brusher, x, y, cx, cy);
                myPicture.BackColor = Color.Transparent;
                pictureBox1.Controls.Add(myPicture);
                Control(myPicture);
            }
            if (index == 2)
            {
                Ellips myEllips = new Ellips();
                myPicture = myEllips.Pic(brusher, x, y, cx, cy);
                myPicture.BackColor = Color.Transparent;
                pictureBox1.Controls.Add(myPicture);
                Control(myPicture);
            }
            if (index == 3)
            {
               Triangle myTri = new Triangle();
               myPicture = myTri.Pic(brusher, x, y, cx, cy);
               pictureBox1.Controls.Add(myPicture);
               Control(myPicture);

                //Triangle myTri = new Triangle();
                //myTri.Fill(g, brusher, x, y, cx, cy);
            }
            if (index == 4)
            {
                Hexagon myHex = new Hexagon();
                myHex.Fill(g, brusher, x, y, cx, cy);
            }
         //   Control(myPicture);
          //  pictureBoxList.Add(myPicture);
          //  pictureBox1.Controls.Add(myPicture);
        }

        void Control(PictureBox pictureBox)
        {
            if (myPicture != null)
            {
                myPicture.MouseDown += new MouseEventHandler(Picture_MouseDown);
                myPicture.MouseMove += new MouseEventHandler(Picture_MouseMove);
                myPicture.MouseUp += new MouseEventHandler(Picture_MouseUp);
            }
        }
        public void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            cx = e.X;
            cy = e.Y;

        }
        public void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint)
            {
                if (index == 1)
                {
                    myRectangle.Fill(g, brusher, x, y, cx, cy);

                }
                if (index == 2)
                {
                    myEllips.Fill(g, brusher, x, y, cx, cy);
                }
                if (index == 3)
                {
                    myTri.Fill(g, brusher, x, y, cx, cy);
                }
                if (index == 4)
                {
                    myHex.Fill(g, brusher, x, y, cx, cy);
                }

            }

        }
        public void Picture_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Picture_MouseUp(object sender, MouseEventArgs e)
        {
            activeControl = null;
            Cursor = Cursors.Default;
        }
        public void Picture_MouseMove(object sender, MouseEventArgs e)
        {

            if (activeControl == null || activeControl != sender)
            {
                return;
            }
            var location = activeControl.Location;
            location.Offset(e.Location.X - previousPosition.X, e.Location.Y - previousPosition.Y);
            activeControl.Location = location;

        }
        public void Picture_MouseDown(object sender, MouseEventArgs e)
        {
            if (control == true)
            {
                activeControl = sender as Control;
                previousPosition = e.Location;
                Cursor = Cursors.Hand;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index = 1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        public void button3_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            index = 4;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            brusher = new SolidBrush(Color.Red);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            brusher = new SolidBrush(Color.Blue);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            brusher = new SolidBrush(Color.Green);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            brusher = new SolidBrush(Color.Orange);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            brusher = new SolidBrush(Color.Black);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            brusher = new SolidBrush(Color.Yellow);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            brusher = new SolidBrush(Color.Purple);

        }
        private void button12_Click(object sender, EventArgs e)
        {
            brusher = new SolidBrush(Color.Brown);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            brusher = new SolidBrush(Color.White);

        }
        private void button16_Click(object sender, EventArgs e)
        {
            pictureBoxList.Clear();
            index = 7;
            g.Clear(Color.White);
            pictureBox1.Image = bm;

        }

        public void button18_Click(object sender, EventArgs e)
        {
            index = 5;
            control = true;
        }
        public void button18_(object sender, EventArgs e)
        {
        }
        private void button17_Click(object sender, EventArgs e)
        {


        }

        private void button19_Click(object sender, EventArgs e)
        {
            index = 6;
            control = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {

            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "Text|*.txt|All|*.*";
            file.FileName = "";
            DialogResult ok = file.ShowDialog();
            if (ok == DialogResult.OK)
            {
                var bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                var graphis = Graphics.FromImage(bitmap);
                var rectangle = pictureBox1.RectangleToScreen(pictureBox1.ClientRectangle);
                graphis.CopyFromScreen(rectangle.Location, Point.Empty, pictureBox1.Size);
                //bitmap.Save(file.FileName);
                pictureBox1.Image.Save(file.FileName);

            }
        }
        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.FileName = "";
            dialog.Filter = "Text|*.txt|All|*.*";

            DialogResult ok = dialog.ShowDialog();
            if (ok == DialogResult.OK)
            {
                pictureBox1.ImageLocation = dialog.FileName;

            }

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

    }
}
