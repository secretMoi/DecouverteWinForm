using System;
using System.Windows.Forms;
using DecouverteWinForm.core;

namespace DecouverteWinForm
{
    public partial class FicEditeur : Form
    {
        private FileGUI enregistrer;
        private FileGUI ouvrir;

        private bool modifie;
        private string fichier;
        
        public FicEditeur()
        {
            InitializeComponent();
            
            enregistrer = new FileGUI(saveFileDialog);
            enregistrer.AddFilter("Mes fichiers", "mesdocs");
            enregistrer.AddFilter("Tout les fichiers", "*");
            
            ouvrir = new FileGUI(openFileDialog);
            ouvrir.AddFilter("Mes fichiers", "mesdocs");
            ouvrir.AddFilter("Tout les fichiers", "*");
        }
        
        private void EcranEditeur_Load(object sender, EventArgs e)
        {
            
        }

        private void menuFormaterPoliceItalique_Click(object sender, EventArgs e)
        {
            
        }

        private void FichierEnregistrer()
        {
            if (fichier == null)
            {
                if (enregistrer.ShowDialog() == DialogResult.OK)
                    fichier = enregistrer.FileName;
            }
            else
            {
                richTextBoxTexte.SaveFile(fichier);
                modifie = false;
            }
        }

        private void VerifierSauver()
        {
            if (modifie)
            {
                if (
                    MessageBox.Show(
                        "Enregistrer la mise à jour ?",
                        "Texte modifié",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    ) == DialogResult.Yes)
                    FichierEnregistrer();
            }
        }
    }
}