namespace Tyuiu.MikhailichenkoAI.Sprint6.Task1.V30
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
            this.groupBoxTask_MAI = new System.Windows.Forms.GroupBox();
            this.textBoxTask_MAI = new System.Windows.Forms.TextBox();
            this.groupBoxInput_MAI = new System.Windows.Forms.GroupBox();
            this.labelStartStep_MAI = new System.Windows.Forms.Label();
            this.textBoxStartStep_MAI = new System.Windows.Forms.TextBox();
            this.labelStopStep_MAI = new System.Windows.Forms.Label();
            this.textBoxStopStep_MAI = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_MAI = new System.Windows.Forms.GroupBox();
            this.labelResult_MAI = new System.Windows.Forms.Label();
            this.textBoxResult_MAI = new System.Windows.Forms.TextBox();
            this.buttonHelp_MAI = new System.Windows.Forms.Button();
            this.buttonDone_MAI = new System.Windows.Forms.Button();
            this.groupBoxTask_MAI.SuspendLayout();
            this.groupBoxInput_MAI.SuspendLayout();
            this.groupBoxOutput_MAI.SuspendLayout();
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
            this.textBoxTask_MAI.Text = "Протабулировать функцию F(x) = (2x - 3) / (cos(x) - 2x) + 5x - 6 на заданном диапазоне [-5; 5] с шагом 1. Результат вывести в виде таблицы.";

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

            this.groupBoxOutput_MAI.Controls.Add(this.textBoxResult_MAI);
            this.groupBoxOutput_MAI.Controls.Add(this.labelResult_MAI);
            this.groupBoxOutput_MAI.Location = new System.Drawing.Point(385, 12);
            this.groupBoxOutput_MAI.Name = "groupBoxOutput_MAI";
            this.groupBoxOutput_MAI.Size = new System.Drawing.Size(220, 268);
            this.groupBoxOutput_MAI.TabIndex = 2;
            this.groupBoxOutput_MAI.TabStop = false;
            this.groupBoxOutput_MAI.Text = "Вывод данных";

            this.labelResult_MAI.AutoSize = true;
            this.labelResult_MAI.Location = new System.Drawing.Point(15, 22);
            this.labelResult_MAI.Name = "labelResult_MAI";
            this.labelResult_MAI.Size = new System.Drawing.Size(62, 15);
            this.labelResult_MAI.TabIndex = 0;
            this.labelResult_MAI.Text = "Результат:";

            this.textBoxResult_MAI.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxResult_MAI.Location = new System.Drawing.Point(15, 42);
            this.textBoxResult_MAI.Multiline = true;
            this.textBoxResult_MAI.Name = "textBoxResult_MAI";
            this.textBoxResult_MAI.ReadOnly = true;
            this.textBoxResult_MAI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_MAI.Size = new System.Drawing.Size(190, 215);
            this.textBoxResult_MAI.TabIndex = 1;
            this.textBoxResult_MAI.WordWrap = false;

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 295);
            this.Controls.Add(this.buttonDone_MAI);
            this.Controls.Add(this.buttonHelp_MAI);
            this.Controls.Add(this.groupBoxOutput_MAI);
            this.Controls.Add(this.groupBoxInput_MAI);
            this.Controls.Add(this.groupBoxTask_MAI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 30 | Михайличенко А. И.";
            this.groupBoxTask_MAI.ResumeLayout(false);
            this.groupBoxTask_MAI.PerformLayout();
            this.groupBoxInput_MAI.ResumeLayout(false);
            this.groupBoxInput_MAI.PerformLayout();
            this.groupBoxOutput_MAI.ResumeLayout(false);
            this.groupBoxOutput_MAI.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBoxTask_MAI;
        private System.Windows.Forms.TextBox textBoxTask_MAI;
        private System.Windows.Forms.GroupBox groupBoxInput_MAI;
        private System.Windows.Forms.TextBox textBoxStopStep_MAI;
        private System.Windows.Forms.Label labelStopStep_MAI;
        private System.Windows.Forms.TextBox textBoxStartStep_MAI;
        private System.Windows.Forms.Label labelStartStep_MAI;
        private System.Windows.Forms.GroupBox groupBoxOutput_MAI;
        private System.Windows.Forms.TextBox textBoxResult_MAI;
        private System.Windows.Forms.Label labelResult_MAI;
        private System.Windows.Forms.Button buttonHelp_MAI;
        private System.Windows.Forms.Button buttonDone_MAI;
    }
}
