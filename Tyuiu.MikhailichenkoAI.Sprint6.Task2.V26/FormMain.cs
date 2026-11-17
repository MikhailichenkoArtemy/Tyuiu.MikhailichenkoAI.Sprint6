using System;
using System.Drawing;
using System.Windows.Forms;
using Tyuiu.MikhailichenkoAI.Sprint6.Task2.V26.Lib;

namespace Tyuiu.MikhailichenkoAI.Sprint6.Task2.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_MAI_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_MAI.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_MAI.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_MAI.Titles.Clear();
                this.chartFunction_MAI.Titles.Add("График функции sin(x) + cos(2x)/2 - 1,5x");

                this.chartFunction_MAI.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_MAI.ChartAreas[0].AxisY.Title = "Ось Y";

                this.dataGridViewFunction_MAI.Rows.Clear();
                this.chartFunction_MAI.Series[0].Points.Clear();

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_MAI.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_MAI.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chartFunction_MAI_Click(object sender, EventArgs e)
        {
        }

        private void buttonDone_MAI_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_MAI.BackColor = Color.Red;
        }

        private void buttonDone_MAI_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_MAI.BackColor = Color.Green;
        }

        private void buttonDone_MAI_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_MAI.BackColor = Color.Blue;
        }

        private void buttonHelp_MAI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПБ-26-1 Михайличенко Артемий Игоревич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
