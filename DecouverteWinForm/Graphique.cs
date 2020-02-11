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
            
            /*for (int i = 0; i < points.Count; i++)
            {
                Dimensionne(6, 6); // définit la taille du point
                
                position.X = points[i].X + offset.X - dimensions.X / 2;
                position.Y = points[i].Y + offset.Y - dimensions.X / 2;
                /*position.X = (int) (points[i].X * 1) - maximum["gauche"];
                position.Y = (int) (points[i].Y * 1) - maximum["bas"];*
                position = points[i];
                
                AjouterDisque("Point" + compteur, Color.Blue);

                /*if (i < points.Count - 1) // si il y a un poitn suivant
                    Relier(points[i], points[i + 1]);*
                
                compteur++;
            }*/
        }

        private void Centre(List<PointF> points)
        {
            PointF centreFenetre = new PointF(dimensionsFenetre.Width / 2, dimensionsFenetre.Height / 2);
            
            for (int i = 0; i < points.Count; i++)
            {
                Dimensionne(6, 6); // définit la taille du point

                /*position.X = points[i].X + centreFenetre.X - deltaMaximum.Width / 2;
                position.Y = points[i].Y + centreFenetre.Y;*/

                position = CastPointToInt(points[i]);
                //position = points[i];
                //position.Y =  points[i].Y * (int)ajustementZoom.Y + centreFenetre.Y + 70;
                position.X = (int) (position.X * ajustementZoom.X +
                                    maximum["gauche"] * ajustementZoom.X +
                                    dimensions.X
                    );
                position.Y = (int) (position.Y * ajustementZoom.Y +
                                    (-maximum["bas"]) * ajustementZoom.Y +
                                    dimensions.X);

                AjouterDisque("Point" + compteur, Color.Blue);

                compteur++;
            }
            
            Relier();
        }

        private void AjusteY()
        {
            
        }

        private void Relier(/*Point pointSource, Point pointDestination*/)
        {
            List<Figure> liste = ListeElements();
            
            for (int i = 0; i < compteur; i++)
            {
                if (i < compteur - 1) // si il y a un point suivant
                {
                    dimensions = liste[i].Position;
                    position = liste[i+1].Position;
                    
                    AjouterLigne("Ligne" + i, Color.Blue, 3);
                }
            }
            /*dimensions = pointSource;
            //dimensions = Offset(dimensions);
            
            position = pointDestination;
            //position = Offset(position);

            AjouterLigne("Ligne" + compteur, Color.Blue, 3);*/
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