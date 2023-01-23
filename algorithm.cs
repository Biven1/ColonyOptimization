using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ColonyOptimization
{
    static class Searching
    {
        public static readonly string Type = "AS";

        public static int NumOfIt = 5;

        public static float a = 1;
        public static float b = 3;
        public static float l = 1.8f;
        public static float Q = 80f;
        public static float p = 0.3f;

        public static float minPh = 0.1f;

        public static void OneStep(ref Colony colony)
        {
            colony.step += 1;

            Search(ref colony);
            FindShort(ref colony);
            ReloadPh(ref colony);
        }

        public static void Search(ref Colony colony)
        {
            colony.len = new float[NumOfIt];
            colony.way = new int[NumOfIt, colony.n + 1];

            for (int i = 0; i < NumOfIt; i++)
            {
                colony.len[i] = 0;
                for (int j = 0; j < colony.n + 1; j++)
                    colony.way[i, j] = 0;
            }

            for (int i = 0; i < NumOfIt; i++)
                Start(ref colony, i);

            for (int i = 0; i < NumOfIt; i++)
                colony.way[i, colony.n] = colony.way[i, 0];
        }

        public static void Start(ref Colony colony, int t)
        {
            bool[] visit = Enumerable.Repeat<bool>(true, colony.n).ToArray();

            var rand = new Random();
            var StartPoint = rand.Next(0, colony.n);

            nextIt(ref colony, StartPoint, StartPoint, visit, colony.n - 1, t);
        }

        private static void nextIt(ref Colony colony, int s, int StartPoint, bool[] visit, int deep, int t)
        {
            colony.way[t, colony.n - deep - 1] = s;

            if (deep == 0)
            {
                colony.len[t] += colony.dist[s, StartPoint];
                return;
            }

            visit[s] = false;
            var prod = new Dictionary<int, float>();

            for (int i = 0; i < colony.n; i++)
                if (visit[i])
                    prod.Add(i, wish(ref colony, s, i));

            float sum = 0;
            foreach (var it in prod)
                sum += it.Value;

            for (int i = 0; i < colony.n; i++)
                if (visit[i])
                    prod[i] /= sum;

            int next = chooseRand(prod);
            colony.len[t] += colony.dist[s, next];

            nextIt(ref colony, next, StartPoint, visit, deep - 1, t);
        }

        private static int chooseRand(Dictionary<int, float> prod)
        {
            Random rand = new Random();

            float r = (float)rand.NextDouble();
            float add = 0f;

            foreach (var item in prod)
            {
                add += item.Value;
                if (r < add) return item.Key;
            }

            MessageBox.Show("random ", "error");
            return -1;
        }

        private static float wish(ref Colony colony, int i, int j)
        {
            return (float)Math.Pow(colony.pheromone[i, j], a) * l / (float)Math.Pow(colony.dist[i, j], b);
        }

        private static void FindShort(ref Colony colony)
        {
            for (int i = 0; i < NumOfIt; i++)
                if (colony.len[i] < colony.findShort)
                {
                    colony.findShort = colony.len[i];
                    colony.shortWay = new int[colony.n + 1];

                    for (int j = 0; j < colony.n; j++)
                        colony.shortWay[j] = colony.way[i, j];
                    colony.shortWay[colony.n] = colony.shortWay[0];
                }
        }

        private static void ReloadPh(ref Colony colony)
        {
            for (int i = 0; i < colony.n; i++)
                for (int j = 0; j < colony.n; j++)
                    colony.pheromone[i, j] = Math.Max((1 - p) * colony.pheromone[i, j], minPh);

            for (int i = 0; i < NumOfIt; i++)
            {
                float t = Q / colony.len[i];
                for (int j = 0; j < colony.n; j++)
                {
                    colony.pheromone[colony.way[i, j], colony.way[i, j + 1]] += t;
                    colony.pheromone[colony.way[i, j + 1], colony.way[i, j]] += t;
                }
            }
        }
    }
}
