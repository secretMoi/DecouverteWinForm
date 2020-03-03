using System;
using System.Windows.Forms;

namespace DecouverteWinForm
{
    public partial class FicGPS : Form
    {
        private const bool LONGITUDE = false;
        private const bool LATITUDE = true;
        
        public FicGPS()
        {
            InitializeComponent();
        }

        private void buttonConnecter_Click(object sender, EventArgs e)
        {
            if (comboBoxCOM.SelectedIndex >= 0)
            {
                try
                {
                    if (serialPortGPS.IsOpen)
                    {
                        timerChrono.Stop();
                        serialPortGPS.Close();
                    }

                    serialPortGPS.PortName = comboBoxCOM.Text;
                    serialPortGPS.Open();
                    timerChrono.Start();
                    buttonBoucler.Text = @"Arrêter la lecture";
                }
                catch (Exception exception)
                {
                    MessageBox.Show(@"Problème" + exception.Message);
                }
            }
            else
                MessageBox.Show(@"Sélectionner un port");
        }

        private void buttonBoucler_Click(object sender, EventArgs e)
        {
            timerChrono.Enabled = !timerChrono.Enabled;
            if (timerChrono.Enabled) buttonBoucler.Text = @"Arrêter la lecture";
            else buttonBoucler.Text = @"Débuter la lecture";
        }

        private void buttonAfficher_Click(object sender, EventArgs e)
        {
            if (textBoxLongitude.Text == "" || textBoxLatitude.Text == "")
                MessageBox.Show(@"Pas de données lues => pas de carte");
            else
            {
                FicCarte fenetre = new FicCarte();
                fenetre.ShowDialog();
            }
        }

        private void timerChrono_Tick(object sender, EventArgs e)
        {
            /*23519 = Acquisition du FIX à 12:35:19 UTC
            4807.038,N = Latitude 48 deg 07.038' N
            01131.324,E = Longitude 11 deg 31.324' E
            1 = Fix qualification : (0 = non valide, 1 = Fix GPS, 2 = Fix DGPS)
            08 = Nombre de satellites en poursuite.
            0.9 = DOP (Horizontal dilution of position) Dilution horizontale.
            545.4,M = Altitude, en Mètres, au dessus du MSL (mean see level) niveau moyen des Océans.
            46.9,M = Correction de la hauteur de la géoïde en Mètres par rapport à l'ellipsoïde WGS84 (MSL).
                (Champ vide) = nombre de secondes écoulées depuis la dernière mise à jour DGPS.
                (Champ vide) = Identification de la station DGPS.
            *42 = Checksum*/
            
            if(!serialPortGPS.IsOpen) return;

            string data = serialPortGPS.ReadExisting();
            string[] trames = data.Split('$');

            foreach (string trame in trames)
            {
                string[] contenus = trame.Split(',');
                if (contenus[0] == "GPGGA" && contenus.Length == 15)
                {
                    /*double latitude = double.Parse(contenus[2].Replace('.', ',')); // latitude = 4807,038
                    latitude /= 100; // latitude = 4,807038 (en degré)
                    textBoxLatitude.Text = contenus[3] + (int) latitude; // tbLatitude.Text = N48
                    latitude -= (int) latitude; // latitude = 0,0738
                    latitude *= 100 / 60; // latitude = 0,1173
                    textBoxLatitude.Text += latitude.ToString().Substring(1).Replace(',', '.'); // textBoxLatitude.Text = N48.1173
                    
                    double longitude = double.Parse(contenus[4].Replace('.', ',')); // latitude = 4807,038
                    longitude /= 100; // latitude = 4,807038 (en degré)
                    textBoxLatitude.Text = contenus[5] + (int) longitude; // tbLatitude.Text = N48
                    longitude -= (int) longitude; // latitude = 0,0738
                    longitude *= 100 / 60; // latitude = 0,1173
                    textBoxLatitude.Text += longitude.ToString().Substring(1).Replace(',', '.'); // textBoxLatitude.Text = N48.1173*/
                    
                    ConversionDegreMinute(contenus, textBoxLatitude, LATITUDE);
                    ConversionDegreMinute(contenus, textBoxLongitude, LONGITUDE);
                }
            }
        }

        private void ConversionDegreMinute(string[] contenus, TextBox textBox, bool typeCoord)
        {
            int position = 2;
            if (typeCoord == LONGITUDE)
                position += 2;
            
            double coordonnee = double.Parse(contenus[position].Replace('.', ',')); // latitude = 4807,038
            coordonnee /= 100; // latitude = 4,807038 (en degré)
            textBox.Text = contenus[position + 1] + (int) coordonnee; // tbLatitude.Text = N48
            coordonnee -= (int) coordonnee; // latitude = 0,0738
            coordonnee *= 100 / 60; // latitude = 0,1173
            textBox.Text += coordonnee.ToString().Substring(1).Replace(',', '.'); // textBoxLatitude.Text = N48.1173
        }
    }
}