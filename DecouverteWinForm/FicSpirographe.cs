using System;
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
        int nombreSommets;
        int nombreDensite;
        int nombreProfondeur;
        
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
        
        private double Distance(PointF point1, PointF point2)
        {
            return Math.Sqrt(
                Math.Pow(point1.X - point2.X, 2) +
                Math.Pow(point1.Y - point2.Y, 2)
            );
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            nombreSommets = trackBarSommets.Value;
            nombreDensite = trackBarDensite.Value;
            nombreProfondeur = trackBarProfondeur.Value;
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

        private void ChangeCouleur(Couleur type = Couleur.Trait)
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

        private void buttonTrait_Click(object sender, EventArgs e)
        {
            ChangeCouleur(Couleur.Trait);
        }

        private void buttonFond_Click(object sender, EventArgs e)
        {
            ChangeCouleur(Couleur.Fond);
        }

        private void FicSpirographe_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            if (DessinSauve != null)
            {
                Rectangle rectangle = new Rectangle(new Point(248,0), ClientSize);
                e.Graphics.FillRectangle(new SolidBrush(fond), rectangle);
                e.Graphics.DrawPath(new Pen(trait), DessinSauve);
            }
        }
    }
}