using System;
using System.Windows.Forms;

namespace Tyuiu.MikhailichenkoAI.Sprint6.Task5.V20
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
