﻿using System;
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

        Bitmap bm, deneme;
        Graphics g, graphic;
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
            sx = x - cx;
            sy = y - cy;

            if (index == 1)
            {/*
                myPicture = new PictureBox();
                myPicture.Width = x - cx;
                myPicture.Height = y - cy;
                myPicture.Location = new Point(cx, cy);
                myPicture.Size = new Size(sx, sy);
                g=myPicture.CreateGraphics();
                g.FillRectangle(brusher, cx, cy, sx, sy);
                myPicture.MouseDown += new MouseEventHandler(Picture_MouseDown);
                myPicture.MouseMove += new MouseEventHandler(Picture_MouseMove);
                myPicture.MouseUp += new MouseEventHandler(Picture_MouseUp);

                pictureBox1.Controls.Add(myPicture);*/
                myRectangle = new Rectangle();
                myRectangle.Fill(g, brusher, x, y, cx, cy);


            }
            if (index == 2)
            {/*
                myPicture = new PictureBox();
                myPicture.Location = new Point(cx, cy);
                myPicture.Size = new Size(sx, sy);
                deneme = new Bitmap(sx, sy);
                graphic = Graphics.FromImage(deneme);
                
                myPicture.MouseDown += new MouseEventHandler(Picture_MouseDown);
                myPicture.MouseMove += new MouseEventHandler(Picture_MouseMove);
                myPicture.MouseUp += new MouseEventHandler(Picture_MouseUp);

                pictureBox1.Controls.Add(myPicture);*/
                myEllips = new Ellips();
                myEllips.Fill(g, brusher, x, y, cx, cy);
            }
            if (index == 3)
            {
                myTri = new Triangle();
                myTri.Fill(g, brusher, x, y, cx, cy);
            }
            if (index == 4)
            {
                myHex = new Hexagon();
                myHex.Fill(g, brusher, x, y, cx, cy);
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
            Graphics graphic = e.Graphics;

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

            activeControl = sender as Control;
            previousPosition = e.Location;
            Cursor = Cursors.Hand;
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
            index = 7;
            g.Clear(Color.White);
            pictureBox1.Image = bm;

        }

        public void button18_Click(object sender, EventArgs e)
        {
            index = 5;
            control = true;
        }
        public void button18_DoubleClick(object sender, EventArgs e)
        {
            index = 5;
            control = false;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            index = 6;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            var fileFullName = $"c:\\temp\\paint_{DateTime.Now.Ticks}.txt";
            var bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            var graphis = Graphics.FromImage(bitmap);
            var rectangle = pictureBox1.RectangleToScreen(pictureBox1.ClientRectangle);
            graphis.CopyFromScreen(rectangle.Location, Point.Empty, pictureBox1.Size);
            bitmap.Save(fileFullName);
            Process.Start(fileFullName);
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

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

    }
}
