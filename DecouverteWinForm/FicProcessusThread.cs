using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace DecouverteWinForm
{
    public partial class FicProcessusThread : Form
    {
        private Process processus;
        private DateTime dateDebut;
        private List<string> commun;
        private static object cadenas = new Object();
        private static bool finiA, finiB;
        private Random aleatoire = new Random();
        
        public FicProcessusThread()
        {
            InitializeComponent();
        }

        private void buttonProcessus1_Click(object sender, EventArgs e)
        {
            listBoxConsole.Items.Clear();
            
            listBoxConsole.Items.Add("Chargement du bloc-note");
            Process.Start("notepad");
            listBoxConsole.Items.Add("Bloc-note chargé");
        }

        private void buttonProcessus2_Click(object sender, EventArgs e)
        {
            // si il n'y a pas de processus ou qu'il a été fermé
            if (processus == null || processus.HasExited)
            {
                listBoxConsole.Items.Clear();
            
                listBoxConsole.Items.Add("Chargement du bloc-note");
                //processus = Process.Start("notepad"); // on stocke le nouveau processus lancé
                //processus.Exited += Process_Exited;
                processus = new Process();
                processus.StartInfo.FileName = "notepad";
                processus.Start();
                listBoxConsole.Items.Add("Bloc-note chargé");

                processus.WaitForExit();
                Process_Exited(sender, e);
            }
        }
        private void EcranProcessusThread_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(processus == null) return;

            if (!processus.HasExited)
            {
                processus.Kill(); // on tue le processus
                processus.WaitForExit(); // on attend que tout se ferme gentillement
            }
        }

        private void Process_Exited(object sender, EventArgs e)
        {
            listBoxConsole.Items.Add("Début : " + processus.StartTime);
            listBoxConsole.Items.Add("Fin : " + processus.ExitTime);
            listBoxConsole.Items.Add("Durée : " + (processus.ExitTime - processus.StartTime));
        }

        private void buttonProcessus3_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "BAC2Q2_ProgrammeSecondaire"; // lance l'autre programme
            process.StartInfo.UseShellExecute = false; // désactive la ligne de commande en gui
            process.StartInfo.RedirectStandardInput = true; // redirige les e/s
            process.StartInfo.RedirectStandardOutput = true;
            
            listBoxConsole.Items.Clear();

            try
            {
                listBoxConsole.Items.Add("Chargement du programme BAC2Q2_ProgrammeSecondaire");
                process.Start();
                listBoxConsole.Items.Add("Transfert des données");
                
                process.StandardInput.WriteLine("Largo");
                process.StandardInput.WriteLine("Winch");
                listBoxConsole.Items.Add("Récupération du traitement");
                listBoxConsole.Items.Add("  - " + process.StandardOutput.ReadToEnd());
            }
            catch
            {
                listBoxConsole.Items.Add("Problème d'exécution");
            }
        }

        private void buttonThread1_Click(object sender, EventArgs e)
        {
            listBoxConsole.Items.Clear();
            commun = new List<string>();
            
            Thread a = new Thread(A);
            Thread b = new Thread(B);
            
            a.Start();
            b.Start();

            a.Join();
            b.Join();

            while (finiA == false || finiB == false)
            {
            }

            foreach (string chaine in commun)
            {
                listBoxConsole.Items.Add(chaine);
            }

            listBoxConsole.Items.Add(commun.Count);
            listBoxConsole.Items.Add("FINI");
        }

        private void A()
        {
            for (int i = 0; i < 500; i++)
            {
                AjouterListe("A");
                Thread.Sleep(aleatoire.Next(10));
            }

            finiA = true;
        }

        private void B()
        {
            for (int i = 0; i < 500; i++)
            {
                AjouterListe("B");
                Thread.Sleep(aleatoire.Next(10));
            }

            finiB = true;
        }

        private void AjouterListe(string chaine)
        {
            lock (cadenas)
                commun.Add(chaine);
        }
    }
}