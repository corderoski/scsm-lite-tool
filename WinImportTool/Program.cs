using System;
using System.Windows.Forms;
using WinSCSMLiteTool.Forms;

namespace WinSCSMLiteTool
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
            Application.Run(new MainForm());
        }

        internal static void AppendAction(String text)
        {
            System.IO.File.AppendAllText("", text);
            
        }

    }
}
