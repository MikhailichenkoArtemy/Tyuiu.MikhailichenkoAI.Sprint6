namespace Tyuiu.MikhailichenkoAI.Sprint6.Task0.V23
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
            this.pictureBoxFormula_MAI = new System.Windows.Forms.PictureBox();
            this.groupBoxInput_MAI = new System.Windows.Forms.GroupBox();
            this.labelVarX_MAI = new System.Windows.Forms.Label();
            this.textBoxVarX_MAI = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_MAI = new System.Windows.Forms.GroupBox();
            this.labelResult_MAI = new System.Windows.Forms.Label();
            this.textBoxResult_MAI = new System.Windows.Forms.TextBox();
            this.buttonHelp_MAI = new System.Windows.Forms.Button();
            this.buttonDone_MAI = new System.Windows.Forms.Button();
            this.groupBoxTask_MAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_MAI)).BeginInit();
            this.groupBoxInput_MAI.SuspendLayout();
            this.groupBoxOutput_MAI.SuspendLayout();
            this.SuspendLayout();

            this.groupBoxTask_MAI.Controls.Add(this.pictureBoxFormula_MAI);
            this.groupBoxTask_MAI.Controls.Add(this.textBoxTask_MAI);
            this.groupBoxTask_MAI.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_MAI.Name = "groupBoxTask_MAI";
            this.groupBoxTask_MAI.Size = new System.Drawing.Size(490, 130);
            this.groupBoxTask_MAI.TabIndex = 0;
            this.groupBoxTask_MAI.TabStop = false;
            this.groupBoxTask_MAI.Text = "Условие";

            this.textBoxTask_MAI.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_MAI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_MAI.Location = new System.Drawing.Point(15, 25);
            this.textBoxTask_MAI.Multiline = true;
            this.textBoxTask_MAI.Name = "textBoxTask_MAI";
            this.textBoxTask_MAI.ReadOnly = true;
            this.textBoxTask_MAI.Size = new System.Drawing.Size(310, 90);
            this.textBoxTask_MAI.TabIndex = 0;
            this.textBoxTask_MAI.TabStop = false;
            this.textBoxTask_MAI.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Округлить до трёх знаков после запятой.";

            this.pictureBoxFormula_MAI.Location = new System.Drawing.Point(340, 20);
            this.pictureBoxFormula_MAI.Name = "pictureBoxFormula_MAI";
            this.pictureBoxFormula_MAI.Size = new System.Drawing.Size(135, 95);
            this.pictureBoxFormula_MAI.TabIndex = 1;
            this.pictureBoxFormula_MAI.TabStop = false;

            this.groupBoxInput_MAI.Controls.Add(this.textBoxVarX_MAI);
            this.groupBoxInput_MAI.Controls.Add(this.labelVarX_MAI);
            this.groupBoxInput_MAI.Location = new System.Drawing.Point(12, 148);
            this.groupBoxInput_MAI.Name = "groupBoxInput_MAI";
            this.groupBoxInput_MAI.Size = new System.Drawing.Size(295, 80);
            this.groupBoxInput_MAI.TabIndex = 1;
            this.groupBoxInput_MAI.TabStop = false;
            this.groupBoxInput_MAI.Text = "Ввод данных";

            this.labelVarX_MAI.AutoSize = true;
            this.labelVarX_MAI.Location = new System.Drawing.Point(15, 25);
            this.labelVarX_MAI.Name = "labelVarX_MAI";
            this.labelVarX_MAI.Size = new System.Drawing.Size(83, 15);
            this.labelVarX_MAI.TabIndex = 0;
            this.labelVarX_MAI.Text = "Переменная X:";

            this.textBoxVarX_MAI.Location = new System.Drawing.Point(18, 45);
            this.textBoxVarX_MAI.Name = "textBoxVarX_MAI";
            this.textBoxVarX_MAI.Size = new System.Drawing.Size(100, 23);
            this.textBoxVarX_MAI.TabIndex = 1;
            this.textBoxVarX_MAI.Text = "3";
            this.textBoxVarX_MAI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_MAI_KeyPress);

            this.groupBoxOutput_MAI.Controls.Add(this.textBoxResult_MAI);
            this.groupBoxOutput_MAI.Controls.Add(this.labelResult_MAI);
            this.groupBoxOutput_MAI.Location = new System.Drawing.Point(320, 148);
            this.groupBoxOutput_MAI.Name = "groupBoxOutput_MAI";
            this.groupBoxOutput_MAI.Size = new System.Drawing.Size(182, 80);
            this.groupBoxOutput_MAI.TabIndex = 2;
            this.groupBoxOutput_MAI.TabStop = false;
            this.groupBoxOutput_MAI.Text = "Вывод данных";

            this.labelResult_MAI.AutoSize = true;
            this.labelResult_MAI.Location = new System.Drawing.Point(15, 25);
            this.labelResult_MAI.Name = "labelResult_MAI";
            this.labelResult_MAI.Size = new System.Drawing.Size(62, 15);
            this.labelResult_MAI.TabIndex = 0;
            this.labelResult_MAI.Text = "Результат:";

            this.textBoxResult_MAI.Location = new System.Drawing.Point(18, 45);
            this.textBoxResult_MAI.Name = "textBoxResult_MAI";
            this.textBoxResult_MAI.ReadOnly = true;
            this.textBoxResult_MAI.Size = new System.Drawing.Size(145, 23);
            this.textBoxResult_MAI.TabIndex = 1;

            this.buttonHelp_MAI.Location = new System.Drawing.Point(338, 238);
            this.buttonHelp_MAI.Name = "buttonHelp_MAI";
            this.buttonHelp_MAI.Size = new System.Drawing.Size(40, 30);
            this.buttonHelp_MAI.TabIndex = 3;
            this.buttonHelp_MAI.Text = "?";
            this.buttonHelp_MAI.UseVisualStyleBackColor = true;
            this.buttonHelp_MAI.Click += new System.EventHandler(this.buttonHelp_MAI_Click);

            this.buttonDone_MAI.Location = new System.Drawing.Point(385, 238);
            this.buttonDone_MAI.Name = "buttonDone_MAI";
            this.buttonDone_MAI.Size = new System.Drawing.Size(115, 30);
            this.buttonDone_MAI.TabIndex = 4;
            this.buttonDone_MAI.Text = "Выполнить";
            this.buttonDone_MAI.UseVisualStyleBackColor = true;
            this.buttonDone_MAI.Click += new System.EventHandler(this.buttonDone_MAI_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 285);
            this.Controls.Add(this.buttonDone_MAI);
            this.Controls.Add(this.buttonHelp_MAI);
            this.Controls.Add(this.groupBoxOutput_MAI);
            this.Controls.Add(this.groupBoxInput_MAI);
            this.Controls.Add(this.groupBoxTask_MAI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 23 | Михайличенко А. И.";
            this.groupBoxTask_MAI.ResumeLayout(false);
            this.groupBoxTask_MAI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_MAI)).EndInit();
            this.groupBoxInput_MAI.ResumeLayout(false);
            this.groupBoxInput_MAI.PerformLayout();
            this.groupBoxOutput_MAI.ResumeLayout(false);
            this.groupBoxOutput_MAI.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBoxTask_MAI;
        private System.Windows.Forms.PictureBox pictureBoxFormula_MAI;
        private System.Windows.Forms.TextBox textBoxTask_MAI;
        private System.Windows.Forms.GroupBox groupBoxInput_MAI;
        private System.Windows.Forms.TextBox textBoxVarX_MAI;
        private System.Windows.Forms.Label labelVarX_MAI;
        private System.Windows.Forms.GroupBox groupBoxOutput_MAI;
        private System.Windows.Forms.TextBox textBoxResult_MAI;
        private System.Windows.Forms.Label labelResult_MAI;
        private System.Windows.Forms.Button buttonHelp_MAI;
        private System.Windows.Forms.Button buttonDone_MAI;
    }
}
