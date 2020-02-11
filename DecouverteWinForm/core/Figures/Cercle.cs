﻿using System.Drawing;
using DecouverteWinForm.core;

namespace DecouverteWinForm.Core.Figures
{
    public class Cercle : Figure
    {
        public Cercle(Couple position, int rayon, Color contour, int largeurContour) :
            base(position, new Couple(rayon, rayon), null, contour, largeurContour)
        {
        }

        public override void Genere()
        {
            int rayon = dimension.Xi;

            Graphique.DrawEllipse(Contour,
                position.X, position.Y,
                rayon, rayon); // dessine le cercle dans l'image
        }
    }
}