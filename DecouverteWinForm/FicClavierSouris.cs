﻿using System;
using System.Windows.Forms;

namespace DecouverteWinForm
{
    public partial class FicClavierSouris : Form
    {
        private int nombreGauche, nombreDroit;
        
        public FicClavierSouris()
        {
            InitializeComponent();
        }

        private void FicClavierSouris_Load(object sender, EventArgs e)
        {
            buttonReset_Click(null, null);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            listBoxClavier.Items.Clear();
            nombreGauche = nombreDroit = 0;
            RemplirSouris();
        }

        private void RemplirSouris()
        {
            textBoxGauche.Text = nombreGauche.ToString();
            textBoxDroit.Text = nombreDroit.ToString();
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelZoneSouris_MouseMove(object sender, MouseEventArgs e)
        {
            textBoxX.Text = e.X.ToString();
            textBoxY.Text = e.Y.ToString();
        }

        private void panelZoneSouris_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    nombreGauche++;
                    break;
                case MouseButtons.Right:
                    nombreDroit++;
                    break;
            }
            
            RemplirSouris();
        }

        private void FicClavierSouris_KeyDown(object sender, KeyEventArgs e)
        {
            listBoxClavier.Items.Insert(0, "KeyDown : Code : " + e.KeyCode + ", Valeur : " + e.KeyValue);
        }

        private void FicClavierSouris_KeyUp(object sender, KeyEventArgs e)
        {
            listBoxClavier.Items.Insert(0, "KeyUp : Code : " + e.KeyCode + ", Valeur : " + e.KeyValue);
        }

        private void FicClavierSouris_KeyPress(object sender, KeyPressEventArgs e)
        {
            listBoxClavier.Items.Insert(0, "KeyPress : Caractère : " + e.KeyChar);
        }
    }
}