using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ColonyOptimization
{
    public class Colony
    {
        public int w;
        public int h;

        public int n;
        public Point[]  point;
        public float[,] dist;
        public float[,] pheromone;

        public float mostShort = 10000f; 
        public float findShort = 10000f;
        public int[] shortWay;
        public int step = 0;

        private int frame = 5;

        public Colony(int n = 5, int w = 100, int h = 100)
        {
            this.w = w;
            this.h = h;

            this.n = n;

            makeRandPoint(n);
            MathAll();
        }

        public void ReloadSearching()
        {
            mostShort = 10000f;
            findShort = 10000f;

            shortWay = new int[n + 1];
            step = 0;

            reloadPh();
        }

        private void makeRandPoint(int n) 
        {
            point = new Point[n];

            var rand = new Random();
            for (int i = 0; i < n; i++)
                point[i] = new Point(rand.Next(frame, w - frame),
                                     rand.Next(frame, h - frame));

            reloadPh();
            mathDist();
        }
        private void reloadPh()
        {
            pheromone = new float[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    pheromone[i, j] = 0.4f;

            for (int i = 0; i < n; i++)
                pheromone[i, i] = 0;
        }

        private void mathDist()
        { 
            dist = new float[n, n];
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                {
                    dist[i, j] = point[i].Dist( point[j] );
                    dist[j, i] = dist[i, j];
                }
            for (int i = 0; i < n; i++)
                dist[i, i] = 0;
        }

        private void MathAll()
        {
            // reload
        }

        #region Draw

        public bool shortWayVisible = false;
        public bool numOfPointVisible = true;

        private int r = 12;

        public Color colorLine = Color.FromArgb(255, 221, 235, 203);
        public Color colorShortWay = Color.FromArgb(255, 255, 1, 1);
        public void Draw(Graphics g)
        {
            //Pen pen = new Pen(Brushes.DeepSkyBlue, 5);

            DrawLine(g);
            DrawShortWay(g);
            DrawNumberOfPoint(g);
        }
        
        public void DrawShortWay(Graphics g)
        {
            if (shortWayVisible && shortWay != null)
            {
                Pen pen = new Pen(colorShortWay, 2);

                for (int i = 0; i < n; i++)
                    g.DrawLine(pen, point[shortWay[i]].x + r, point[shortWay[i]].y + r,
                                    point[shortWay[i + 1]].x + r, point[shortWay[i + 1]].y + r);
            }
        }
        
        private void DrawNumberOfPoint(Graphics g)
        {
            Font drawFont = new Font("Monaco", 12);
            SolidBrush drawBrush = new SolidBrush(Color.FromArgb(255, 1, 1, 1));
            StringFormat drawFormat = new StringFormat();

            Brush contour = new SolidBrush(Color.FromArgb(255, 54, 55, 148));
            Brush brush2 = new SolidBrush(Color.White);

            if (!numOfPointVisible)
            {
                brush2 = new SolidBrush(Color.Black);
                for (int i = 0; i < n; i++)
                    g.FillPie(brush2, point[i].x + r - 4, point[i].y + r - 4, 8, 8, 0F, 360F);

                return;
            }

            for (int i = 0; i < n; i++)
            {
                g.FillPie(contour, point[i].x, point[i].y, r * 2, r * 2, 0F, 360F);
                g.FillPie(brush2, point[i].x + 2, point[i].y + 2, r * 2 - 4, r * 2 - 4, 0F, 360F);
            }

            for (int i = 0; i < n; i++)
                g.DrawString(i.ToString(), drawFont, drawBrush, point[i].x + 5, point[i].y + 3, drawFormat);
        }
        
        private void DrawLine(Graphics g)
        {
            Pen pen;
            //Pen pen = new Pen(Color.FromArgb(255, 221, 235, 233), 2);

            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                {
                    pen = new Pen(colorLine, pheromone[i, j] * 10);
                    g.DrawLine(pen, point[i].x + r, point[i].y + r, point[j].x + r, point[j].y + r);
                }
        }

        #endregion

        public int NumOfIt = 5;

        public float a = 1;
        public float b = 2;
        public float l = 1;
        public float Q = 30f;
        public float p = 0.1f;

        public float[] len;
        public int[,] way;

        private int StartPoint;

        public void OneStep()
        {
            step += 1;

            Search();
            FindShort();
            ReloadPh();
        }

        public void Search()
        {
            len = new float[NumOfIt];
            way = new int[NumOfIt, n + 1];
            for (int i = 0; i < NumOfIt; i++)
            {
                len[i] = 0;
                for (int j = 0; j < n + 1; j++)
                    way[i, j] = 0;
            }

            var rand = new Random();
            for (int i = 0; i < NumOfIt; i++)
            {
                StartPoint = rand.Next(0, n);
                Start(StartPoint, i);
            }

            for (int i = 0; i < NumOfIt; i++)
                way[i, n] = way[i, 0];
        }
        public void Start(int s, int t)
        {
            bool[] visit = new bool[n];
            for (int i = 0; i < n; i++)
                visit[i] = true;

            nextIt(s, visit, n - 1, t);
        }

        private void nextIt(int s, bool[] visit, int deep, int t)
        {
            way[t, n - deep - 1] = s;
            if (deep == 0) {
                len[t] += dist[s, StartPoint];
                /*string arr = "";
                for (int i = 0; i < n; i++)
                    arr += way[t, i].ToString() + " ";
                MessageBox.Show(arr + "  " + len[t].ToString(), "deep");*/
                return; 
            }

            visit[s] = false;
            var prod = new Dictionary<int, float>();

            for (int i = 0; i < n; i++)
                if (visit[i])
                    prod.Add(i, wish(s, i));

            float sum = 0;
            foreach (var it in prod)
                sum += it.Value;

            for (int i = 0; i < n; i++)
                if (visit[i])
                    prod[i] /= sum;
            /*
            string ls = "";
            float sumL = 0;
            foreach (var it in prod)
            {
                ls += it.Value.ToString() + " ";
                sumL += it.Value;
            }
            MessageBox.Show(ls + "   " + sumL.ToString(), "massage");*/
            //Random random = new Random();
            //MessageBox.Show(random.NextDouble().ToString(), "massage");

            int next = chooseRand(prod);
            len[t] += dist[s, next];
            
            nextIt(next, visit, deep - 1, t);
        }

        private int chooseRand(Dictionary<int, float> prod)
        {
            Random random = new Random();
            float r = (float)random.NextDouble();
            float add = 0;

            foreach (var item in prod)
            {
                add += item.Value;
                if (r < add) return item.Key;
            }
            MessageBox.Show("random ", "error");
            return -1;
        }

        private float wish(int i, int j) 
        {
            return (float)Math.Pow(pheromone[i, j], a) * l / (float)Math.Pow(dist[i, j], b);
        }

        private void FindShort()
        {
            for (int i = 0; i < NumOfIt; i++)
                if (len[i] < findShort)
                {
                    findShort = len[i];
                    shortWay = new int[n + 1];

                    for (int j = 0; j < n; j++)
                        shortWay[j] = way[i, j];
                    shortWay[n] = shortWay[0];
                }
        }
        private void ReloadPh()
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    pheromone[i, j] *= 1 - p;

            for (int i = 0; i < NumOfIt; i++)
            {
                float t = Q / len[i];
                for (int j = 0; j < n; j++) {
                    pheromone[way[i, j], way[i, j + 1]] += t;
                    pheromone[way[i, j + 1], way[i, j]] += t;
                }
            }
        }
    }
}
