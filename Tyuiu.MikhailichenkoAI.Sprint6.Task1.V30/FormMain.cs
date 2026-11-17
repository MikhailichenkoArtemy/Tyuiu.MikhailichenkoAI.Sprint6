using System;
using System.Windows.Forms;
using Tyuiu.MikhailichenkoAI.Sprint6.Task1.V30.Lib;

namespace Tyuiu.MikhailichenkoAI.Sprint6.Task1.V30
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

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_MAI.WordWrap = false;
                textBoxResult_MAI.Text = "";
                textBoxResult_MAI.AppendText("+-------+---------+" + Environment.NewLine);
                textBoxResult_MAI.AppendText("|   X   |   f(x)  |" + Environment.NewLine);
                textBoxResult_MAI.AppendText("+-------+---------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,4:d}   | {1, 6:f2}  |", startStep, valueArray[i]);
                    textBoxResult_MAI.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_MAI.AppendText("+-------+---------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_MAI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПБ-26-1 Михайличенко Артемий Игоревич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
