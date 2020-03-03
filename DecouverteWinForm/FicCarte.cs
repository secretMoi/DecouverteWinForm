using System.Windows.Forms;

namespace DecouverteWinForm
{
    public partial class FicCarte : Form
    {
        public FicCarte()
        {
            InitializeComponent();
        }

        public FicCarte(string longitude, string latitude) : this()
        {
            webBrowserCarte.Navigate("https://maps.google.com/maps?q=" + latitude + "%2C" + longitude);
        }
    }
}