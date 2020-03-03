using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DecouverteWinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            if(!IsRunning())
                Application.Run(new FicPrincipal());
        }

        private static bool IsRunning()
        {
            Process processActuel = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes)
                if(processActuel.Id != process.Id)
                    if (process.ProcessName == processActuel.ProcessName)
                        return true;

            return false;
        }
    }
}