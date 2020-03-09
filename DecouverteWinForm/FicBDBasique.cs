using System.Data.OleDb;
using System.Windows.Forms;

namespace DecouverteWinForm
{
    public partial class FicBDBasique : Form
    {
        private string chaineConnexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=perso.mdb";
        public FicBDBasique()
        {
            InitializeComponent();
        }

        private void ButtonLecture_Click(object sender, System.EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(chaineConnexion); // initialise la connexion
            connection.Open(); // ouvre la connexion

            // initialise la requête et l'associe à la connexion
            OleDbCommand command = new OleDbCommand("SELECT PRE, NOM FROM client ORDER BY NOM", connection);
            OleDbDataReader dataReader = command.ExecuteReader(); // exécute la commande

            // parcourt les données
            while (dataReader.Read())
                listBoxConsole.Items.Add(dataReader[0] + " " + dataReader["NOM"]);

            dataReader.Close(); // termine la req
            connection.Close(); // ferme la connexion
        }

        private void ButtonCalcul_Click(object sender, System.EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(chaineConnexion); // initialise la connexion
            connection.Open(); // ouvre la connexion

            // initialise la requête et l'associe à la connexion
            OleDbCommand command = new OleDbCommand("SELECT COUNT(NOM) FROM client", connection);
            int nombre = (int) command.ExecuteScalar();

            listBoxConsole.Items.Add("Il y a " + nombre + " enregistrements");

            connection.Close(); // ferme la connexion
        }

        private void ButtonInserer_Click(object sender, System.EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(chaineConnexion); // initialise la connexion
            connection.Open(); // ouvre la connexion

            // initialise la requête et l'associe à la connexion
            OleDbCommand command = new OleDbCommand(
                "INSERT INTO client(NOM, PRE) VALUES('" + 
                textBoxNom.Text + "','" +
                textBoxPrenom.Text + "')"
                , connection);
            int nombre = command.ExecuteNonQuery();

            if (nombre == 1)
                listBoxConsole.Items.Add("Insertion effectuée");
            else
                listBoxConsole.Items.Add("Insertion ratée");

            connection.Close(); // ferme la connexion
        }
    }
}