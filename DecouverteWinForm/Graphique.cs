using System.Collections.Generic;
using System.Drawing;
using DecouverteWinForm.Core.Elements;
using DecouverteWinForm.Core.Figures;

namespace DecouverteWinForm
{
    public class Graphique : Element
    {
        private Point offset;
        private int compteur;
        private readonly Dictionary<string, float> maximum;
        private Size dimensionsFenetre;
        private PointF ajustementZoom;

        public Graphique(Point position, Size dimensionsFenetre) : base(position)
        {
            this.dimensionsFenetre = dimensionsFenetre;
            compteur = 0;

            maximum = new Dictionary<string, float>();
            maximum.Add("gauche", 0);
            maximum.Add("haut", 0);
            maximum.Add("droite", 0);
            maximum.Add("bas", 0);
        }

        public void Abscisse()
        {
            Dimensionne(dimensionsFenetre.Width, 4);
            
            position.X = 0;
            position.Y = PositionneY(0, dimensions.Y / 2);
            
            AjouterRectangle("Abscisse", Color.Red);
        }

        public void ListePoints(List<PointF> points)
        {
            TrouveMaximum(points);
            Zoom();
            PlacePoints(points);
            Abscisse();
            Relier();
        }

        private void PlacePoints(List<PointF> points)
        {
            Dimensionne(6, 6); // définit la taille du point
            
            for (int i = 0; i < points.Count; i++)
            {
                position = CastPointToInt(points[i]);
                position = Positionne(position);

                AjouterDisque("Point" + compteur, Color.Blue);

                compteur++;
            }
        }

        private Point Positionne(Point point, Point decalage = default)
        {
            // étire + réajuste avec le décalage étiré
            point.X = PositionneX(point.X, decalage.X);
            point.Y = PositionneY(point.Y, decalage.Y);

            return point;
        }

        private int PositionneX(int x, int decalage = 0)
        {
            return (int) (position.X * ajustementZoom.X -
                          maximum["gauche"] * ajustementZoom.X +
                          decalage);
        }
        private int PositionneY(int y, int decalage = 0)
        {
            return (int) (y * ajustementZoom.Y +
                          (-maximum["bas"]) * ajustementZoom.Y +
                          decalage);
        }

        private void Relier()
        {
            List<Figure> liste = ListeElements();
            
            for (int i = 0; i < compteur - 1; i++)
            {
                dimensions = liste[i].Position;
                dimensions.X += 3;
                dimensions.Y += 3;
                position = liste[i + 1].Position;
                position.X += 3;
                position.Y += 3;
                
                AjouterLigne("Ligne" + i, Color.Blue, 3);
            }
        }

        private void TrouveMaximum(List<PointF> points)
        {
            maximum["gauche"] = points[0].X;
            maximum["droite"] = points[points.Count - 1].X;
            
            foreach (PointF point in points)
            {
                if (point.Y < maximum["bas"]) maximum["bas"] = point.Y;
                if (point.Y > maximum["haut"]) maximum["haut"] = point.Y;
            }
        }

        private void Zoom()
        {
            Size deltaMaximum = new Size();
            
            // différence des valeurs extrêmes
            deltaMaximum.Height = (int) (maximum["haut"] - maximum["bas"]);
            deltaMaximum.Width = (int) (maximum["droite"] - maximum["gauche"]);
            
            // tailleFenetre / delta => facteur de zoom
            ajustementZoom.Y = (float) dimensionsFenetre.Height / deltaMaximum.Height * 0.95f;
            ajustementZoom.X = (float) dimensionsFenetre.Width / deltaMaximum.Width * 0.95f;
        }
        
        private Point CastPointToInt(PointF pointFloat)
        {
            return new Point((int) pointFloat.X, (int) pointFloat.Y);
        }
    }
}