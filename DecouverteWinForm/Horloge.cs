using System;
using System.Drawing;
using DecouverteWinForm.Core.Elements;

namespace DecouverteWinForm
{
    public class Horloge : Element
    {
        public Horloge(Point position) : base(position)
        {
            AiguilleSeconde();
            AiguilleMinute();
            AiguilleHeure();

            GenerePoints();
        }

        public void AiguilleSeconde()
        {
            Dimensionne(position.X + 150, position.Y);
            
            AjouterLigne("AiguilleSeconde", Color.Black, 3);
        }

        public void AiguilleMinute()
        {
            Dimensionne(position.X + 120, position.Y);
            
            AjouterLigne("AiguilleMinute", Color.Blue, 3);
        }
        
        public void AiguilleHeure()
        {
            Dimensionne(position.X + 90, position.Y);
            
            AjouterLigne("AiguilleHeure", Color.Red, 3);
        }

        public void GenerePoints()
        {
            Dimensionne(10, 10);
            
            int rayon = elements["AiguilleSeconde"].Position.X - elements["AiguilleSeconde"].Dimension.X;
            Point centre = position;
            
            for (int i = 0; i < 12; i++)
            {
                position.X = (int) (centre.X + rayon * Math.Cos(2 * i * Math.PI / 12));
                position.Y = (int) (centre.Y + rayon * Math.Sin(2 * i * Math.PI / 12));
                
                AjouterDisque("Point"+i, Color.Indigo);
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