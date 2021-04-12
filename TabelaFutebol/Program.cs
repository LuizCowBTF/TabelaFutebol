using System;
using System.Windows.Forms;

namespace TabelaFutebol
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Manager.Initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            
        }
    }
}