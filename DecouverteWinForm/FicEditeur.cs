using System;
using System.Drawing;
using System.Windows.Forms;
using DecouverteWinForm.core;

namespace DecouverteWinForm
{
    public partial class FicEditeur : Form
    {
        private readonly FileGUI enregistrer;
        private readonly FileGUI ouvrir;

        private bool modifie;
        private string fichier;
        
        private enum Caractere
        {
            Gras, Italique, Souligne, Barre
        }
        
        public FicEditeur()
        {
            InitializeComponent();
            
            enregistrer = new FileGUI(saveFileDialog);
            enregistrer.AddFilter("Mes fichiers", "me&sdocs");
            enregistrer.AddFilter("Tout les fichiers", "*");
            
            ouvrir = new FileGUI(openFileDialog);
            ouvrir.AddFilter("Mes fichiers", "mesdocs");
            ouvrir.AddFilter("Tout les fichiers", "*");
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
                        @"Enregistrer la mise à jour ?",
                        @"Texte modifié",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    ) == DialogResult.Yes)
                    FichierEnregistrer();
            }
        }

        private void menuFichierNouveau_Click(object sender, EventArgs e)
        {
            VerifierSauver();
            
            // reset tout
            fichier = null;
            modifie = false;
            richTextBoxTexte.Clear();
        }

        private void menuFichierEnregistrer_Click(object sender, EventArgs e)
        {
            FichierEnregistrer();
        }

        private void menuFichierOuvrir_Click(object sender, EventArgs e)
        {
            VerifierSauver();

            if (ouvrir.ShowDialog() == DialogResult.OK)
            {
                fichier = ouvrir.FileName;
                richTextBoxTexte.LoadFile(fichier);
            }

            modifie = false;
        }

        private void menuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void richTextBoxTexte_TextChanged(object sender, EventArgs e)
        {
            modifie = true;
        }

        private void menuEditerCopier_Click(object sender, EventArgs e)
        {
            richTextBoxTexte.Copy();
        }

        private void menuEditerCouper_Click(object sender, EventArgs e)
        {
            richTextBoxTexte.Cut();
        }

        private void menuEditerColler_Click(object sender, EventArgs e)
        {
            richTextBoxTexte.Paste();
        }

        private void menuFormaterJustifierGauche_Click(object sender, EventArgs e)
        {
            richTextBoxTexte.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void menuFormaterJustifierDroite_Click(object sender, EventArgs e)
        {
            richTextBoxTexte.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void menuFormaterJustifierCentre_Click(object sender, EventArgs e)
        {
            richTextBoxTexte.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void ChangePolice(Caractere type)
        {
            FontStyle nouveauStyle = richTextBoxTexte.SelectionFont.Style;
            
            switch(type)
            {
                case Caractere.Gras:
                    if (richTextBoxTexte.SelectionFont.Bold)
                        nouveauStyle ^= FontStyle.Bold;
                    else
                        nouveauStyle |= FontStyle.Bold; 
                    break;
                
                case Caractere.Italique:
                    if (richTextBoxTexte.SelectionFont.Italic)
                        nouveauStyle ^= FontStyle.Italic;
                    else
                        nouveauStyle |= FontStyle.Italic; 
                    break;
                
                case Caractere.Barre:
                    if (richTextBoxTexte.SelectionFont.Strikeout)
                        nouveauStyle ^= FontStyle.Strikeout;
                    else
                        nouveauStyle |= FontStyle.Strikeout; 
                    break;
                
                case Caractere.Souligne:
                    if (richTextBoxTexte.SelectionFont.Underline)
                        nouveauStyle ^= FontStyle.Underline;
                    else
                        nouveauStyle |= FontStyle.Underline; 
                    break;
            }
            
            richTextBoxTexte.SelectionFont = new Font(richTextBoxTexte.SelectionFont, nouveauStyle);
        }

        private void menuFormaterCaractereGras_Click(object sender, EventArgs e)
        {
            ChangePolice(Caractere.Gras);
        }
        
        private void menuFormaterPoliceItalique_Click(object sender, EventArgs e)
        {
            ChangePolice(Caractere.Italique);
        }

        private void menuFormaterCaractereSouligne_Click(object sender, EventArgs e)
        {
            ChangePolice(Caractere.Souligne);
        }

        private void menuFormaterCaractereBarre_Click(object sender, EventArgs e)
        {
            ChangePolice(Caractere.Barre);
        }

        private void menuFormaterPolice_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
                richTextBoxTexte.SelectionFont = new Font(fontDialog.Font, fontDialog.Font.Style);
        }

        private void FicEditeur_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerifierSauver();
        }
    }
}