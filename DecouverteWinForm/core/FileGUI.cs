using System.Windows.Forms;

namespace DecouverteWinForm.core
{
    public class FileGUI
    {
        private FileDialog fileDialog;
        public const int Read = 0; 
        public const int Write = 1; 
        
        public FileGUI(int method = Read)
        {
            if(method == Read)
                fileDialog = new OpenFileDialog();
            else
                fileDialog = new SaveFileDialog();
        }

        public void AddFilter(string texte, string extension)
        {
            if (fileDialog.Filter.Length > 0)
                fileDialog.Filter += "|" + texte + "|*." + extension;
            else
                fileDialog.Filter = texte + "|*." + extension;
        }

        public DialogResult ShowDialog()
        {
            return Get.ShowDialog();
        }

        public string FileName => Get.FileName;

        public FileDialog Get => fileDialog;
    }
}