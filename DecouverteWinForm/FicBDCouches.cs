using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ISET2018_CouClasses;
using ISET2018_CouGestion;

namespace DecouverteWinForm
{
    public partial class FicBDCouches : Form
    {
	    private DataTable dataTablePersonne;
	    private BindingSource bindingSourcePersonne;
	    private string connexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\winmo\Downloads\BD_Perso\BD_Perso.mdf;Integrated Security=True;Connect Timeout=30";

        public FicBDCouches()
        {
            InitializeComponent();
        }

        private void BDCouches_Load(object sender, EventArgs e)
        {
            RemplirDataGridView();
            if(dataGridViewPersonne.Rows.Count > 0)
				Activer(true);
            else
                Activer(false);
        }

        private void Activer(bool principal)
        {
	        dataGridViewPersonne.Enabled = principal;
	        textBoxIdentifiant.Enabled = textBoxPrenom.Enabled = textBoxNom.Enabled = !principal;
	        dateTimePicker.Enabled = !principal;
	        buttonConfirmer.Enabled = buttonAnnuler.Enabled = !principal;
	        buttonEditer.Enabled = buttonAjouter.Enabled = buttonSupprimer.Enabled = principal;
        }

        private void RemplirDataGridView()
        {
            dataTablePersonne = new DataTable();
            dataTablePersonne.Columns.Add(new DataColumn("ID", Type.GetType("System.Int32")));
            dataTablePersonne.Columns.Add(new DataColumn("Afficher"));

            List<C_Personne> temp = new G_Personne(connexion).Lire("Nom"); // stock tous le senregistrements dans une liste

            // parcourt la liste et ajoute les données à la vue
            foreach (C_Personne personne in temp)
	            dataTablePersonne.Rows.Add(personne.ID, personne.PRE + " " + personne.NOM);

            // lie les données à la vue
            bindingSourcePersonne = new BindingSource {DataSource = dataTablePersonne};
            dataGridViewPersonne.DataSource = bindingSourcePersonne;
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
	        textBoxIdentifiant.Text = textBoxNom.Text = textBoxPrenom.Text = "";
            dateTimePicker.Value = DateTime.Today;
            Activer(false);
        }

        private void buttonEditer_Click(object sender, EventArgs e)
        {
	        if (dataGridViewPersonne.SelectedRows.Count > 0)
	        {
		        textBoxIdentifiant.Text = dataGridViewPersonne.SelectedRows[0].Cells["ID"].Value.ToString(); // récupère l'id de l'élément sélectionné
		        C_Personne temp = new G_Personne(connexion).Lire_ID(int.Parse(textBoxIdentifiant.Text)); // le charge de la bdd
                // rempli les champs
		        textBoxPrenom.Text = temp.PRE;
		        textBoxNom.Text = temp.NOM;
		        dateTimePicker.Value = temp.NAI ?? DateTime.Today; // vérifie que la date n'est pas nulle
                Activer(false);
	        }
	        else
		        MessageBox.Show(@"Sélectionner l'enregistrement à éditer");
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
	        if (dataGridViewPersonne.SelectedRows.Count > 0)
	        {
		        if (MessageBox.Show(@"Supprimer l'enregistrement ?", @"Confirmer",
			            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
		        {
			        int id = (int) dataGridViewPersonne.SelectedRows[0].Cells["ID"].Value; // supprime le premier élément sélectionné
			        new G_Personne(connexion).Supprimer(id); // supprimer de la bdd
                    bindingSourcePersonne.RemoveCurrent(); // supprime de la ram
		        }

	        }
	        else
		        MessageBox.Show(@"Sélectionner l'enregistrement à supprimer");
        }

        private void buttonConfirmer_Click(object sender, EventArgs e)
        {
	        if (textBoxNom.Text == "")
		        MessageBox.Show(@"Renseigner le nom de la personne");
	        else
	        {
		        if (textBoxIdentifiant.Text == "") // ajout
		        {
			        int id = new G_Personne(connexion).Ajouter(textBoxNom.Text, textBoxPrenom.Text, dateTimePicker.Value);
			        textBoxIdentifiant.Text = id.ToString();
			        dataTablePersonne.Rows.Add(id, textBoxPrenom.Text + " " + textBoxNom.Text);
		        }
		        else // modification
		        {
			        new G_Personne(connexion).Modifier(int.Parse(textBoxIdentifiant.Text), textBoxNom.Text, textBoxPrenom.Text, dateTimePicker.Value);
			        dataGridViewPersonne.SelectedRows[0].Cells["Afficher"].Value = textBoxIdentifiant.Text + " " + textBoxNom.Text;

                    bindingSourcePersonne.EndEdit();
		        }

                Activer(true);
	        }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {

        }
    }
}
