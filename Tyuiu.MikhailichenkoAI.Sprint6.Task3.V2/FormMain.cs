using System;
using System.Windows.Forms;
using Tyuiu.MikhailichenkoAI.Sprint6.Task3.V2.Lib;

namespace Tyuiu.MikhailichenkoAI.Sprint6.Task3.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] {
            { -12, -4, -20, 5, -5 },
            { 2, 15, 1, -20, 7 },
            { 15, -15, 2, 11, 5 },
            { -19, -9, 16, 0, 1 },
            { 17, 16, 5, 12, -8 }
        };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_MAI.ColumnCount = columns;
            dataGridViewMatrix_MAI.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_MAI.Columns[i].Width = 35;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_MAI.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonDone_MAI_Click(object sender, EventArgs e)
        {
            int[,] resMtrx = (int[,])mtrx.Clone();
            resMtrx = ds.Calculate(resMtrx);

            int rows = resMtrx.GetUpperBound(0) + 1;
            int columns = resMtrx.Length / rows;

            dataGridViewResult_MAI.ColumnCount = columns;
            dataGridViewResult_MAI.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_MAI.Columns[i].Width = 35;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_MAI.Rows[i].Cells[j].Value = Convert.ToString(resMtrx[i, j]);
                }
            }
        }

        private void buttonHelp_MAI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПБ-26-1 Михайличенко Артемий Игоревич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
