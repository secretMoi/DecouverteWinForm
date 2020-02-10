﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DecouverteWinForm.core;

namespace DecouverteWinForm
{
    public partial class FicListe : Form
    {
        private string fichier;
        private const int ListBoxLire = 0x0199;
        private const int ListBoxEcrire = 0x019A;
        public FicListe()
        {
            InitializeComponent();
            Activer(true);
        }

        private void Activer(bool etat)
        {
            listBoxPersonnes.Enabled = etat;
            buttonAjouter.Enabled = buttonOuvrir.Enabled = buttonSauver.Enabled = buttonSupprimer.Enabled = etat;

            panelDetails.Enabled = !etat;
        }
        
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            Activer(false);
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void buttonConfirmer_Click(object sender, EventArgs e)
        {
            int n = listBoxPersonnes.Items.Add(
                textBoxNom.Text +
                " (" +
                comboBoxQualite.Text + 
                ")"
            );
            
            SendMessage(listBoxPersonnes.Handle, ListBoxEcrire, n, listBoxPersonnes.Items.Count);

            Activer(true);
        }

        private void listBoxPersonnes_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxPersonnes.SelectedIndex < 0)
            {
                MessageBox.Show(@"Pas d'élément sélectionné");
                return;
            }

            int nPos = SendMessage(listBoxPersonnes.Handle, ListBoxLire, listBoxPersonnes.SelectedIndex, 0);
            
            MessageBox.Show(
                listBoxPersonnes.Text +
                @" en position " +
                (1 + listBoxPersonnes.SelectedIndex) +
                @" (tri), " +
                nPos +
                @" (encodage)"
            );
        }

        private void buttonSauver_Click(object sender, EventArgs e)
        {
            FileGUI fileGui = new FileGUI(FileGUI.Write);
            fileGui.AddFilter("Fichiers texte", "txt");
            fileGui.AddFilter("Tous les fichiers", "*");
            
            if (fileGui.ShowDialog() == DialogResult.OK)
            {
                fichier = fileGui.FileName;
                
                using (StreamWriter streamWriter = new StreamWriter(fichier))
                {
                    for (int i = 0; i < listBoxPersonnes.Items.Count; i++)
                    {
                        int nPos = SendMessage(listBoxPersonnes.Handle, ListBoxLire, i, 0);
                        streamWriter.WriteLine(listBoxPersonnes.Items[i] + "#" + nPos);
                    }
                }

                listBoxPersonnes.Text = fichier.Substring(fichier.LastIndexOf("\\", StringComparison.Ordinal) + 1);
            }
        }

        private void buttonOuvrir_Click(object sender, EventArgs e)
        {
            string lecture;
            string[] lectureTemp;
            int n;
            
            FileGUI fileGui = new FileGUI();
            fileGui.AddFilter("Fichiers texte", "txt");
            fileGui.AddFilter("Tous les fichiers", "*");
            
            if (fileGui.ShowDialog() == DialogResult.OK)
            {
                listBoxPersonnes.Items.Clear();
                fichier = fileGui.FileName;

                using (StreamReader streamReader = new StreamReader(fichier))  
                {  
                    while ((lecture=streamReader.ReadLine()) != null)
                    {
                        lectureTemp = lecture.Split('#');
                        n = listBoxPersonnes.Items.Add(lectureTemp[0]);
                        SendMessage(listBoxPersonnes.Handle, ListBoxEcrire, n, int.Parse(lectureTemp[1]));
                    }
                }
                
                labelFichier.Text = fichier.Substring(fichier.LastIndexOf("\\", StringComparison.Ordinal) + 1);
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if(listBoxPersonnes.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Vous devez sélectionner un élément",
                    "Suppression",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                
                return;
            }
            
            DialogResult resulat = MessageBox.Show(
                "Voulez-vous supprimer " + listBoxPersonnes.SelectedItem + " ?",
                "Suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resulat == DialogResult.Yes)
            {
                int dataCourante;
                // contient le numéro d'encodage de la donnée à supprimer
                int dataASupprimer = SendMessage(listBoxPersonnes.Handle, ListBoxLire, listBoxPersonnes.SelectedIndex, 0);
                
                // liste tous les éléments
                for (int i = 0; i < listBoxPersonnes.Items.Count; i++)
                {
                    // récupère le numéro d'encodage de l'item courant
                    dataCourante = SendMessage(listBoxPersonnes.Handle, ListBoxLire, i, 0);;
                    
                    // si le n° d'encodage est > au n° qui va être supprimé, on va le décaler de 1
                    if (dataCourante > dataASupprimer)
                    {
                        dataCourante--; // décalage
                        // on enregistre le nouveau n° d'encodage
                        SendMessage(listBoxPersonnes.Handle, ListBoxEcrire, i, dataCourante);
                    }
                }

                listBoxPersonnes.Items.RemoveAt(listBoxPersonnes.SelectedIndex); // supprime enfin l'item à supprimer

                /*SendMessage(
                    PointeurSurListBox,
                    LireOuEcrire,
                    idTrie,
                    idEncodage
                );
                
                //Pour récupérer un id d'encodage, on a juste besoin de l'id trié
                int idEncodage = SendMessage(
                    PointeurSurListBox,
                    LireOuEcrire,
                    idTrie,
                    0 // 0 car on s'en fout vu qu'on le cherche
                );*/
            }
        }
    }
}