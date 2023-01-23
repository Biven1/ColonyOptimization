using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ColonyOptimization
{
    public partial class DrawingForm : Form
    {
        private Colony colony;
        public DrawingForm(ref Colony colony)
        {
            InitializeComponent();
            this.colony = colony;

            Invalidate();
        }

        public void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Drawing.Draw(g, ref colony);
        }
    }

    static class Drawing
    {
        public static bool shortWayVisible   = false;
        public static bool numOfPointVisible = false;

        private static int rad = 12;

        private static Color colorLine     = Color.FromArgb(255, 221, 235, 203);
        private static Color colorShortWay = Color.FromArgb(255, 255, 1,   1);
        private static Color colorPoint    = Color.FromArgb(255, 54,  55,  148);
        public static void Draw(Graphics g, ref Colony colony)
        {
            DrawLine(g, colony);
            DrawShortWay(g, colony);
            DrawNumberOfPoint(g, colony);
        }

        public static void DrawShortWay(Graphics g, Colony colony)
        {
            if (shortWayVisible && colony.shortWay != null)
            {
                Pen pen = new Pen(colorShortWay, 2);

                for (int i = 0; i < colony.n; i++)
                    g.DrawLine(pen, colony.point[colony.shortWay[i]].x + rad,
                                    colony.point[colony.shortWay[i]].y + rad,
                                    colony.point[colony.shortWay[i + 1]].x + rad,
                                    colony.point[colony.shortWay[i + 1]].y + rad);
            }
        }

        private static void DrawNumberOfPoint(Graphics g, Colony colony)
        {
            Brush contour   = new SolidBrush(colorPoint);
            Brush fillBrush = new SolidBrush(Color.White);

            if (!numOfPointVisible)
            {
                for (int i = 0; i < colony.n; i++)
                    g.FillPie(new SolidBrush(Color.Black),
                              colony.point[i].x + rad - 4,
                              colony.point[i].y + rad - 4,
                              8, 8, 0F, 360F);
                return;
            }

            for (int i = 0; i < colony.n; i++)
            {
                g.FillPie(contour, colony.point[i].x, colony.point[i].y, rad * 2, rad * 2, 0F, 360F);
                g.FillPie(fillBrush, colony.point[i].x + 2, colony.point[i].y + 2, rad * 2 - 4, rad * 2 - 4, 0F, 360F);
            }

            for (int i = 0; i < colony.n; i++)
                g.DrawString(i.ToString(), new Font("Monaco", 12), new SolidBrush(Color.FromArgb(255, 1, 1, 1)),
                             colony.point[i].x + 5, colony.point[i].y + 3, new StringFormat());
        }

        private static void DrawLine(Graphics g, Colony colony)
        {
            //Pen pen;
            //Pen pen = new Pen(Color.FromArgb(255, 221, 235, 233), 2);

            for (int i = 0; i < colony.n - 1; i++)
                for (int j = i + 1; j < colony.n; j++)
                {
                    Pen pen = new Pen(colorLine, colony.pheromone[i, j] * 10);
                    g.DrawLine(pen, colony.point[i].x + rad, colony.point[i].y + rad,
                                    colony.point[j].x + rad, colony.point[j].y + rad);
                }
        }
    }
}
