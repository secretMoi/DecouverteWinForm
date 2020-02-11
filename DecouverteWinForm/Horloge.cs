using System;
using System.Diagnostics;
using System.Drawing;
using DecouverteWinForm.core;
using DecouverteWinForm.Core.Elements;

namespace DecouverteWinForm
{
    public class Horloge : Element
    {
        public Horloge(Couple position) : base(position)
        {
            AiguilleSeconde();
            AiguilleMinute();
            AiguilleHeure();

            GenerePoints();
        }

        public void AiguilleSeconde()
        {
            Dimensionne(position.Xi + 150, position.Yi);
            
            AjouterLigne("AiguilleSeconde", Color.Black, 3);
        }

        public void AiguilleMinute()
        {
            Dimensionne(position.Xi + 120, position.Yi);
            
            AjouterLigne("AiguilleMinute", Color.Blue, 3);
        }
        
        public void AiguilleHeure()
        {
            Dimensionne(position.Xi + 90, position.Yi);
            
            AjouterLigne("AiguilleHeure", Color.Red, 3);
        }

        public void GenerePoints()
        {
            Dimensionne(10, 10);
            
            int rayon = elements["AiguilleSeconde"].Position.Xi - elements["AiguilleSeconde"].Dimension.Xi;
            Couple centre = position.Copie();
            
            for (int i = 0; i < 12; i++)
            {
                position.X = (float) (centre.X + rayon * Math.Cos(2 * i * Math.PI / 12));
                position.Y = (float) (centre.Y + rayon * Math.Sin(2 * i * Math.PI / 12));

                AjouterDisque("Point" + i, Color.Indigo);
            }
        }

        public void Anime(int heure, int minute, int seconde)
        {
            int decalage = 15 * 6;
            elements["AiguilleSeconde"].Rotation.Angle = -seconde * 6 + decalage;
            elements["AiguilleMinute"].Rotation.Angle = -minute * 6 + decalage;
            elements["AiguilleHeure"].Rotation.Angle = -heure * 30 + decalage;
        }
    }
}