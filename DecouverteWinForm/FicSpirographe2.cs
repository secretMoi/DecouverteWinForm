using System;
using System.Diagnostics;
using System.Windows.Forms;
using DecouverteWinForm.core;
using DecouverteWinForm.Core.Figures;

namespace DecouverteWinForm
{
    public partial class FicSpirographe2 : Form
    {
        private Graphique graphique;
        private Spirographe spirographe;
        public FicSpirographe2()
        {
            InitializeComponent();
            
            Figure.InitialiseConteneur(pictureBox);
            
            graphique = new Graphique(new Couple(ClientSize.Width / 2, ClientSize.Height / 2), Couple.ToCouple(ClientSize));
            spirographe = new Spirographe();
            
            AjoutPoints();
            
            graphique.ListePoints(spirographe.InverseY());
        }

        private void AjoutPoints()
        {
            /*spirographe.Add(0, 0);
            spirographe.Add(50, -50);
            spirographe.Add(60, -50);
            spirographe.Add(75, -75);
            spirographe.Add(100, 100);
            spirographe.Add(110, 100);*/
            
            Random rand = new Random();
            int nombre = rand.Next(2, 100);

            int x = 0, y = 0;

            for (int i = 0; i < nombre; i++)
            {
                x = rand.Next(x + 1, x + 1000);
                y = rand.Next(-100, 100);

                spirographe.Add(x, y);
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            graphique.Affiche(e.Graphics);
        }
    }
}