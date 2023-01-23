using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColonyOptimization
{
    public class PlanarGraph
    {
        public int n;
        public int w;
        public int h;

        public Point[] point;
        public float[,] dist;

        private int frame = 5;

        public PlanarGraph(int n, int w, int h)
        {
            this.n = n;

            this.w = w;
            this.h = h;

            makeRandPoint(n);
        }

        private void makeRandPoint(int n)
        {
            point = new Point[n];

            var rand = new Random();
            for (int i = 0; i < n; i++)
                point[i] = new Point(rand.Next(frame, w - frame),
                                     rand.Next(frame, h - frame));

            mathDist();
        }

        private void mathDist()
        {
            dist = new float[n, n];

            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                {
                    dist[i, j] = point[i].Dist(point[j]);
                    dist[j, i] = dist[i, j];
                }

            for (int i = 0; i < n; i++)
                dist[i, i] = 0;
        }
    }

    public class Colony : PlanarGraph
    {
        public float[,] pheromone;

        public float[] len;
        public int[,]  way;
        public int[]   shortWay;

        public float mostShort;
        public float findShort;
        public int   step;

        public Colony(int n, int w, int h) : base(n, w, h)
        {
            ReloadSearching();
        }

        public void ReloadSearching()
        {
            mostShort = 10000f;
            findShort = 10000f;

            shortWay = new int[n + 1];
            step = 0;

            reloadPh();
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
    }
}
