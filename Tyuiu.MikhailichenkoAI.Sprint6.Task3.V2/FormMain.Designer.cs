namespace Tyuiu.MikhailichenkoAI.Sprint6.Task3.V2
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
            this.dataGridViewMatrix_MAI = new System.Windows.Forms.DataGridView();
            this.textBoxTask_MAI = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_MAI = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_MAI = new System.Windows.Forms.DataGridView();
            this.labelResult_MAI = new System.Windows.Forms.Label();
            this.buttonHelp_MAI = new System.Windows.Forms.Button();
            this.buttonDone_MAI = new System.Windows.Forms.Button();
            this.groupBoxTask_MAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_MAI)).BeginInit();
            this.groupBoxOutput_MAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_MAI)).BeginInit();
            this.SuspendLayout();

            this.groupBoxTask_MAI.Controls.Add(this.dataGridViewMatrix_MAI);
            this.groupBoxTask_MAI.Controls.Add(this.textBoxTask_MAI);
            this.groupBoxTask_MAI.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_MAI.Name = "groupBoxTask_MAI";
            this.groupBoxTask_MAI.Size = new System.Drawing.Size(420, 260);
            this.groupBoxTask_MAI.TabIndex = 0;
            this.groupBoxTask_MAI.TabStop = false;
            this.groupBoxTask_MAI.Text = "Условие";

            this.textBoxTask_MAI.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_MAI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_MAI.Location = new System.Drawing.Point(15, 25);
            this.textBoxTask_MAI.Multiline = true;
            this.textBoxTask_MAI.Name = "textBoxTask_MAI";
            this.textBoxTask_MAI.ReadOnly = true;
            this.textBoxTask_MAI.Size = new System.Drawing.Size(185, 215);
            this.textBoxTask_MAI.TabIndex = 0;
            this.textBoxTask_MAI.TabStop = false;
            this.textBoxTask_MAI.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в первой строке на 0. Результат вывести в DataGridView.";

            this.dataGridViewMatrix_MAI.AllowUserToAddRows = false;
            this.dataGridViewMatrix_MAI.AllowUserToDeleteRows = false;
            this.dataGridViewMatrix_MAI.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_MAI.Location = new System.Drawing.Point(210, 25);
            this.dataGridViewMatrix_MAI.Name = "dataGridViewMatrix_MAI";
            this.dataGridViewMatrix_MAI.ReadOnly = true;
            this.dataGridViewMatrix_MAI.RowHeadersVisible = false;
            this.dataGridViewMatrix_MAI.Size = new System.Drawing.Size(195, 215);
            this.dataGridViewMatrix_MAI.TabIndex = 1;

            this.groupBoxOutput_MAI.Controls.Add(this.dataGridViewResult_MAI);
            this.groupBoxOutput_MAI.Controls.Add(this.labelResult_MAI);
            this.groupBoxOutput_MAI.Location = new System.Drawing.Point(440, 12);
            this.groupBoxOutput_MAI.Name = "groupBoxOutput_MAI";
            this.groupBoxOutput_MAI.Size = new System.Drawing.Size(220, 215);
            this.groupBoxOutput_MAI.TabIndex = 1;
            this.groupBoxOutput_MAI.TabStop = false;
            this.groupBoxOutput_MAI.Text = "Вывод данных";

            this.labelResult_MAI.AutoSize = true;
            this.labelResult_MAI.Location = new System.Drawing.Point(12, 20);
            this.labelResult_MAI.Name = "labelResult_MAI";
            this.labelResult_MAI.Size = new System.Drawing.Size(62, 15);
            this.labelResult_MAI.TabIndex = 0;
            this.labelResult_MAI.Text = "Результат:";

            this.dataGridViewResult_MAI.AllowUserToAddRows = false;
            this.dataGridViewResult_MAI.AllowUserToDeleteRows = false;
            this.dataGridViewResult_MAI.ColumnHeadersVisible = false;
            this.dataGridViewResult_MAI.Location = new System.Drawing.Point(12, 40);
            this.dataGridViewResult_MAI.Name = "dataGridViewResult_MAI";
            this.dataGridViewResult_MAI.ReadOnly = true;
            this.dataGridViewResult_MAI.RowHeadersVisible = false;
            this.dataGridViewResult_MAI.Size = new System.Drawing.Size(195, 160);
            this.dataGridViewResult_MAI.TabIndex = 1;

            this.buttonHelp_MAI.Location = new System.Drawing.Point(495, 240);
            this.buttonHelp_MAI.Name = "buttonHelp_MAI";
            this.buttonHelp_MAI.Size = new System.Drawing.Size(40, 30);
            this.buttonHelp_MAI.TabIndex = 2;
            this.buttonHelp_MAI.Text = "?";
            this.buttonHelp_MAI.UseVisualStyleBackColor = true;
            this.buttonHelp_MAI.Click += new System.EventHandler(this.buttonHelp_MAI_Click);

            this.buttonDone_MAI.Location = new System.Drawing.Point(545, 240);
            this.buttonDone_MAI.Name = "buttonDone_MAI";
            this.buttonDone_MAI.Size = new System.Drawing.Size(115, 30);
            this.buttonDone_MAI.TabIndex = 3;
            this.buttonDone_MAI.Text = "Выполнить";
            this.buttonDone_MAI.UseVisualStyleBackColor = true;
            this.buttonDone_MAI.Click += new System.EventHandler(this.buttonDone_MAI_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 285);
            this.Controls.Add(this.buttonDone_MAI);
            this.Controls.Add(this.buttonHelp_MAI);
            this.Controls.Add(this.groupBoxOutput_MAI);
            this.Controls.Add(this.groupBoxTask_MAI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 2 | Михайличенко А. И.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_MAI.ResumeLayout(false);
            this.groupBoxTask_MAI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_MAI)).EndInit();
            this.groupBoxOutput_MAI.ResumeLayout(false);
            this.groupBoxOutput_MAI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_MAI)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBoxTask_MAI;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_MAI;
        private System.Windows.Forms.TextBox textBoxTask_MAI;
        private System.Windows.Forms.GroupBox groupBoxOutput_MAI;
        private System.Windows.Forms.DataGridView dataGridViewResult_MAI;
        private System.Windows.Forms.Label labelResult_MAI;
        private System.Windows.Forms.Button buttonHelp_MAI;
        private System.Windows.Forms.Button buttonDone_MAI;
    }
}
