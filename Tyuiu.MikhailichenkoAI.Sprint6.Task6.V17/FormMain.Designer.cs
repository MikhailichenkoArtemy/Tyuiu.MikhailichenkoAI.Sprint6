namespace Tyuiu.MikhailichenkoAI.Sprint6.Task6.V17
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
            this.buttonDone_MAI = new System.Windows.Forms.Button();
            this.buttonOpenFile_MAI = new System.Windows.Forms.Button();
            this.groupBoxTask_MAI = new System.Windows.Forms.GroupBox();
            this.textBoxTask_MAI = new System.Windows.Forms.TextBox();
            this.splitContainerMain_MAI = new System.Windows.Forms.SplitContainer();
            this.groupBoxIn_MAI = new System.Windows.Forms.GroupBox();
            this.textBoxIn_MAI = new System.Windows.Forms.TextBox();
            this.groupBoxOut_MAI = new System.Windows.Forms.GroupBox();
            this.textBoxOut_MAI = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_MAI = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_MAI = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop_MAI.SuspendLayout();
            this.groupBoxTask_MAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain_MAI)).BeginInit();
            this.splitContainerMain_MAI.Panel1.SuspendLayout();
            this.splitContainerMain_MAI.Panel2.SuspendLayout();
            this.splitContainerMain_MAI.SuspendLayout();
            this.groupBoxIn_MAI.SuspendLayout();
            this.groupBoxOut_MAI.SuspendLayout();
            this.SuspendLayout();

            this.panelTop_MAI.Controls.Add(this.buttonHelp_MAI);
            this.panelTop_MAI.Controls.Add(this.buttonDone_MAI);
            this.panelTop_MAI.Controls.Add(this.buttonOpenFile_MAI);
            this.panelTop_MAI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_MAI.Location = new System.Drawing.Point(0, 0);
            this.panelTop_MAI.Name = "panelTop_MAI";
            this.panelTop_MAI.Size = new System.Drawing.Size(884, 58);
            this.panelTop_MAI.TabIndex = 0;

            this.buttonOpenFile_MAI.Location = new System.Drawing.Point(12, 6);
            this.buttonOpenFile_MAI.Name = "buttonOpenFile_MAI";
            this.buttonOpenFile_MAI.Size = new System.Drawing.Size(55, 46);
            this.buttonOpenFile_MAI.TabIndex = 0;
            this.buttonOpenFile_MAI.Text = "📂";
            this.toolTip_MAI.SetToolTip(this.buttonOpenFile_MAI, "Выберите нужный файл для обработки");
            this.buttonOpenFile_MAI.UseVisualStyleBackColor = true;
            this.buttonOpenFile_MAI.Click += new System.EventHandler(this.buttonOpenFile_MAI_Click);

            this.buttonDone_MAI.Enabled = false;
            this.buttonDone_MAI.Location = new System.Drawing.Point(75, 6);
            this.buttonDone_MAI.Name = "buttonDone_MAI";
            this.buttonDone_MAI.Size = new System.Drawing.Size(55, 46);
            this.buttonDone_MAI.TabIndex = 1;
            this.buttonDone_MAI.Text = "▶";
            this.toolTip_MAI.SetToolTip(this.buttonDone_MAI, "Выполнить обработку файла");
            this.buttonDone_MAI.UseVisualStyleBackColor = true;
            this.buttonDone_MAI.Click += new System.EventHandler(this.buttonDone_MAI_Click);

            this.buttonHelp_MAI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_MAI.Location = new System.Drawing.Point(817, 6);
            this.buttonHelp_MAI.Name = "buttonHelp_MAI";
            this.buttonHelp_MAI.Size = new System.Drawing.Size(55, 46);
            this.buttonHelp_MAI.TabIndex = 2;
            this.buttonHelp_MAI.Text = "❓";
            this.toolTip_MAI.SetToolTip(this.buttonHelp_MAI, "Справка о программе");
            this.buttonHelp_MAI.UseVisualStyleBackColor = true;
            this.buttonHelp_MAI.Click += new System.EventHandler(this.buttonHelp_MAI_Click);

            this.groupBoxTask_MAI.Controls.Add(this.textBoxTask_MAI);
            this.groupBoxTask_MAI.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTask_MAI.Location = new System.Drawing.Point(0, 58);
            this.groupBoxTask_MAI.Name = "groupBoxTask_MAI";
            this.groupBoxTask_MAI.Size = new System.Drawing.Size(884, 75);
            this.groupBoxTask_MAI.TabIndex = 1;
            this.groupBoxTask_MAI.TabStop = false;
            this.groupBoxTask_MAI.Text = "Условие:";

            this.textBoxTask_MAI.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_MAI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_MAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_MAI.Font = new System.Drawing.Font("Consolas", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTask_MAI.Location = new System.Drawing.Point(3, 19);
            this.textBoxTask_MAI.Multiline = true;
            this.textBoxTask_MAI.Name = "textBoxTask_MAI";
            this.textBoxTask_MAI.ReadOnly = true;
            this.textBoxTask_MAI.Size = new System.Drawing.Size(878, 53);
            this.textBoxTask_MAI.TabIndex = 0;
            this.textBoxTask_MAI.TabStop = false;
            this.textBoxTask_MAI.Text = "Дан файл InPutFileTask6V17.txt который может находится в любом месте на диске. Загрузить файл в textBoxIn через openFileDialog. Вывести третье слово каждой строки в результирующею строку и вывести ее в textBoxOut.";

            this.splitContainerMain_MAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain_MAI.Location = new System.Drawing.Point(0, 133);
            this.splitContainerMain_MAI.Name = "splitContainerMain_MAI";
            this.splitContainerMain_MAI.Panel1.Controls.Add(this.groupBoxIn_MAI);
            this.splitContainerMain_MAI.Panel2.Controls.Add(this.groupBoxOut_MAI);
            this.splitContainerMain_MAI.Size = new System.Drawing.Size(884, 378);
            this.splitContainerMain_MAI.SplitterDistance = 440;
            this.splitContainerMain_MAI.TabIndex = 2;

            this.groupBoxIn_MAI.Controls.Add(this.textBoxIn_MAI);
            this.groupBoxIn_MAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxIn_MAI.Location = new System.Drawing.Point(0, 0);
            this.groupBoxIn_MAI.Name = "groupBoxIn_MAI";
            this.groupBoxIn_MAI.Size = new System.Drawing.Size(440, 378);
            this.groupBoxIn_MAI.TabIndex = 0;
            this.groupBoxIn_MAI.TabStop = false;
            this.groupBoxIn_MAI.Text = "Ввод:";

            this.textBoxIn_MAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIn_MAI.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIn_MAI.Location = new System.Drawing.Point(3, 19);
            this.textBoxIn_MAI.Multiline = true;
            this.textBoxIn_MAI.Name = "textBoxIn_MAI";
            this.textBoxIn_MAI.ReadOnly = true;
            this.textBoxIn_MAI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIn_MAI.Size = new System.Drawing.Size(434, 356);
            this.textBoxIn_MAI.TabIndex = 0;

            this.groupBoxOut_MAI.Controls.Add(this.textBoxOut_MAI);
            this.groupBoxOut_MAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOut_MAI.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOut_MAI.Name = "groupBoxOut_MAI";
            this.groupBoxOut_MAI.Size = new System.Drawing.Size(440, 378);
            this.groupBoxOut_MAI.TabIndex = 0;
            this.groupBoxOut_MAI.TabStop = false;
            this.groupBoxOut_MAI.Text = "Вывод:";

            this.textBoxOut_MAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOut_MAI.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxOut_MAI.Location = new System.Drawing.Point(3, 19);
            this.textBoxOut_MAI.Multiline = true;
            this.textBoxOut_MAI.Name = "textBoxOut_MAI";
            this.textBoxOut_MAI.ReadOnly = true;
            this.textBoxOut_MAI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut_MAI.Size = new System.Drawing.Size(434, 356);
            this.textBoxOut_MAI.TabIndex = 0;

            this.openFileDialogTask_MAI.FileName = "InPutFileTask6V17.txt";

            this.toolTip_MAI.IsBalloon = true;
            this.toolTip_MAI.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_MAI.ToolTipTitle = "Подсказка";

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.splitContainerMain_MAI);
            this.Controls.Add(this.groupBoxTask_MAI);
            this.Controls.Add(this.panelTop_MAI);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 17 | Михайличенко А. И.";
            this.panelTop_MAI.ResumeLayout(false);
            this.groupBoxTask_MAI.ResumeLayout(false);
            this.groupBoxTask_MAI.PerformLayout();
            this.splitContainerMain_MAI.Panel1.ResumeLayout(false);
            this.splitContainerMain_MAI.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain_MAI)).EndInit();
            this.splitContainerMain_MAI.ResumeLayout(false);
            this.groupBoxIn_MAI.ResumeLayout(false);
            this.groupBoxIn_MAI.PerformLayout();
            this.groupBoxOut_MAI.ResumeLayout(false);
            this.groupBoxOut_MAI.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop_MAI;
        private System.Windows.Forms.Button buttonHelp_MAI;
        private System.Windows.Forms.Button buttonDone_MAI;
        private System.Windows.Forms.Button buttonOpenFile_MAI;
        private System.Windows.Forms.GroupBox groupBoxTask_MAI;
        private System.Windows.Forms.TextBox textBoxTask_MAI;
        private System.Windows.Forms.SplitContainer splitContainerMain_MAI;
        private System.Windows.Forms.GroupBox groupBoxIn_MAI;
        private System.Windows.Forms.TextBox textBoxIn_MAI;
        private System.Windows.Forms.GroupBox groupBoxOut_MAI;
        private System.Windows.Forms.TextBox textBoxOut_MAI;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_MAI;
        private System.Windows.Forms.ToolTip toolTip_MAI;
    }
}
