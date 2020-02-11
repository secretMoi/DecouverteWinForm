using System.Collections.Generic;
using System.Drawing;

namespace DecouverteWinForm
{
    public class Spirographe
    {
        private List<PointF> points;
        
        public Spirographe()
        {
            points = new List<PointF>();
        }

        public bool Add(PointF point)
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

        public static bool EstValide(PointF point)
        {
            if (point.Y < -100 || point.Y > 100) return false;

            return true;
        }

        public List<PointF> Liste()
        {
            return points;
        }

        public List<PointF> InverseY()
        {
            List<PointF> pointsInverse = new List<PointF>();
            for (int i = 0; i < points.Count; i++)
            {
                PointF point = points[i];
                point.Y = -point.Y;
                
                pointsInverse.Add(point);
            }

            return pointsInverse;
        }
    }
}