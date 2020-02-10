using System;
using System.Windows.Forms;

namespace DecouverteWinForm
{
    public partial class FicPrincipal : Form
    {
        public FicPrincipal()
        {
            InitializeComponent();
        }

        private void NonImplemente(object sender, EventArgs e)
        {
            MessageBox.Show("Fonction non implémentée", "Non implémenté", MessageBoxButtons.OK);
        }

        private void menuAProposAPropos_Click(object sender, EventArgs e)
        {
            FicAPropos fenetre = new FicAPropos();
            fenetre.ShowDialog(); // empêche de revenir à la fenêtre précédente
        }
        
        private void menuControleProgression_Click(object sender, EventArgs e)
        {
            FicProgression fenetre = new FicProgression();
            fenetre.ShowDialog(); // empêche de revenir à la fenêtre précédente
        }
        
        private void menuControleListe_Click(object sender, EventArgs e)
        {
            FicListe fenetre = new FicListe();
            fenetre.ShowDialog(); // empêche de revenir à la fenêtre précédente
        }
        
        private void menuControleEditeur_Click(object sender, EventArgs e)
        {
            FicEditeur fenetre = new FicEditeur();
            fenetre.ShowDialog(); // empêche de revenir à la fenêtre précédente
        }
    }
}