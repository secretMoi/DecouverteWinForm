﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
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
            graphique = new Graphique(new Point(ClientSize.Width / 2, ClientSize.Height / 2), ClientSize);
            spirographe = new Spirographe();
            
            AjoutPoints();
        }

        private void AjoutPoints()
        {
            Random rand = new Random();
            int nombre = rand.Next(2, 20);

            int x = 0, y = 0;

            for (int i = 0; i < nombre; i++)
            {
                x = rand.Next(x + 1, x + 100);
                y = rand.Next(-100, 100);

                spirographe.Add(x, y);
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            
            graphique.Affiche(e.Graphics);
        }

        private void FicSpirographe2_Load(object sender, EventArgs e)
        {
            graphique.ListePoints(spirographe.InverseY());
        }
    }
}