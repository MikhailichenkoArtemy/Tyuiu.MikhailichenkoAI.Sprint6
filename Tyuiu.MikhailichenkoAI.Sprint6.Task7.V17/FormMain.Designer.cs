namespace Tyuiu.MikhailichenkoAI.Sprint6.Task7.V17
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
            this.components = new System.ComponentModel.Container();
            this.panelTop_MAI = new System.Windows.Forms.Panel();
            this.buttonHelp_MAI = new System.Windows.Forms.Button();
            this.buttonSaveFile_MAI = new System.Windows.Forms.Button();
            this.buttonDone_MAI = new System.Windows.Forms.Button();
            this.buttonOpenFile_MAI = new System.Windows.Forms.Button();
            this.groupBoxTask_MAI = new System.Windows.Forms.GroupBox();
            this.textBoxTask_MAI = new System.Windows.Forms.TextBox();
            this.splitContainerMain_MAI = new System.Windows.Forms.SplitContainer();
            this.groupBoxIn_MAI = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_MAI = new System.Windows.Forms.DataGridView();
            this.groupBoxOut_MAI = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut_MAI = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_MAI = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_MAI = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_MAI = new System.Windows.Forms.SaveFileDialog();
            this.panelTop_MAI.SuspendLayout();
            this.groupBoxTask_MAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain_MAI)).BeginInit();
            this.splitContainerMain_MAI.Panel1.SuspendLayout();
            this.splitContainerMain_MAI.Panel2.SuspendLayout();
            this.splitContainerMain_MAI.SuspendLayout();
            this.groupBoxIn_MAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_MAI)).BeginInit();
            this.groupBoxOut_MAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_MAI)).BeginInit();
            this.SuspendLayout();

            this.panelTop_MAI.Controls.Add(this.buttonHelp_MAI);
            this.panelTop_MAI.Controls.Add(this.buttonSaveFile_MAI);
            this.panelTop_MAI.Controls.Add(this.buttonDone_MAI);
            this.panelTop_MAI.Controls.Add(this.buttonOpenFile_MAI);
            this.panelTop_MAI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_MAI.Location = new System.Drawing.Point(0, 0);
            this.panelTop_MAI.Name = "panelTop_MAI";
            this.panelTop_MAI.Size = new System.Drawing.Size(884, 65);
            this.panelTop_MAI.TabIndex = 0;

            this.buttonOpenFile_MAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_MAI.Location = new System.Drawing.Point(12, 5);
            this.buttonOpenFile_MAI.Name = "buttonOpenFile_MAI";
            this.buttonOpenFile_MAI.Size = new System.Drawing.Size(75, 55);
            this.buttonOpenFile_MAI.TabIndex = 0;
            this.buttonOpenFile_MAI.Text = "📂";
            this.toolTipButton_MAI.SetToolTip(this.buttonOpenFile_MAI, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_MAI.UseVisualStyleBackColor = true;
            this.buttonOpenFile_MAI.Click += new System.EventHandler(this.buttonOpenFile_MAI_Click);

            this.buttonDone_MAI.Enabled = false;
            this.buttonDone_MAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_MAI.Location = new System.Drawing.Point(93, 5);
            this.buttonDone_MAI.Name = "buttonDone_MAI";
            this.buttonDone_MAI.Size = new System.Drawing.Size(75, 55);
            this.buttonDone_MAI.TabIndex = 1;
            this.buttonDone_MAI.Text = "▶";
            this.toolTipButton_MAI.SetToolTip(this.buttonDone_MAI, "Выполнить\r\nВыполняет обработку данных");
            this.buttonDone_MAI.UseVisualStyleBackColor = true;
            this.buttonDone_MAI.Click += new System.EventHandler(this.buttonDone_MAI_Click);

            this.buttonSaveFile_MAI.Enabled = false;
            this.buttonSaveFile_MAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_MAI.Location = new System.Drawing.Point(174, 5);
            this.buttonSaveFile_MAI.Name = "buttonSaveFile_MAI";
            this.buttonSaveFile_MAI.Size = new System.Drawing.Size(75, 55);
            this.buttonSaveFile_MAI.TabIndex = 2;
            this.buttonSaveFile_MAI.Text = "💾";
            this.toolTipButton_MAI.SetToolTip(this.buttonSaveFile_MAI, "Сохранить\r\nСохраняет результат в файл");
            this.buttonSaveFile_MAI.UseVisualStyleBackColor = true;
            this.buttonSaveFile_MAI.Click += new System.EventHandler(this.buttonSaveFile_MAI_Click);

            this.buttonHelp_MAI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_MAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_MAI.Location = new System.Drawing.Point(797, 5);
            this.buttonHelp_MAI.Name = "buttonHelp_MAI";
            this.buttonHelp_MAI.Size = new System.Drawing.Size(75, 55);
            this.buttonHelp_MAI.TabIndex = 3;
            this.buttonHelp_MAI.Text = "❓";
            this.toolTipButton_MAI.SetToolTip(this.buttonHelp_MAI, "Сведения о программе");
            this.buttonHelp_MAI.UseVisualStyleBackColor = true;
            this.buttonHelp_MAI.Click += new System.EventHandler(this.buttonHelp_MAI_Click);

            this.groupBoxTask_MAI.Controls.Add(this.textBoxTask_MAI);
            this.groupBoxTask_MAI.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTask_MAI.Location = new System.Drawing.Point(0, 65);
            this.groupBoxTask_MAI.Name = "groupBoxTask_MAI";
            this.groupBoxTask_MAI.Size = new System.Drawing.Size(884, 75);
            this.groupBoxTask_MAI.TabIndex = 1;
            this.groupBoxTask_MAI.TabStop = false;
            this.groupBoxTask_MAI.Text = "Условие:";

            this.textBoxTask_MAI.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_MAI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_MAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_MAI.Location = new System.Drawing.Point(3, 19);
            this.textBoxTask_MAI.Multiline = true;
            this.textBoxTask_MAI.Name = "textBoxTask_MAI";
            this.textBoxTask_MAI.ReadOnly = true;
            this.textBoxTask_MAI.Size = new System.Drawing.Size(878, 53);
            this.textBoxTask_MAI.TabIndex = 0;
            this.textBoxTask_MAI.TabStop = false;
            this.textBoxTask_MAI.Text = "Дан файл InPutFileTask7V17.csv в котором хранится матрица целочисленных значений. Загрузить файл через openFileDialog в объект dataGridViewIn. Изменить во второй строке четные числа на 4. Результат вывести в объект dataGridViewOut. Сохранить результат в файл OutPutFileTask7.csv через saveFileDialog.";

            this.splitContainerMain_MAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain_MAI.Location = new System.Drawing.Point(0, 140);
            this.splitContainerMain_MAI.Name = "splitContainerMain_MAI";
            this.splitContainerMain_MAI.Panel1.Controls.Add(this.groupBoxIn_MAI);
            this.splitContainerMain_MAI.Panel2.Controls.Add(this.groupBoxOut_MAI);
            this.splitContainerMain_MAI.Size = new System.Drawing.Size(884, 371);
            this.splitContainerMain_MAI.SplitterDistance = 440;
            this.splitContainerMain_MAI.TabIndex = 2;

            this.groupBoxIn_MAI.Controls.Add(this.dataGridViewIn_MAI);
            this.groupBoxIn_MAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxIn_MAI.Location = new System.Drawing.Point(0, 0);
            this.groupBoxIn_MAI.Name = "groupBoxIn_MAI";
            this.groupBoxIn_MAI.Size = new System.Drawing.Size(440, 371);
            this.groupBoxIn_MAI.TabIndex = 0;
            this.groupBoxIn_MAI.TabStop = false;
            this.groupBoxIn_MAI.Text = "Ввод:";

            this.dataGridViewIn_MAI.AllowUserToAddRows = false;
            this.dataGridViewIn_MAI.AllowUserToDeleteRows = false;
            this.dataGridViewIn_MAI.ColumnHeadersVisible = false;
            this.dataGridViewIn_MAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn_MAI.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewIn_MAI.Name = "dataGridViewIn_MAI";
            this.dataGridViewIn_MAI.ReadOnly = true;
            this.dataGridViewIn_MAI.RowHeadersVisible = false;
            this.dataGridViewIn_MAI.Size = new System.Drawing.Size(434, 349);
            this.dataGridViewIn_MAI.TabIndex = 0;

            this.groupBoxOut_MAI.Controls.Add(this.dataGridViewOut_MAI);
            this.groupBoxOut_MAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOut_MAI.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOut_MAI.Name = "groupBoxOut_MAI";
            this.groupBoxOut_MAI.Size = new System.Drawing.Size(440, 371);
            this.groupBoxOut_MAI.TabIndex = 0;
            this.groupBoxOut_MAI.TabStop = false;
            this.groupBoxOut_MAI.Text = "Вывод:";

            this.dataGridViewOut_MAI.AllowUserToAddRows = false;
            this.dataGridViewOut_MAI.AllowUserToDeleteRows = false;
            this.dataGridViewOut_MAI.ColumnHeadersVisible = false;
            this.dataGridViewOut_MAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut_MAI.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewOut_MAI.Name = "dataGridViewOut_MAI";
            this.dataGridViewOut_MAI.ReadOnly = true;
            this.dataGridViewOut_MAI.RowHeadersVisible = false;
            this.dataGridViewOut_MAI.Size = new System.Drawing.Size(434, 349);
            this.dataGridViewOut_MAI.TabIndex = 0;

            this.openFileDialogTask_MAI.FileName = "InPutFileTask7V17.csv";
            this.saveFileDialogMatrix_MAI.DefaultExt = "csv";

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.splitContainerMain_MAI);
            this.Controls.Add(this.groupBoxTask_MAI);
            this.Controls.Add(this.panelTop_MAI);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 17 | Михайличенко А. И.";
            this.panelTop_MAI.ResumeLayout(false);
            this.groupBoxTask_MAI.ResumeLayout(false);
            this.groupBoxTask_MAI.PerformLayout();
            this.splitContainerMain_MAI.Panel1.ResumeLayout(false);
            this.splitContainerMain_MAI.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain_MAI)).EndInit();
            this.splitContainerMain_MAI.ResumeLayout(false);
            this.groupBoxIn_MAI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_MAI)).EndInit();
            this.groupBoxOut_MAI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_MAI)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop_MAI;
        private System.Windows.Forms.Button buttonHelp_MAI;
        private System.Windows.Forms.Button buttonSaveFile_MAI;
        private System.Windows.Forms.Button buttonDone_MAI;
        private System.Windows.Forms.Button buttonOpenFile_MAI;
        private System.Windows.Forms.GroupBox groupBoxTask_MAI;
        private System.Windows.Forms.TextBox textBoxTask_MAI;
        private System.Windows.Forms.SplitContainer splitContainerMain_MAI;
        private System.Windows.Forms.GroupBox groupBoxIn_MAI;
        private System.Windows.Forms.DataGridView dataGridViewIn_MAI;
        private System.Windows.Forms.GroupBox groupBoxOut_MAI;
        private System.Windows.Forms.DataGridView dataGridViewOut_MAI;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_MAI;
        private System.Windows.Forms.ToolTip toolTipButton_MAI;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_MAI;
    }
}
