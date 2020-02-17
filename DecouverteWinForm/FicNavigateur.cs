using System;
using System.IO;
using System.Windows.Forms;

namespace DecouverteWinForm
{
    public partial class FicNavigateur : Form
    {
        private TreeNode racine;
        private const int Poste = 0;
        private const int Ordi = 1;
        private const int Repertoire = 2;
        private const int RepertoireActif = 3;
        private const int Poubelle = 4;
        
        public FicNavigateur()
        {
            InitializeComponent();
        }
        
        private void FicNavigateur_Load(object sender, EventArgs e)
        {
            LireDisques();
        }

        private void LireDisques()
        {
            Cursor curseur = Cursor.Current; // sauvegarde le curseur
            Cursor = Cursors.WaitCursor; // mets le curseur d'attente (sablier)

            toolStripStatusLabelMessage.Text = @"Lecture de l'aborescence Répertoire";
            treeViewRepertoire.Nodes.Clear(); // remets à la racine
            
            racine = new TreeNode("Poste de travail", Poste, Poste);
            treeViewRepertoire.Nodes.Add(racine); // ajoute la racine à la hiérarchie
            
            string[] disques = Environment.GetLogicalDrives(); // récupère les disques de la machine

            foreach (string disque in disques)
            {
                // id1: image normale, id2: image lorsque sélectionné
                TreeNode treeNodeDisque = new TreeNode(disque, Ordi, Ordi); // ajout un noeud à chaque disque
                racine.Nodes.Add(treeNodeDisque); // ajout le nouveau node
                
                LireRepertoire(disque, treeNodeDisque.Nodes);
            }
            
            // remet tout par défaut
            listViewFichier.Items.Clear(); // reset la vue
            toolStripStatusLabelMessage.Text = @"";
            Cursor = curseur;
        }

        private void LireRepertoire(string nomDisque, TreeNodeCollection noeud)
        {
            if(!Directory.Exists(nomDisque)) return; // si le disque n'existe pas
            
            try
            {
                string[] repertoires = Directory.GetDirectories(nomDisque); // récupère la liste des répertoires
                string nom, nomMajuscule;

                foreach (string repertoire in repertoires)
                {
                    nom = NomFichier(repertoire); // récupère le nom
                    nomMajuscule = nom.ToUpper(); // mets en majuscule pour vérifié si c'est la poubelle

                    TreeNode treeNodeCourant;
                    if (nomMajuscule == "RECYCLED" || nomMajuscule == "RECYCLER") // si c'est la poubelle
                        treeNodeCourant = new TreeNode(nom, Poubelle, Poubelle);
                    else // sinon c'est un élément quelconque
                        treeNodeCourant = new TreeNode(nom, Repertoire, RepertoireActif);

                    noeud.Add(treeNodeCourant); // on ajoute le noeud à la hiérarchie
                    LireRepertoire(repertoire, treeNodeCourant.Nodes); // lit le répertoire
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void LireFichier(string repertoire)
        {
            Cursor cursor = Cursor.Current;
            Cursor = Cursors.WaitCursor;
            
            toolStripStatusLabelMessage.Text = "Lecture des fichiers dans " + repertoire;
            
            listViewFichier.Items.Clear(); // reset l'affichage

            try
            {
                string[] fichiers = Directory.GetFiles(repertoire); // liste des fichiers
                string[] colonnes = new string[4]; // liste des colonnes
                string temp;

                FileInfo infoFichier;
                long tailleFichier;

                foreach (string fichier in fichiers)
                {
                    temp = fichier.ToUpper();
                    if (temp != "PAGEFILE.SYS")
                    {
                        infoFichier = new FileInfo(fichier); // récupère les infos du fichier
                        tailleFichier = infoFichier.Length; // récupère la taille
                        
                        colonnes[0] = NomFichier(fichier);

                        // convertir la taille en format lisible
                        if (tailleFichier > Math.Pow(1024, 3))
                            colonnes[1] = tailleFichier / Math.Pow(1024, 3) + "GB";
                        if (tailleFichier > Math.Pow(1024, 2))
                            colonnes[1] = tailleFichier / Math.Pow(1024, 2) + "MB";
                        if (tailleFichier > 1024)
                            colonnes[1] = tailleFichier / 1024 + "KB";
                        else
                            colonnes[1] = tailleFichier + "B";
                        
                        colonnes[2] = infoFichier.CreationTime.ToString("dd/MM/yyyy");
                        colonnes[2] = infoFichier.LastWriteTime.ToString("dd/MM/yyyy");

                        listViewFichier.Items.Add(new ListViewItem(colonnes, Poste));
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Erreur lors de l'accès à " +
                    repertoire +
                    " (" +
                    e.Message +
                    ")"
                );
            }

            toolStripStatusLabelMessage.Text = "";
            Cursor = cursor;
        }

        private string NomFichier(string nomFichier)
        {
            return nomFichier.Substring(1 + nomFichier.LastIndexOf('\\'));
        }

        private void ToolStripButtonQuitter_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void ToolStripMenuItemPetiteIcone_Click(object sender, System.EventArgs e)
        {
            listViewFichier.View = View.SmallIcon;
        }

        private void ToolStripMenuItemGrandeIcone_Click(object sender, System.EventArgs e)
        {
            listViewFichier.View = View.LargeIcon;
        }

        private void ToolStripMenuItemListe_Click(object sender, System.EventArgs e)
        {
            listViewFichier.View = View.List;
        }

        private void ToolStripMenuItemDetail_Click(object sender, System.EventArgs e)
        {
            listViewFichier.View = View.Details;
        }

        private void treeViewRepertoire_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode treeNodeCourant = e.Node;

            if (treeNodeCourant == racine) // si on est à la racine
            {
                string[] temp =
                {
                    "Poste de travail", // nom
                    "", // taille
                    "", // date création
                    "" // date modification
                };

                listViewFichier.Items.Add(new ListViewItem(temp, Poste));
            }
            else
            {
                string repertoire = treeNodeCourant.FullPath; // récupère le chemin absolu

                repertoire = repertoire.Remove(0, 1 + repertoire.IndexOf('\\'));

                try
                {
                    listViewFichier.Items.Clear(); // vide l'affichage
                    
                    if (!Directory.Exists(repertoire))
                    {
                        string[] temp =
                        {
                            "Non opérationnel", // nom
                            "", // taille
                            "", // date création
                            "" // date modification
                        };
                        
                        listViewFichier.Items.Add(new ListViewItem(temp, Poste));
                    }
                    else
                        LireFichier(repertoire);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(
                        "Erreur lors de l'accès à " +
                        repertoire +
                        " (" +
                        exception.Message +
                        ")"
                    );

                    treeViewRepertoire.Focus(); // rends le focus
                }
            }
        }
    }
}