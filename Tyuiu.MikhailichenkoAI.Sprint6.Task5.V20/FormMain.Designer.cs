namespace Tyuiu.MikhailichenkoAI.Sprint6.Task5.V20
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_MAI = new System.Windows.Forms.GroupBox();
            this.textBoxTask_MAI = new System.Windows.Forms.TextBox();
            this.buttonDone_MAI = new System.Windows.Forms.Button();
            this.buttonOpenFile_MAI = new System.Windows.Forms.Button();
            this.buttonHelp_MAI = new System.Windows.Forms.Button();
            this.groupBoxOutput_MAI = new System.Windows.Forms.GroupBox();
            this.dataGridViewNums_MAI = new System.Windows.Forms.DataGridView();
            this.chartDiag_MAI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_MAI.SuspendLayout();
            this.groupBoxOutput_MAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_MAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_MAI)).BeginInit();
            this.SuspendLayout();

            this.groupBoxTask_MAI.Controls.Add(this.textBoxTask_MAI);
            this.groupBoxTask_MAI.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_MAI.Name = "groupBoxTask_MAI";
            this.groupBoxTask_MAI.Size = new System.Drawing.Size(425, 80);
            this.groupBoxTask_MAI.TabIndex = 0;
            this.groupBoxTask_MAI.TabStop = false;
            this.groupBoxTask_MAI.Text = "Условие:";

            this.textBoxTask_MAI.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_MAI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_MAI.Location = new System.Drawing.Point(10, 20);
            this.textBoxTask_MAI.Multiline = true;
            this.textBoxTask_MAI.Name = "textBoxTask_MAI";
            this.textBoxTask_MAI.ReadOnly = true;
            this.textBoxTask_MAI.Size = new System.Drawing.Size(405, 52);
            this.textBoxTask_MAI.TabIndex = 0;
            this.textBoxTask_MAI.TabStop = false;
            this.textBoxTask_MAI.Text = "Прочитать данные из файла InPutFileTask5V20.txt. Вывести в dataGridView все числа, кратные 2. Построить диаграмму по этим значениям. Округлить до трёх знаков после запятой.";

            this.buttonDone_MAI.BackColor = System.Drawing.Color.Green;
            this.buttonDone_MAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_MAI.Location = new System.Drawing.Point(450, 22);
            this.buttonDone_MAI.Name = "buttonDone_MAI";
            this.buttonDone_MAI.Size = new System.Drawing.Size(75, 62);
            this.buttonDone_MAI.TabIndex = 1;
            this.buttonDone_MAI.Text = "Выполнить";
            this.buttonDone_MAI.UseVisualStyleBackColor = false;
            this.buttonDone_MAI.Click += new System.EventHandler(this.buttonDone_MAI_Click);

            this.buttonOpenFile_MAI.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOpenFile_MAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_MAI.Location = new System.Drawing.Point(535, 22);
            this.buttonOpenFile_MAI.Name = "buttonOpenFile_MAI";
            this.buttonOpenFile_MAI.Size = new System.Drawing.Size(75, 62);
            this.buttonOpenFile_MAI.TabIndex = 2;
            this.buttonOpenFile_MAI.Text = "Открыть файл";
            this.buttonOpenFile_MAI.UseVisualStyleBackColor = false;
            this.buttonOpenFile_MAI.Click += new System.EventHandler(this.buttonOpenFile_MAI_Click);

            this.buttonHelp_MAI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_MAI.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHelp_MAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_MAI.Location = new System.Drawing.Point(620, 22);
            this.buttonHelp_MAI.Name = "buttonHelp_MAI";
            this.buttonHelp_MAI.Size = new System.Drawing.Size(75, 62);
            this.buttonHelp_MAI.TabIndex = 3;
            this.buttonHelp_MAI.Text = "Справка";
            this.buttonHelp_MAI.UseVisualStyleBackColor = false;
            this.buttonHelp_MAI.Click += new System.EventHandler(this.buttonHelp_MAI_Click);

            this.groupBoxOutput_MAI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxOutput_MAI.Controls.Add(this.dataGridViewNums_MAI);
            this.groupBoxOutput_MAI.Location = new System.Drawing.Point(12, 98);
            this.groupBoxOutput_MAI.Name = "groupBoxOutput_MAI";
            this.groupBoxOutput_MAI.Size = new System.Drawing.Size(150, 355);
            this.groupBoxOutput_MAI.TabIndex = 4;
            this.groupBoxOutput_MAI.TabStop = false;
            this.groupBoxOutput_MAI.Text = "Вывод данных:";

            this.dataGridViewNums_MAI.AllowUserToAddRows = false;
            this.dataGridViewNums_MAI.AllowUserToDeleteRows = false;
            this.dataGridViewNums_MAI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNums_MAI.ColumnHeadersVisible = false;
            this.dataGridViewNums_MAI.Location = new System.Drawing.Point(10, 22);
            this.dataGridViewNums_MAI.Name = "dataGridViewNums_MAI";
            this.dataGridViewNums_MAI.ReadOnly = true;
            this.dataGridViewNums_MAI.RowHeadersVisible = false;
            this.dataGridViewNums_MAI.Size = new System.Drawing.Size(130, 323);
            this.dataGridViewNums_MAI.TabIndex = 0;

            this.chartDiag_MAI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartDiag_MAI.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartDiag_MAI.Legends.Add(legend1);
            this.chartDiag_MAI.Location = new System.Drawing.Point(170, 98);
            this.chartDiag_MAI.Name = "chartDiag_MAI";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series1.Color = System.Drawing.Color.Green;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDiag_MAI.Series.Add(series1);
            this.chartDiag_MAI.Size = new System.Drawing.Size(525, 355);
            this.chartDiag_MAI.TabIndex = 5;
            this.chartDiag_MAI.Text = "chartDiag_MAI";

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 465);
            this.Controls.Add(this.chartDiag_MAI);
            this.Controls.Add(this.groupBoxOutput_MAI);
            this.Controls.Add(this.buttonHelp_MAI);
            this.Controls.Add(this.buttonOpenFile_MAI);
            this.Controls.Add(this.buttonDone_MAI);
            this.Controls.Add(this.groupBoxTask_MAI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.MinimumSize = new System.Drawing.Size(715, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 20 | Михайличенко А. И.";
            this.groupBoxTask_MAI.ResumeLayout(false);
            this.groupBoxTask_MAI.PerformLayout();
            this.groupBoxOutput_MAI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_MAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_MAI)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBoxTask_MAI;
        private System.Windows.Forms.TextBox textBoxTask_MAI;
        private System.Windows.Forms.Button buttonDone_MAI;
        private System.Windows.Forms.Button buttonOpenFile_MAI;
        private System.Windows.Forms.Button buttonHelp_MAI;
        private System.Windows.Forms.GroupBox groupBoxOutput_MAI;
        private System.Windows.Forms.DataGridView dataGridViewNums_MAI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_MAI;
    }
}
