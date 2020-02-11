using System;
using System.Drawing;

namespace DecouverteWinForm.core
{
    public class Couple
    {
        private PointF couple;
        private const float MargeErreur = Single.Epsilon;

        public Couple(Couple couple)
        {
            X = couple.X;
            Y = couple.Y;
        }
        public Couple(PointF point = default)
        {
            couple = point;
        }
        public Couple(Point point)
        {
            couple = point;
        }
        public Couple(float x, float y)
        {
            couple = new PointF(x, y);
        }
        public Couple(double x, double y)
        {
            couple = new PointF((float) x, (float) y);
        }
        public Couple(int x, int y)
        {
            couple = new PointF(x, y);
        }

        public static Couple Vide()
        {
            return new Couple(0, 0);
        }
        
        public static Couple operator +(Couple couple1, Couple couple2)
        {
            Couple coupleResultat = new Couple(
                couple1.X + couple2.X,
                couple1.Y + couple2.Y
            );
            
            return coupleResultat; 
        }
        
        public static Couple operator +(Couple couple, float nombre)
        {
            Couple coupleResultat = new Couple(
                couple.X + nombre,
                couple.Y + nombre
            );
            
            return coupleResultat; 
        }
        
        public static Couple operator -(Couple couple1, Couple couple2)
        {
            Couple coupleResultat = new Couple(
                couple1.X - couple2.X,
                couple1.Y - couple2.Y
            );
            
            return coupleResultat; 
        }
        
        public static Couple operator -(Couple couple, float nombre)
        {
            Couple coupleResultat = new Couple(
                couple.X - nombre,
                couple.Y - nombre
            );
            
            return coupleResultat; 
        }

        public static Couple ToCouple(Point point)
        {
            return new Couple(point);
        }
        public static Couple ToCouple(PointF point)
        {
            return new Couple(point);
        }

        public Point ToPoint()
        {
            return new Point((int) X, (int) Y);
        }

        public float X
        {
            get => couple.X;
            set => couple.X = value;
        }
        public float Y
        {
            get => couple.Y;
            set => couple.Y = value;
        }
        public int Xi
        {
            get => (int) couple.X;
            set => couple.X = value;
        }
        public int Yi
        {
            get => (int) couple.Y;
            set => couple.Y = value;
        }

        public override string ToString()
        {
            return "(" + X + "; " + Y + ")";
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (this == obj) return true;
            
            Couple objet = obj as Couple;
            return Egal(X, objet.X) && Egal(Y, objet.Y);
        }

        private bool Egal(float nombre1, float nombre2)
        {
            return Math.Abs(nombre1 - nombre2) < MargeErreur;
        }

        // utile lors d'effet de bord car quand on fait Couple1 = Couple2, les références sont copiées et non les valeurs
        public Couple Copie()
        {
            return new Couple(X, Y);
        }

        public void Reset()
        {
            couple = new PointF();
        }
    }
}