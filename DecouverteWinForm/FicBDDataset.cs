using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DecouverteWinForm
{
    public partial class FicBDDataset : Form
    {
        public FicBDDataset()
        {
            InitializeComponent();
        }

        private void FicBDDataset_Load(object sender, EventArgs e)
        {
            // cette ligne de code charge les données dans la table 'dataSetPerso.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.dataSetPerso.Client);

        }

        private void Activer(bool principal)
        {
            dataGridViewClient.Enabled = principal;
            textBoxIdentifiant.Enabled = textBoxPrenom.Enabled = textBoxNom.Enabled = !principal;
            dateTimePicker.Enabled = !principal;
            buttonPremier.Enabled = buttonPrecedent.Enabled = buttonSuivant.Enabled = buttonDernier.Enabled = principal;
            buttonConfirmer.Enabled = buttonAnnuler.Enabled = !principal;
            buttonEditer.Enabled = buttonAjouter.Enabled = buttonSupprimer.Enabled = principal;
        }

        private void Valider()
        {
            try
            {
                MessageBox.Show(clientTableAdapter.Update(dataSetPerso.Client)
                                + @" mise à jour effectuée");

                if (textBoxIdentifiant.Text == @"-1") // mode ajout enregistrement
                {
                    // connexion à la bdd
                    OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=perso.mdb");
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("SELECT MAX(NUMCLI) FROM client", connection); // crée la req
                    int tmp = (int) command.ExecuteScalar(); // exec la req
                    textBoxIdentifiant.Text = tmp.ToString();
                    connection.Close();
                }
            }
            catch
            {
                MessageBox.Show(@"Echec de la mise à jour");
            }
        }

        private void ButtonPremier_Click(object sender, EventArgs e)
        {
            clientBindingSource.MoveFirst();
        }

        private void ButtonPrecedent_Click(object sender, EventArgs e)
        {
            clientBindingSource.MovePrevious();
        }

        private void ButtonSuivant_Click(object sender, EventArgs e)
        {
            clientBindingSource.MoveNext();
        }

        private void ButtonDernier_Click(object sender, EventArgs e)
        {
            clientBindingSource.MoveLast();
        }

        private void ButtonConfirmer_Click(object sender, EventArgs e)
        {
            clientBindingSource.EndEdit(); // termine l' édition
            if (dataSetPerso.HasChanges()) // si il y a eu des modifications
                Valider();
            else
                MessageBox.Show(@"Pas de modification");

            Activer(true);

        }

        private void ButtonAnnuler_Click(object sender, EventArgs e)
        {
            clientBindingSource.CancelEdit(); // annule les modifications
            Activer(true);
        }

        private void ButtonEditer_Click(object sender, EventArgs e)
        {
            Activer(false);
        }

        private void ButtonAjouter_Click(object sender, EventArgs e)
        {
            clientBindingSource.AddNew(); // ajoute une ligne blanche (vide)
            Activer(false);
        }

        private void ButtonSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    @"Supprimer " +
                    textBoxPrenom.Text +
                    @" " +
                    textBoxNom.Text +
                    @" ?",
                    @"Supprimer",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                clientBindingSource.RemoveAt(clientBindingSource.Position);
                Valider();
            }
        }

        private void ClientBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            buttonPremier.Enabled = buttonPrecedent.Enabled = clientBindingSource.Position > 0;
            buttonSuivant.Enabled = buttonDernier.Enabled = clientBindingSource.Position < clientBindingSource.Count - 1;
            labelPosition.Text = 1 + clientBindingSource.Position + @"/" + clientBindingSource.Count;
        }
    }
}
