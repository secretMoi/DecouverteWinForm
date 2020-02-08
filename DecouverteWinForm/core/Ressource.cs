using System.Drawing;
using System.IO;

namespace DecouverteWinForm.core
{
    public class Ressource
    {
        private const string Racine = "Resources/";

        public static Bitmap GetImage(string nom)
        {
            string chemin = Racine + nom;

            if (!File.Exists(chemin)) return null;
            
            return new Bitmap(chemin);
        }
    }
}