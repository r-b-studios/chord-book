using System;
using System.IO;
using System.Windows.Forms;

namespace ChordBook
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Window(args.Length == 0 ? "" : (File.Exists(args[0]) ? args[0] : "")));
        }
    }
}