using System;

namespace ColonyOptimization
{
    public class Point
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public float Dist(Point point)
        {
            int dX = x - point.x;
            int dY = y - point.y;

            return (float)Math.Sqrt(dX * dX + dY * dY);
        }
    }
}
