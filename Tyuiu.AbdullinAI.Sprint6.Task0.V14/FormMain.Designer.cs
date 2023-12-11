namespace Tyuiu.AbdullinAI.Sprint6.Task0.V14
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_AAI = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_AAI = new System.Windows.Forms.PictureBox();
            this.textBoxTask_AAI = new System.Windows.Forms.TextBox();
            this.buttonDone_AAI = new System.Windows.Forms.Button();
            this.groupBoxInPutData_AAI = new System.Windows.Forms.GroupBox();
            this.labelVarX_AAI = new System.Windows.Forms.Label();
            this.textBoxVarX_AAI = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_AAI = new System.Windows.Forms.GroupBox();
            this.labelResult_AAI = new System.Windows.Forms.Label();
            this.textBoxResult_AAI = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxTask_AAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_AAI)).BeginInit();
            this.groupBoxInPutData_AAI.SuspendLayout();
            this.groupBoxOutPutData_AAI.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_AAI
            // 
            this.groupBoxTask_AAI.Controls.Add(this.pictureBoxFormula_AAI);
            this.groupBoxTask_AAI.Controls.Add(this.textBoxTask_AAI);
            this.groupBoxTask_AAI.Location = new System.Drawing.Point(21, 41);
            this.groupBoxTask_AAI.Name = "groupBoxTask_AAI";
            this.groupBoxTask_AAI.Size = new System.Drawing.Size(450, 215);
            this.groupBoxTask_AAI.TabIndex = 0;
            this.groupBoxTask_AAI.TabStop = false;
            this.groupBoxTask_AAI.Text = "Условие";
            // 
            // pictureBoxFormula_AAI
            // 
            this.pictureBoxFormula_AAI.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_AAI.Image")));
            this.pictureBoxFormula_AAI.Location = new System.Drawing.Point(309, 20);
            this.pictureBoxFormula_AAI.Name = "pictureBoxFormula_AAI";
            this.pictureBoxFormula_AAI.Size = new System.Drawing.Size(121, 60);
            this.pictureBoxFormula_AAI.TabIndex = 1;
            this.pictureBoxFormula_AAI.TabStop = false;
            // 
            // textBoxTask_AAI
            // 
            this.textBoxTask_AAI.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxTask_AAI.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBoxTask_AAI.Location = new System.Drawing.Point(10, 20);
            this.textBoxTask_AAI.Multiline = true;
            this.textBoxTask_AAI.Name = "textBoxTask_AAI";
            this.textBoxTask_AAI.Size = new System.Drawing.Size(279, 189);
            this.textBoxTask_AAI.TabIndex = 0;
            this.textBoxTask_AAI.Text = "Дано выражение вычислить его значение при x = 3.";
            // 
            // buttonDone_AAI
            // 
            this.buttonDone_AAI.Location = new System.Drawing.Point(361, 368);
            this.buttonDone_AAI.Name = "buttonDone_AAI";
            this.buttonDone_AAI.Size = new System.Drawing.Size(110, 35);
            this.buttonDone_AAI.TabIndex = 0;
            this.buttonDone_AAI.Text = "Выполнить";
            this.buttonDone_AAI.UseVisualStyleBackColor = true;
            this.buttonDone_AAI.Click += new System.EventHandler(this.buttonDone_AAI_Click);
            // 
            // groupBoxInPutData_AAI
            // 
            this.groupBoxInPutData_AAI.Controls.Add(this.labelVarX_AAI);
            this.groupBoxInPutData_AAI.Controls.Add(this.textBoxVarX_AAI);
            this.groupBoxInPutData_AAI.Location = new System.Drawing.Point(21, 262);
            this.groupBoxInPutData_AAI.Name = "groupBoxInPutData_AAI";
            this.groupBoxInPutData_AAI.Size = new System.Drawing.Size(244, 100);
            this.groupBoxInPutData_AAI.TabIndex = 1;
            this.groupBoxInPutData_AAI.TabStop = false;
            this.groupBoxInPutData_AAI.Text = "Ввод данных";
            // 
            // labelVarX_AAI
            // 
            this.labelVarX_AAI.AutoSize = true;
            this.labelVarX_AAI.Location = new System.Drawing.Point(7, 20);
            this.labelVarX_AAI.Name = "labelVarX_AAI";
            this.labelVarX_AAI.Size = new System.Drawing.Size(84, 13);
            this.labelVarX_AAI.TabIndex = 1;
            this.labelVarX_AAI.Text = "Переменная X:";
            // 
            // textBoxVarX_AAI
            // 
            this.textBoxVarX_AAI.Location = new System.Drawing.Point(10, 36);
            this.textBoxVarX_AAI.Name = "textBoxVarX_AAI";
            this.textBoxVarX_AAI.Size = new System.Drawing.Size(110, 20);
            this.textBoxVarX_AAI.TabIndex = 0;
            this.textBoxVarX_AAI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_AAI_KeyPress);
            // 
            // groupBoxOutPutData_AAI
            // 
            this.groupBoxOutPutData_AAI.Controls.Add(this.labelResult_AAI);
            this.groupBoxOutPutData_AAI.Controls.Add(this.textBoxResult_AAI);
            this.groupBoxOutPutData_AAI.Location = new System.Drawing.Point(271, 262);
            this.groupBoxOutPutData_AAI.Name = "groupBoxOutPutData_AAI";
            this.groupBoxOutPutData_AAI.Size = new System.Drawing.Size(200, 100);
            this.groupBoxOutPutData_AAI.TabIndex = 2;
            this.groupBoxOutPutData_AAI.TabStop = false;
            this.groupBoxOutPutData_AAI.Text = "Вывод данных";
            // 
            // labelResult_AAI
            // 
            this.labelResult_AAI.AutoSize = true;
            this.labelResult_AAI.Location = new System.Drawing.Point(6, 20);
            this.labelResult_AAI.Name = "labelResult_AAI";
            this.labelResult_AAI.Size = new System.Drawing.Size(62, 13);
            this.labelResult_AAI.TabIndex = 1;
            this.labelResult_AAI.Text = "Результат:";
            // 
            // textBoxResult_AAI
            // 
            this.textBoxResult_AAI.Location = new System.Drawing.Point(9, 36);
            this.textBoxResult_AAI.Name = "textBoxResult_AAI";
            this.textBoxResult_AAI.ReadOnly = true;
            this.textBoxResult_AAI.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_AAI.TabIndex = 0;
            // 
            // buttonHelp
            // 
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Location = new System.Drawing.Point(312, 368);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(43, 35);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 414);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.groupBoxOutPutData_AAI);
            this.Controls.Add(this.groupBoxInPutData_AAI);
            this.Controls.Add(this.buttonDone_AAI);
            this.Controls.Add(this.groupBoxTask_AAI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6  | Таск 0 | Вариант 14 | Абдуллин А.И. ";
            this.groupBoxTask_AAI.ResumeLayout(false);
            this.groupBoxTask_AAI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_AAI)).EndInit();
            this.groupBoxInPutData_AAI.ResumeLayout(false);
            this.groupBoxInPutData_AAI.PerformLayout();
            this.groupBoxOutPutData_AAI.ResumeLayout(false);
            this.groupBoxOutPutData_AAI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_AAI;
        private System.Windows.Forms.Button buttonDone_AAI;
        private System.Windows.Forms.GroupBox groupBoxInPutData_AAI;
        private System.Windows.Forms.Label labelVarX_AAI;
        private System.Windows.Forms.TextBox textBoxVarX_AAI;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_AAI;
        private System.Windows.Forms.Label labelResult_AAI;
        private System.Windows.Forms.TextBox textBoxResult_AAI;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.PictureBox pictureBoxFormula_AAI;
        private System.Windows.Forms.TextBox textBoxTask_AAI;
    }
}

