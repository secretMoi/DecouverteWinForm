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

        public bool EstValide(PointF point)
        {
            if (point.Y < -100 || point.Y > 100) return false;
            if (points.Count > 0 && point.X <= points[points.Count - 1].X) return false;

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