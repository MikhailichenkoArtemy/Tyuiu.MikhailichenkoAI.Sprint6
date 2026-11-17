using System;
using System.Windows.Forms;

namespace Tyuiu.MikhailichenkoAI.Sprint6.Task0.V23
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}
