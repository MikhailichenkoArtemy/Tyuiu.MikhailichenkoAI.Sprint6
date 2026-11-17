namespace Tyuiu.MikhailichenkoAI.Sprint6.Task4.V24
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxTask_MAI = new System.Windows.Forms.GroupBox();
            this.textBoxTask_MAI = new System.Windows.Forms.TextBox();
            this.groupBoxInput_MAI = new System.Windows.Forms.GroupBox();
            this.textBoxStopStep_MAI = new System.Windows.Forms.TextBox();
            this.labelStopStep_MAI = new System.Windows.Forms.Label();
            this.textBoxStartStep_MAI = new System.Windows.Forms.TextBox();
            this.labelStartStep_MAI = new System.Windows.Forms.Label();
            this.buttonDone_MAI = new System.Windows.Forms.Button();
            this.buttonSave_MAI = new System.Windows.Forms.Button();
            this.buttonHelp_MAI = new System.Windows.Forms.Button();
            this.groupBoxOutput_MAI = new System.Windows.Forms.GroupBox();
            this.textBoxResult_MAI = new System.Windows.Forms.TextBox();
            this.chartFunction_MAI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_MAI.SuspendLayout();
            this.groupBoxInput_MAI.SuspendLayout();
            this.groupBoxOutput_MAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_MAI)).BeginInit();
            this.SuspendLayout();

            this.groupBoxTask_MAI.Controls.Add(this.textBoxTask_MAI);
            this.groupBoxTask_MAI.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_MAI.Name = "groupBoxTask_MAI";
            this.groupBoxTask_MAI.Size = new System.Drawing.Size(360, 80);
            this.groupBoxTask_MAI.TabIndex = 0;
            this.groupBoxTask_MAI.TabStop = false;
            this.groupBoxTask_MAI.Text = "Условие:";

            this.textBoxTask_MAI.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_MAI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_MAI.Location = new System.Drawing.Point(10, 20);
            this.textBoxTask_MAI.Multiline = true;
            this.textBoxTask_MAI.Name = "textBoxTask_MAI";
            this.textBoxTask_MAI.ReadOnly = true;
            this.textBoxTask_MAI.Size = new System.Drawing.Size(340, 52);
            this.textBoxTask_MAI.TabIndex = 0;
            this.textBoxTask_MAI.TabStop = false;
            this.textBoxTask_MAI.Text = "Протабулировать функцию F(x) на заданном диапазоне от -5 до 5. Результат вывести в textBox, построить график функции и сохранить в файл OutPutFileTask4V24.txt по нажатию кнопки.";

            this.groupBoxInput_MAI.Controls.Add(this.textBoxStopStep_MAI);
            this.groupBoxInput_MAI.Controls.Add(this.labelStopStep_MAI);
            this.groupBoxInput_MAI.Controls.Add(this.textBoxStartStep_MAI);
            this.groupBoxInput_MAI.Controls.Add(this.labelStartStep_MAI);
            this.groupBoxInput_MAI.Location = new System.Drawing.Point(378, 12);
            this.groupBoxInput_MAI.Name = "groupBoxInput_MAI";
            this.groupBoxInput_MAI.Size = new System.Drawing.Size(215, 80);
            this.groupBoxInput_MAI.TabIndex = 1;
            this.groupBoxInput_MAI.TabStop = false;
            this.groupBoxInput_MAI.Text = "Ввод данных:";

            this.labelStartStep_MAI.AutoSize = true;
            this.labelStartStep_MAI.Location = new System.Drawing.Point(12, 22);
            this.labelStartStep_MAI.Name = "labelStartStep_MAI";
            this.labelStartStep_MAI.Size = new System.Drawing.Size(70, 15);
            this.labelStartStep_MAI.TabIndex = 0;
            this.labelStartStep_MAI.Text = "Старт шага:";

            this.textBoxStartStep_MAI.Location = new System.Drawing.Point(15, 42);
            this.textBoxStartStep_MAI.Name = "textBoxStartStep_MAI";
            this.textBoxStartStep_MAI.Size = new System.Drawing.Size(80, 23);
            this.textBoxStartStep_MAI.TabIndex = 1;
            this.textBoxStartStep_MAI.Text = "-5";

            this.labelStopStep_MAI.AutoSize = true;
            this.labelStopStep_MAI.Location = new System.Drawing.Point(110, 22);
            this.labelStopStep_MAI.Name = "labelStopStep_MAI";
            this.labelStopStep_MAI.Size = new System.Drawing.Size(74, 15);
            this.labelStopStep_MAI.TabIndex = 2;
            this.labelStopStep_MAI.Text = "Конец шага:";

            this.textBoxStopStep_MAI.Location = new System.Drawing.Point(113, 42);
            this.textBoxStopStep_MAI.Name = "textBoxStopStep_MAI";
            this.textBoxStopStep_MAI.Size = new System.Drawing.Size(80, 23);
            this.textBoxStopStep_MAI.TabIndex = 3;
            this.textBoxStopStep_MAI.Text = "5";

            this.buttonDone_MAI.BackColor = System.Drawing.Color.Green;
            this.buttonDone_MAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_MAI.Location = new System.Drawing.Point(605, 22);
            this.buttonDone_MAI.Name = "buttonDone_MAI";
            this.buttonDone_MAI.Size = new System.Drawing.Size(80, 62);
            this.buttonDone_MAI.TabIndex = 2;
            this.buttonDone_MAI.Text = "Выполнить";
            this.buttonDone_MAI.UseVisualStyleBackColor = false;
            this.buttonDone_MAI.Click += new System.EventHandler(this.buttonDone_MAI_Click);

            this.buttonSave_MAI.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave_MAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_MAI.Location = new System.Drawing.Point(695, 22);
            this.buttonSave_MAI.Name = "buttonSave_MAI";
            this.buttonSave_MAI.Size = new System.Drawing.Size(80, 62);
            this.buttonSave_MAI.TabIndex = 3;
            this.buttonSave_MAI.Text = "Сохранить";
            this.buttonSave_MAI.UseVisualStyleBackColor = false;
            this.buttonSave_MAI.Click += new System.EventHandler(this.buttonSave_MAI_Click);

            this.buttonHelp_MAI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_MAI.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHelp_MAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_MAI.Location = new System.Drawing.Point(820, 22);
            this.buttonHelp_MAI.Name = "buttonHelp_MAI";
            this.buttonHelp_MAI.Size = new System.Drawing.Size(80, 62);
            this.buttonHelp_MAI.TabIndex = 4;
            this.buttonHelp_MAI.Text = "Справка";
            this.buttonHelp_MAI.UseVisualStyleBackColor = false;
            this.buttonHelp_MAI.Click += new System.EventHandler(this.buttonHelp_MAI_Click);

            this.groupBoxOutput_MAI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxOutput_MAI.Controls.Add(this.textBoxResult_MAI);
            this.groupBoxOutput_MAI.Location = new System.Drawing.Point(12, 98);
            this.groupBoxOutput_MAI.Name = "groupBoxOutput_MAI";
            this.groupBoxOutput_MAI.Size = new System.Drawing.Size(215, 360);
            this.groupBoxOutput_MAI.TabIndex = 5;
            this.groupBoxOutput_MAI.TabStop = false;
            this.groupBoxOutput_MAI.Text = "Вывод:";

            this.textBoxResult_MAI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult_MAI.Location = new System.Drawing.Point(10, 22);
            this.textBoxResult_MAI.Multiline = true;
            this.textBoxResult_MAI.Name = "textBoxResult_MAI";
            this.textBoxResult_MAI.ReadOnly = true;
            this.textBoxResult_MAI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_MAI.Size = new System.Drawing.Size(195, 325);
            this.textBoxResult_MAI.TabIndex = 0;

            this.chartFunction_MAI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartFunction_MAI.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartFunction_MAI.Legends.Add(legend1);
            this.chartFunction_MAI.Location = new System.Drawing.Point(235, 98);
            this.chartFunction_MAI.Name = "chartFunction_MAI";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_MAI.Series.Add(series1);
            this.chartFunction_MAI.Size = new System.Drawing.Size(665, 360);
            this.chartFunction_MAI.TabIndex = 6;
            this.chartFunction_MAI.Text = "chartFunction_MAI";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "График функции sin(x)/(x+1.2) - sin(x)*2 - 2x";
            this.chartFunction_MAI.Titles.Add(title1);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 470);
            this.Controls.Add(this.chartFunction_MAI);
            this.Controls.Add(this.groupBoxOutput_MAI);
            this.Controls.Add(this.buttonHelp_MAI);
            this.Controls.Add(this.buttonSave_MAI);
            this.Controls.Add(this.buttonDone_MAI);
            this.Controls.Add(this.groupBoxInput_MAI);
            this.Controls.Add(this.groupBoxTask_MAI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.MinimumSize = new System.Drawing.Size(850, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 24 | Михайличенко А. И.";
            this.groupBoxTask_MAI.ResumeLayout(false);
            this.groupBoxTask_MAI.PerformLayout();
            this.groupBoxInput_MAI.ResumeLayout(false);
            this.groupBoxInput_MAI.PerformLayout();
            this.groupBoxOutput_MAI.ResumeLayout(false);
            this.groupBoxOutput_MAI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_MAI)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBoxTask_MAI;
        private System.Windows.Forms.TextBox textBoxTask_MAI;
        private System.Windows.Forms.GroupBox groupBoxInput_MAI;
        private System.Windows.Forms.TextBox textBoxStopStep_MAI;
        private System.Windows.Forms.Label labelStopStep_MAI;
        private System.Windows.Forms.TextBox textBoxStartStep_MAI;
        private System.Windows.Forms.Label labelStartStep_MAI;
        private System.Windows.Forms.Button buttonDone_MAI;
        private System.Windows.Forms.Button buttonSave_MAI;
        private System.Windows.Forms.Button buttonHelp_MAI;
        private System.Windows.Forms.GroupBox groupBoxOutput_MAI;
        private System.Windows.Forms.TextBox textBoxResult_MAI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_MAI;
    }
}
