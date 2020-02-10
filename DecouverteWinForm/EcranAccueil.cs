using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DecouverteWinForm.core;

namespace DecouverteWinForm
{
    public partial class Form1 : Form
    {
        private int compteur;
        private List<Image> liste;
        public Form1()
        {
            InitializeComponent();
            
            liste = new List<Image>();
            
            //todo ajouter volcan aux ressources ou faire sa propre classe
            //liste.Add(Resources.fond);
            //liste.Add(Resources.volcan);
            liste.Add(Ressource.GetImage("fond.jpg"));
            liste.Add(Ressource.GetImage("volcan.png"));
        }

        private void buttonPousser_Click(object sender, EventArgs e)
        {
            compteur++;
            pictureBoxDemarrage.Image = liste[compteur % 2];
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (MessageBox.Show(this,
                    "Souhaitez-vous quitter ?",
                    "Votre souhait",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                ) == DialogResult.Yes)
                e.Cancel = false; // annule la sortie
            else
                e.Cancel = true;*/
        }

        private void buttonEntrer_Click(object sender, EventArgs e)
        {
            /*FicPrincipal fenetre = new FicPrincipal();
            //fenetre.ShowDialog(); // empêche de revenir à la fenêtre précédente
            fenetre.Show(); // laisse revenir à la fenêtre précédente*/
            Close();
        }
    }
}