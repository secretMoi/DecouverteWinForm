using System.Drawing;
using DecouverteWinForm.core;

namespace DecouverteWinForm.Core.Figures
{
    public class Disque : Figure
    {
        public Disque(Couple position, int rayon, Color couleurRemplissage, Color? contour = null, int largeurContour = 0) :
            base(position, new Couple(rayon, rayon), couleurRemplissage, contour, largeurContour)
        {
        }

        public override void Genere()
        {
            int rayon = dimension.Xi;
            
            Graphique.FillEllipse(Remplissage, position.X, position.Y, 
                dimension.X, dimension.Y);
            
            Graphique.DrawEllipse(Contour,
                position.X, position.Y,
                rayon, rayon); // dessine le disque dans l'image
        }
    }
}