using System;
using System.Windows.Forms;

namespace Tyuiu.MikhailichenkoAI.Sprint6.Task2.V26
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
