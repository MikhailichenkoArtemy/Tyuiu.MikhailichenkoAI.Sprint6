using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.MikhailichenkoAI.Sprint6.Task6.V17.Lib;

namespace Tyuiu.MikhailichenkoAI.Sprint6.Task6.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath = "";
        DataService ds = new DataService();

        private void buttonDone_MAI_Click(object sender, EventArgs e)
        {
            textBoxOut_MAI.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_MAI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_MAI_Click(object sender, EventArgs e)
        {
            openFileDialogTask_MAI.ShowDialog();
            openFilePath = openFileDialogTask_MAI.FileName;
            if (!string.IsNullOrEmpty(openFilePath) && File.Exists(openFilePath))
            {
                textBoxIn_MAI.Text = File.ReadAllText(openFilePath);
                groupBoxIn_MAI.Text = "Ввод: " + openFileDialogTask_MAI.FileName;
                buttonDone_MAI.Enabled = true;
            }
        }
    }
}
