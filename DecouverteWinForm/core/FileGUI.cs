using System.Windows.Forms;

namespace DecouverteWinForm.core
{
    public class FileGUI
    {
        private OpenFileDialog openFileDialog;
        
        public FileGUI()
        {
            openFileDialog = new OpenFileDialog();
        }

        public void AddFilter(string texte, string extension)
        {
            if (openFileDialog.Filter.Length > 0)
                openFileDialog.Filter += "|" + texte + "|*." + extension;
            else
                openFileDialog.Filter = texte + "|*." + extension;
        }

        public DialogResult ShowDialog()
        {
            return Get.ShowDialog();
        }

        public string FileName => Get.FileName;

        public OpenFileDialog Get => openFileDialog;
    }
}