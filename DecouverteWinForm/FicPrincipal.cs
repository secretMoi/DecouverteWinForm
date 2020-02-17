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

        //todo faire un système générique (réflexion ?)
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

        private void spirographeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FicSpirographe fenetre = new FicSpirographe();
            fenetre.ShowDialog(); // empêche de revenir à la fenêtre précédente
        }

        private void menuApplicationsHorloge_Click(object sender, EventArgs e)
        {
            FicHorloge fenetre = new FicHorloge();
            fenetre.ShowDialog(); // empêche de revenir à la fenêtre précédente
        }

        private void menuApplicationsSpinographe2_Click(object sender, EventArgs e)
        {
            FicSpirographe2 fenetre = new FicSpirographe2();
            fenetre.ShowDialog(); // empêche de revenir à la fenêtre précédente
        }

        private void menuControlesClavierSouris_Click(object sender, EventArgs e)
        {
            FicClavierSouris fenetre = new FicClavierSouris();
            fenetre.Show();
            
        }

        private void menuApplicationsNavigateur_Click(object sender, EventArgs e)
        {
            FicNavigateur fenetre = new FicNavigateur();
            fenetre.Show();
        }

        private void BoutonColore1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous avez cliqué");
        }
    }
}