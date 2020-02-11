using System.Collections.Generic;
using System.Drawing;
using DecouverteWinForm.Core.Elements;
using DecouverteWinForm.Core.Figures;

//todo class Axis
namespace DecouverteWinForm
{
    public class Graphique : Element
    {
        private Point offset;
        private static int compteur;
        private Dictionary<string, float> maximum;
        private Size dimensionsFenetre;
        private PointF ajustementZoom;
        private Size deltaMaximum;
        
        public Graphique(Point position, Size dimensionsFenetre) : base(position)
        {
            this.dimensionsFenetre = dimensionsFenetre;
            compteur = 0;
            
            //Abscisse();
            
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
            //offset = position;
            position.Y -= dimensions.Y / 2;
            
            AjouterRectangle("Abscisse", Color.Red);
        }

        public void ListePoints(List<PointF> points)
        {
            TrouveMaximum(points);
            Zoom();
            Centre(points);
        }

        private void Centre(List<PointF> points)
        {
            Dimensionne(6, 6); // définit la taille du point
            
            for (int i = 0; i < points.Count; i++)
            {
                position = CastPointToInt(points[i]);

                position.X = (int) (position.X * ajustementZoom.X -
                                    maximum["gauche"] * ajustementZoom.X +
                                    dimensions.X);
                // étire + réajuste avec le décalage étiré
                position.Y = (int) (position.Y * ajustementZoom.Y +
                                    (-maximum["bas"]) * ajustementZoom.Y +
                                    dimensions.X);

                AjouterDisque("Point" + compteur, Color.Blue);

                compteur++;
            }
            
            Relier();
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

        private PointF Offset(PointF point)
        {
            point.X += offset.X;
            point.Y += offset.Y;

            return point;
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
            deltaMaximum.Height = (int) (maximum["haut"] - maximum["bas"]);
            deltaMaximum.Width = (int) (maximum["droite"] - maximum["gauche"]);
            
            ajustementZoom.Y = (float) dimensionsFenetre.Height / deltaMaximum.Height * 0.95f;
            ajustementZoom.X = (float) dimensionsFenetre.Width / deltaMaximum.Width * 0.95f;
        }
        
        private Point CastPointToInt(PointF pointFloat)
        {
            return new Point((int) pointFloat.X, (int) pointFloat.Y);
        }
    }
}