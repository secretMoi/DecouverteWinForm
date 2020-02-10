using System;
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
    }
}