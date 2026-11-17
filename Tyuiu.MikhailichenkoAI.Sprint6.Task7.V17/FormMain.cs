using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.MikhailichenkoAI.Sprint6.Task7.V17.Lib;

namespace Tyuiu.MikhailichenkoAI.Sprint6.Task7.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        public int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonOpenFile_MAI_Click(object sender, EventArgs e)
        {
            openFileDialogTask_MAI.ShowDialog();
            openFilePath = openFileDialogTask_MAI.FileName;

            if (openFilePath != "")
            {
                int[,] arrayValues = new int[rows, columns];
                arrayValues = LoadFromFileData(openFilePath);

                dataGridViewIn_MAI.ColumnCount = columns;
                dataGridViewIn_MAI.RowCount = rows;
                dataGridViewOut_MAI.ColumnCount = columns;
                dataGridViewOut_MAI.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewIn_MAI.Columns[i].Width = 35;
                    dataGridViewOut_MAI.Columns[i].Width = 35;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewIn_MAI.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }
                }

                arrayValues = ds.GetMatrix(openFilePath);
                buttonDone_MAI.Enabled = true;
            }
        }

        private void buttonDone_MAI_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_MAI.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSaveFile_MAI.Enabled = true;
        }

        private void buttonSaveFile_MAI_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_MAI.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_MAI.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_MAI.ShowDialog();

            string path = saveFileDialogMatrix_MAI.FileName;

            if (path != "")
            {
                FileInfo fileInfo = new FileInfo(path);
                bool fileExists = fileInfo.Exists;

                if (fileExists)
                {
                    File.Delete(path);
                }

                int rows = dataGridViewOut_MAI.RowCount;
                int columns = dataGridViewOut_MAI.ColumnCount;

                string str = "";

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (j != columns - 1)
                        {
                            str = str + dataGridViewOut_MAI.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str = str + dataGridViewOut_MAI.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine);
                    str = "";
                }
            }
        }

        private void buttonHelp_MAI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
