﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace DecouverteWinForm
{
    public partial class FicSpirographe : Form
    {
        private Color trait, fond;
        private GraphicsPath DessinSauve;
        
        private enum Couleur
        {
            Trait, Fond
        }
        
        public FicSpirographe()
        {
            InitializeComponent();
            
            fond = Color.DarkBlue;
            trait = Color.Cyan;
        }

        private double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(
                Math.Pow(x1 - x2, 2) +
                Math.Pow(y1 - y2, 2)
            );
        }
        
        private double Distance(PointF point1, PointF point2)
        {
            return Math.Sqrt(
                Math.Pow(point1.X - point2.X, 2) +
                Math.Pow(point1.Y - point2.Y, 2)
            );
        }

        private void EcranSpirographe_Paint(object sender, PaintEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void trackBarDensite_Scroll(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            int nombreSommets = trackBarSommets.Value;
            int nombreDensite = trackBarDensite.Value;
            int nombreProfondeur = trackBarProfondeur.Value;
            Graphics graphics = CreateGraphics();
            
            DessinSauve = new GraphicsPath();
            Rectangle rectangle = new Rectangle(new Point(248,0), ClientSize);
            graphics.FillRectangle(new SolidBrush(fond), rectangle);

            Point centre = new Point(
                248 + (ClientSize.Width - 248) / 2,
                ClientSize.Height / 2
            );
            int rayon = 9 * Math.Min(
                            ClientSize.Width - 248, ClientSize.Height
                        ) / 20;

            PointF[] sommets = new PointF[nombreSommets + 1];
            for (int i = 0; i < sommets.Length; i++)
            {
                sommets[i].X = (float) (centre.X + rayon * Math.Cos(i * 2 * Math.PI / nombreSommets));
                sommets[i].Y = (float) (centre.Y + rayon * Math.Sin(i * 2 * Math.PI / nombreSommets));
            }

            sommets[nombreSommets] = sommets[0];
            
            PointF X1, X2;
            while (Distance(sommets[0], centre) > rayon * nombreProfondeur / 100)
            {
                X1 = sommets[0];

                for (int i = 1; i <= nombreSommets; i++)
                {
                    X2 = sommets[i];
                    graphics.DrawLine(new Pen(trait), X1, X2);
                    DessinSauve.AddLine(X1, X2);

                    X1.X = X2.X;
                    X1.Y = X2.Y;
                    
                    Application.DoEvents();
                    Thread.Sleep(15);
                }

                for (int i = 0; i < nombreSommets; i++)
                {
                    sommets[i].X = sommets[i].X + (sommets[i + 1].X - sommets[i].X) / nombreDensite;
                    sommets[i].Y = sommets[i].Y + (sommets[i + 1].Y - sommets[i].Y) / nombreDensite;
                }
                sommets[nombreSommets] = sommets[0];
            }
        }

        private unsafe void ChangeCouleur(Couleur type = Couleur.Trait)
        {
            Color couleur = trait;

            if (type == Couleur.Fond) couleur = fond;
            if (type == Couleur.Trait) couleur = trait;
            
            colorDialog.Color = couleur;
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                couleur = colorDialog.Color;
                Invalidate(false);
                
                if (type == Couleur.Fond) fond = couleur;
                if (type == Couleur.Trait) trait = couleur;
            }
        }

        private Object Assigne(ref object objet)
        {
            return objet;
        }

        private void buttonTrait_Click(object sender, EventArgs e)
        {
            /*colorDialog.Color = trait;
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                trait = colorDialog.Color;
                Invalidate(false);
            }*/
            ChangeCouleur(Couleur.Trait);
        }

        private void buttonFond_Click(object sender, EventArgs e)
        {
            /*colorDialog.Color = fond;
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                fond = colorDialog.Color;
                Invalidate(false);
            }*/
            ChangeCouleur(Couleur.Fond);
        }

        private void FicSpirographe_Paint(object sender, PaintEventArgs e)
        {
            if (DessinSauve != null)
            {
                Rectangle rectangle = new Rectangle(new Point(248,0), ClientSize);
                e.Graphics.FillRectangle(new SolidBrush(fond), rectangle);
                e.Graphics.DrawPath(new Pen(trait), DessinSauve);
            }
        }
    }
}