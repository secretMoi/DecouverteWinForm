using System.Collections.Generic;
using System.Drawing;
using DecouverteWinForm.Core.Elements;

namespace DecouverteWinForm
{
    public class Graphique : Element
    {
        private Point offset;
        private static int compteur;
        private Dictionary<string, int> maximum;
        private Size dimensionsFenetre;
        private Size ajustementZoom;
        
        public Graphique(Point position, Size dimensionsFenetre) : base(position)
        {
            this.dimensionsFenetre = dimensionsFenetre;
            
            Abscisse();
            
            maximum = new Dictionary<string, int>();
            maximum.Add("gauche", 0);
            maximum.Add("haut", 0);
            maximum.Add("droite", 0);
            maximum.Add("bas", 0);
        }

        public void Abscisse()
        {
            Dimensionne(1000, 4);
            
            position.X = 0;
            offset = position;
            position.Y -= dimensions.Y / 2;
            
            AjouterRectangle("Abscisse", Color.Red);
        }

        public void ListePoints(List<Point> points)
        {
            TrouveMaximum(points);
            Zoom();
            
            for (int i = 0; i < points.Count; i++)
            {
                Dimensionne(6, 6); // définit la taille du point
                position.X = points[i].X + offset.X - dimensions.X / 2;
                position.Y = points[i].Y + offset.Y - dimensions.X / 2;
                
                AjouterDisque("Point" + compteur, Color.Blue);

                if (i < points.Count - 1) // si il y a un poitn suivant
                    Relier(points[i], points[i + 1]);
                
                compteur++;
            }
        }

        private void Relier(Point pointSource, Point pointDestination)
        {
            dimensions = pointSource;
            dimensions = Offset(dimensions);
            
            position = pointDestination;
            position = Offset(position);

            AjouterLigne("Ligne" + compteur, Color.Blue, 3);
        }

        private Point Offset(Point point)
        {
            point.X += offset.X;
            point.Y += offset.Y;

            return point;
        }

        private void TrouveMaximum(List<Point> points)
        {
            maximum["gauche"] = points[0].X;
            maximum["droite"] = points[points.Count - 1].X;
            
            foreach (Point point in points)
            {
                if (point.Y < maximum["bas"]) maximum["bas"] = point.Y;
                if (point.Y > maximum["haut"]) maximum["haut"] = point.Y;
            }
        }

        private void Zoom()
        {
            int deltaHauteur = maximum["haut"] - maximum["bas"];
            int deltaLargeur = maximum["droite"] - maximum["gauche"];
            
            ajustementZoom.Height = dimensionsFenetre.Height / deltaHauteur;
            ajustementZoom.Width = dimensionsFenetre.Width / deltaLargeur;
        }
    }
}