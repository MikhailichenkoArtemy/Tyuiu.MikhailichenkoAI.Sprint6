using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.MikhailichenkoAI.Sprint6.Task5.V20.Lib;

namespace Tyuiu.MikhailichenkoAI.Sprint6.Task5.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "InPutFileTask5V20.txt");

        private void buttonDone_MAI_Click(object sender, EventArgs e)
        {
            dataGridViewNums_MAI.ColumnCount = 2;
            dataGridViewNums_MAI.Columns[0].Width = 20;
            dataGridViewNums_MAI.Columns[1].Width = 50;

            this.chartDiag_MAI.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_MAI.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_MAI.Series[0].Points.Clear();
            dataGridViewNums_MAI.Rows.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_MAI.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_MAI.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_MAI_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_MAI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПБ-26-1 Михайличенко Артемий Игоревич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
