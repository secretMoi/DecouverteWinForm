using System.Collections.Generic;
using System.Drawing;
using DecouverteWinForm.core;

namespace DecouverteWinForm
{
    public class Spirographe
    {
        private List<Couple> points;
        
        public Spirographe()
        {
            points = new List<Couple>();
        }

        public bool Add(Couple point)
        {
            if (!EstValide(point)) return false;

            points.Add(point);
            
            return true;
        }
        
        public bool Add(int x, int y)
        {
            Couple point = new Couple(x, y);

            return Add(point);
        }

        public bool EstValide(Couple point)
        {
            if (point.Y < -100 || point.Y > 100) return false;
            if (points.Count > 0 && point.X <= points[points.Count - 1].X) return false;

            return true;
        }

        public List<Couple> Liste()
        {
            return points;
        }

        public List<Couple> InverseY()
        {
            List<Couple> pointsInverse = new List<Couple>();
            foreach (Couple point in points)
            {
                point.Y = -point.Y;
                
                pointsInverse.Add(point);
            }

            return pointsInverse;
        }
    }
}