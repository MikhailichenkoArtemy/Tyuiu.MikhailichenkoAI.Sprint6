namespace Tyuiu.MikhailichenkoAI.Sprint6.Task6.V17
{
    partial class FormAbout
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
            this.pictureBoxPhoto_MAI = new System.Windows.Forms.PictureBox();
            this.labelInfo_MAI = new System.Windows.Forms.Label();
            this.buttonOk_MAI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto_MAI)).BeginInit();
            this.SuspendLayout();

            this.pictureBoxPhoto_MAI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPhoto_MAI.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxPhoto_MAI.Name = "pictureBoxPhoto_MAI";
            this.pictureBoxPhoto_MAI.Size = new System.Drawing.Size(120, 150);
            this.pictureBoxPhoto_MAI.TabIndex = 0;
            this.pictureBoxPhoto_MAI.TabStop = false;

            this.labelInfo_MAI.AutoSize = true;
            this.labelInfo_MAI.Location = new System.Drawing.Point(145, 15);
            this.labelInfo_MAI.Name = "labelInfo_MAI";
            this.labelInfo_MAI.Size = new System.Drawing.Size(300, 120);
            this.labelInfo_MAI.TabIndex = 1;
            this.labelInfo_MAI.Text = "Разработчик: Михайличенко А. И.\r\nГруппа: ИИПБ26-1\r\n\r\nПрограмма разработана в рамках изучения языка C#\r\n\r\nТюменский индустриальный университет (с) 2026\r\nВысшая школа цифровых технологий (с) 2026\r\n\r\nВнутреннее имя: Tyuiu.MikhailichenkoAI.Sprint6.Task6.V17";

            this.buttonOk_MAI.Location = new System.Drawing.Point(390, 155);
            this.buttonOk_MAI.Name = "buttonOk_MAI";
            this.buttonOk_MAI.Size = new System.Drawing.Size(85, 28);
            this.buttonOk_MAI.TabIndex = 2;
            this.buttonOk_MAI.Text = "Ок";
            this.buttonOk_MAI.UseVisualStyleBackColor = true;
            this.buttonOk_MAI.Click += new System.EventHandler(this.buttonOk_MAI_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 195);
            this.Controls.Add(this.buttonOk_MAI);
            this.Controls.Add(this.labelInfo_MAI);
            this.Controls.Add(this.pictureBoxPhoto_MAI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto_MAI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox pictureBoxPhoto_MAI;
        private System.Windows.Forms.Label labelInfo_MAI;
        private System.Windows.Forms.Button buttonOk_MAI;
    }
}
