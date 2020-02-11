using System;
using System.Drawing;

namespace DecouverteWinForm.core
{
    public class Couple
    {
        private PointF couple;
        private const float margeErreur = Single.Epsilon;

        public Couple(PointF point)
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

        public override string ToString()
        {
            return "(" + X + "; " + Y + ")";
        }

        public override bool Equals(object obj)
        {
            Couple objet = obj as Couple;
            return Egal(X, objet.X) && Egal(Y, objet.Y);
        }

        private bool Egal(float nombre1, float nombre2)
        {
            return Math.Abs(nombre1 - nombre2) < margeErreur;
        }
    }
}