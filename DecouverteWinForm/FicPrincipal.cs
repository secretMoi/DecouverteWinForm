using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Bac2Q2UserControlGraphique.core;
using DecouverteWinForm.core;
using Couple = Bac2Q2UserControlGraphique.core.Couple;

namespace DecouverteWinForm
{
    public partial class FicPrincipal : Form
    {
        public FicPrincipal()
        {
            InitializeComponent();
            RafraichiListBoxPoints();
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

        // todo surligner le point sélectionné
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            decimal coordonneeX;
            decimal coordonneeY;
            
            if (decimal.TryParse(textBoxX.Text, out coordonneeX) && decimal.TryParse(textBoxY.Text, out coordonneeY))
            {
                Couple couple = new Couple((double) coordonneeX, (double) coordonneeY);
                
                userControl11.AjoutPoint(couple);
                
                RafraichiListBoxPoints();
            }
        }
        
        private void RafraichiListBoxPoints()
        {
            string[] colonnes = new string[3]; // contient les informations de chaque colonne
            int compteur = 0;
            
            listViewPoints.Items.Clear(); // vide le contenu
            
            // parcourt la liste de points
            foreach (Couple point in userControl11.Points.Liste())
            {
                colonnes[0] = "Point " + compteur; // colonne Nom
                colonnes[1] = point.X.ToString(CultureInfo.CurrentCulture); // colonne X
                colonnes[2] = point.Y.ToString(CultureInfo.CurrentCulture); // colonne Y
                
                listViewPoints.Items.Add(new ListViewItem(colonnes)); // Ajoute l'item
                
                compteur++;
            }
            
            userControl11.Rafraichir();
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            ListViewItem item; // récupère l'item sélectionné
            string[] chaine; // contient le nom du point ainsi que sa position
            int nombreSupprime = 0; // permet de faire une suppression de plusieurs points en même temps
            
            // parcours tous les items sélectionnés
            for (int i = 0; i < listViewPoints.SelectedItems.Count; i++)
            {
                item = listViewPoints.SelectedItems[i]; // récupère l'item sélectionné
                chaine = item.SubItems[0].Text.Split(' '); // récupère le n° du point (sa position)
                
                userControl11.Points.RemoveAt(Convert.ToInt32(chaine[1]) - nombreSupprime);
                nombreSupprime++;
            }
            
            RafraichiListBoxPoints();
        }

        // met en surbrillance les points sélectionnés
        private void listViewPoints_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListViewItem item; // récupère l'item sélectionné
            string[] chaine; // contient le nom du point ainsi que sa position
            List<int> liste = new List<int>();
            
            // parcours tous les items sélectionnés
            for (int i = 0; i < listViewPoints.SelectedItems.Count; i++)
            {
                item = listViewPoints.SelectedItems[i]; // récupère l'item sélectionné
                chaine = item.SubItems[0].Text.Split(' '); // récupère le n° du point (sa position)
                
                liste.Add(Convert.ToInt32(chaine[1]));
            }
            
            userControl11.Encadre(liste);
            
            userControl11.Invalidate();
        }
    }
}