namespace Tyuiu.MikhailichenkoAI.Sprint6.Task2.V26
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
            this.groupBoxInput_MAI = new System.Windows.Forms.GroupBox();
            this.textBoxStopStep_MAI = new System.Windows.Forms.TextBox();
            this.labelStopStep_MAI = new System.Windows.Forms.Label();
            this.textBoxStartStep_MAI = new System.Windows.Forms.TextBox();
            this.labelStartStep_MAI = new System.Windows.Forms.Label();
            this.buttonHelp_MAI = new System.Windows.Forms.Button();
            this.buttonDone_MAI = new System.Windows.Forms.Button();
            this.groupBoxOutput_MAI = new System.Windows.Forms.GroupBox();
            this.chartFunction_MAI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_MAI = new System.Windows.Forms.DataGridView();
            this.columnX_MAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFX_MAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelResult_MAI = new System.Windows.Forms.Label();
            this.groupBoxTask_MAI.SuspendLayout();
            this.groupBoxInput_MAI.SuspendLayout();
            this.groupBoxOutput_MAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_MAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_MAI)).BeginInit();
            this.SuspendLayout();

            this.groupBoxTask_MAI.Controls.Add(this.textBoxTask_MAI);
            this.groupBoxTask_MAI.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_MAI.Name = "groupBoxTask_MAI";
            this.groupBoxTask_MAI.Size = new System.Drawing.Size(365, 180);
            this.groupBoxTask_MAI.TabIndex = 0;
            this.groupBoxTask_MAI.TabStop = false;
            this.groupBoxTask_MAI.Text = "Условие";

            this.textBoxTask_MAI.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_MAI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_MAI.Location = new System.Drawing.Point(15, 25);
            this.textBoxTask_MAI.Multiline = true;
            this.textBoxTask_MAI.Name = "textBoxTask_MAI";
            this.textBoxTask_MAI.ReadOnly = true;
            this.textBoxTask_MAI.Size = new System.Drawing.Size(335, 140);
            this.textBoxTask_MAI.TabIndex = 0;
            this.textBoxTask_MAI.TabStop = false;
            this.textBoxTask_MAI.Text = "Протабулировать функцию F(x) = sin(x) + cos(2x)/2 - 1,5x на заданном диапазоне [-5; 5] с шагом 1. Результат вывести в DataGridView и построить график функции.";

            this.groupBoxInput_MAI.Controls.Add(this.textBoxStopStep_MAI);
            this.groupBoxInput_MAI.Controls.Add(this.labelStopStep_MAI);
            this.groupBoxInput_MAI.Controls.Add(this.textBoxStartStep_MAI);
            this.groupBoxInput_MAI.Controls.Add(this.labelStartStep_MAI);
            this.groupBoxInput_MAI.Location = new System.Drawing.Point(12, 200);
            this.groupBoxInput_MAI.Name = "groupBoxInput_MAI";
            this.groupBoxInput_MAI.Size = new System.Drawing.Size(205, 80);
            this.groupBoxInput_MAI.TabIndex = 1;
            this.groupBoxInput_MAI.TabStop = false;
            this.groupBoxInput_MAI.Text = "Ввод данных";

            this.labelStartStep_MAI.AutoSize = true;
            this.labelStartStep_MAI.Location = new System.Drawing.Point(12, 25);
            this.labelStartStep_MAI.Name = "labelStartStep_MAI";
            this.labelStartStep_MAI.Size = new System.Drawing.Size(70, 15);
            this.labelStartStep_MAI.TabIndex = 0;
            this.labelStartStep_MAI.Text = "Старт шага:";

            this.textBoxStartStep_MAI.Location = new System.Drawing.Point(15, 45);
            this.textBoxStartStep_MAI.Name = "textBoxStartStep_MAI";
            this.textBoxStartStep_MAI.Size = new System.Drawing.Size(80, 23);
            this.textBoxStartStep_MAI.TabIndex = 1;
            this.textBoxStartStep_MAI.Text = "-5";

            this.labelStopStep_MAI.AutoSize = true;
            this.labelStopStep_MAI.Location = new System.Drawing.Point(108, 25);
            this.labelStopStep_MAI.Name = "labelStopStep_MAI";
            this.labelStopStep_MAI.Size = new System.Drawing.Size(74, 15);
            this.labelStopStep_MAI.TabIndex = 2;
            this.labelStopStep_MAI.Text = "Конец шага:";

            this.textBoxStopStep_MAI.Location = new System.Drawing.Point(110, 45);
            this.textBoxStopStep_MAI.Name = "textBoxStopStep_MAI";
            this.textBoxStopStep_MAI.Size = new System.Drawing.Size(80, 23);
            this.textBoxStopStep_MAI.TabIndex = 3;
            this.textBoxStopStep_MAI.Text = "5";

            this.buttonHelp_MAI.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHelp_MAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_MAI.Location = new System.Drawing.Point(222, 220);
            this.buttonHelp_MAI.Name = "buttonHelp_MAI";
            this.buttonHelp_MAI.Size = new System.Drawing.Size(68, 50);
            this.buttonHelp_MAI.TabIndex = 3;
            this.buttonHelp_MAI.Text = "Справка";
            this.buttonHelp_MAI.UseVisualStyleBackColor = false;
            this.buttonHelp_MAI.Click += new System.EventHandler(this.buttonHelp_MAI_Click);

            this.buttonDone_MAI.BackColor = System.Drawing.Color.Green;
            this.buttonDone_MAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_MAI.Location = new System.Drawing.Point(295, 220);
            this.buttonDone_MAI.Name = "buttonDone_MAI";
            this.buttonDone_MAI.Size = new System.Drawing.Size(82, 50);
            this.buttonDone_MAI.TabIndex = 4;
            this.buttonDone_MAI.Text = "Выполнить";
            this.buttonDone_MAI.UseVisualStyleBackColor = false;
            this.buttonDone_MAI.Click += new System.EventHandler(this.buttonDone_MAI_Click);
            this.buttonDone_MAI.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_MAI_MouseDown);
            this.buttonDone_MAI.MouseEnter += new System.EventHandler(this.buttonDone_MAI_MouseEnter);
            this.buttonDone_MAI.MouseLeave += new System.EventHandler(this.buttonDone_MAI_MouseLeave);

            this.groupBoxOutput_MAI.Controls.Add(this.chartFunction_MAI);
            this.groupBoxOutput_MAI.Controls.Add(this.dataGridViewFunction_MAI);
            this.groupBoxOutput_MAI.Controls.Add(this.labelResult_MAI);
            this.groupBoxOutput_MAI.Location = new System.Drawing.Point(385, 12);
            this.groupBoxOutput_MAI.Name = "groupBoxOutput_MAI";
            this.groupBoxOutput_MAI.Size = new System.Drawing.Size(440, 268);
            this.groupBoxOutput_MAI.TabIndex = 2;
            this.groupBoxOutput_MAI.TabStop = false;
            this.groupBoxOutput_MAI.Text = "Вывод данных";

            this.labelResult_MAI.AutoSize = true;
            this.labelResult_MAI.Location = new System.Drawing.Point(12, 20);
            this.labelResult_MAI.Name = "labelResult_MAI";
            this.labelResult_MAI.Size = new System.Drawing.Size(62, 15);
            this.labelResult_MAI.TabIndex = 0;
            this.labelResult_MAI.Text = "Результат:";

            this.dataGridViewFunction_MAI.AllowUserToAddRows = false;
            this.dataGridViewFunction_MAI.AllowUserToDeleteRows = false;
            this.dataGridViewFunction_MAI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_MAI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnX_MAI,
            this.columnFX_MAI});
            this.dataGridViewFunction_MAI.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewFunction_MAI.Name = "dataGridViewFunction_MAI";
            this.dataGridViewFunction_MAI.ReadOnly = true;
            this.dataGridViewFunction_MAI.RowHeadersVisible = false;
            this.dataGridViewFunction_MAI.Size = new System.Drawing.Size(120, 218);
            this.dataGridViewFunction_MAI.TabIndex = 1;

            this.columnX_MAI.HeaderText = "X";
            this.columnX_MAI.Name = "columnX_MAI";
            this.columnX_MAI.ReadOnly = true;
            this.columnX_MAI.Width = 45;

            this.columnFX_MAI.HeaderText = "F(x)";
            this.columnFX_MAI.Name = "columnFX_MAI";
            this.columnFX_MAI.ReadOnly = true;
            this.columnFX_MAI.Width = 55;

            chartArea1.Name = "ChartArea1";
            this.chartFunction_MAI.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartFunction_MAI.Legends.Add(legend1);
            this.chartFunction_MAI.Location = new System.Drawing.Point(138, 38);
            this.chartFunction_MAI.Name = "chartFunction_MAI";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_MAI.Series.Add(series1);
            this.chartFunction_MAI.Size = new System.Drawing.Size(290, 218);
            this.chartFunction_MAI.TabIndex = 2;
            this.chartFunction_MAI.Text = "chart1";
            this.chartFunction_MAI.Click += new System.EventHandler(this.chartFunction_MAI_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 295);
            this.Controls.Add(this.groupBoxOutput_MAI);
            this.Controls.Add(this.buttonDone_MAI);
            this.Controls.Add(this.buttonHelp_MAI);
            this.Controls.Add(this.groupBoxInput_MAI);
            this.Controls.Add(this.groupBoxTask_MAI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 26 | Михайличенко А. И.";
            this.groupBoxTask_MAI.ResumeLayout(false);
            this.groupBoxTask_MAI.PerformLayout();
            this.groupBoxInput_MAI.ResumeLayout(false);
            this.groupBoxInput_MAI.PerformLayout();
            this.groupBoxOutput_MAI.ResumeLayout(false);
            this.groupBoxOutput_MAI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_MAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_MAI)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBoxTask_MAI;
        private System.Windows.Forms.TextBox textBoxTask_MAI;
        private System.Windows.Forms.GroupBox groupBoxInput_MAI;
        private System.Windows.Forms.TextBox textBoxStopStep_MAI;
        private System.Windows.Forms.Label labelStopStep_MAI;
        private System.Windows.Forms.TextBox textBoxStartStep_MAI;
        private System.Windows.Forms.Label labelStartStep_MAI;
        private System.Windows.Forms.Button buttonHelp_MAI;
        private System.Windows.Forms.Button buttonDone_MAI;
        private System.Windows.Forms.GroupBox groupBoxOutput_MAI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_MAI;
        private System.Windows.Forms.DataGridView dataGridViewFunction_MAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnX_MAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFX_MAI;
        private System.Windows.Forms.Label labelResult_MAI;
    }
}
