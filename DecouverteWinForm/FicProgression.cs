using System;
using System.Windows.Forms;

namespace DecouverteWinForm
{
    public partial class FicProgression : Form
    {
        public FicProgression()
        {
            InitializeComponent();
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonExecuter_Click(object sender, EventArgs e)
        {
            int pas, nombreFichiers;
            
            Random delai = new Random();

            nombreFichiers = 5 + delai.Next(11);
            
            buttonExecuter.Enabled = buttonQuitter.Enabled = false; // désactive les boutons durant l'opération
            
            // met un curseur sablier
            Cursor ancienCurseur = Cursor;
            Cursor = Cursors.WaitCursor;


            progressBarPrincipal.Maximum = nombreFichiers;
            progressBarPrincipal.Value = 0;
            for (int i = 0; i < nombreFichiers; i++)
            {
                progressBarSecondaire.Value = 0;
                pas = 5 + 9 * delai.Next(20);
                for (int j = 0; j < 20; j++)
                {
                    progressBarSecondaire.Value = (1 + j) * 5;
                    System.Threading.Thread.Sleep(pas);
                }

                progressBarPrincipal.Value++;
            }
            

            Cursor = ancienCurseur; // remet le curseur
            buttonExecuter.Enabled = buttonQuitter.Enabled = true; // réactive les boutons
        }
    }
}