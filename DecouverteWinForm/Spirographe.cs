using System.Collections.Generic;
using System.Drawing;

namespace DecouverteWinForm
{
    public class Spirographe
    {
        private List<Point> points;
        
        public Spirographe()
        {
            points = new List<Point>();
        }

        public bool Add(Point point)
        {
            if (!EstValide(point)) return false;

            points.Add(point);
            
            return true;
        }
        
        public bool Add(int x, int y)
        {
            Point point = new Point(x, y);

            return Add(point);
        }

        public static bool EstValide(Point point)
        {
            if (point.Y < -100 || point.Y > 100) return false;

            return true;
        }

        public List<Point> Liste()
        {
            return points;
        }

        public List<Point> InverseY()
        {
            List<Point> pointsInverse = new List<Point>();
            for (int i = 0; i < points.Count; i++)
            {
                Point point = points[i];
                point.Y = -point.Y;
                
                pointsInverse.Add(point);
            }

            return pointsInverse;
        }
    }
}