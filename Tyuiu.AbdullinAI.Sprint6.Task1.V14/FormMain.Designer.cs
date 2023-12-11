namespace Tyuiu.AbdullinAI.Sprint6.Task1.V14
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
            this.groupBoxTask_AAI = new System.Windows.Forms.GroupBox();
            this.labelTask_AAI = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxInPutData_AAI = new System.Windows.Forms.GroupBox();
            this.labelStopValue = new System.Windows.Forms.Label();
            this.labelStartValue_AAI = new System.Windows.Forms.Label();
            this.textBoxStopValue_AAI = new System.Windows.Forms.TextBox();
            this.textBoxStartValue_AAI = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_AAI = new System.Windows.Forms.GroupBox();
            this.labelResult_AAI = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonReference_AAI = new System.Windows.Forms.Button();
            this.buttonDone_AAI = new System.Windows.Forms.Button();
            this.groupBoxTask_AAI.SuspendLayout();
            this.groupBoxInPutData_AAI.SuspendLayout();
            this.groupBoxOutPutData_AAI.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_AAI
            // 
            this.groupBoxTask_AAI.Controls.Add(this.labelTask_AAI);
            this.groupBoxTask_AAI.Controls.Add(this.label1);
            this.groupBoxTask_AAI.Location = new System.Drawing.Point(22, 28);
            this.groupBoxTask_AAI.Name = "groupBoxTask_AAI";
            this.groupBoxTask_AAI.Size = new System.Drawing.Size(435, 240);
            this.groupBoxTask_AAI.TabIndex = 0;
            this.groupBoxTask_AAI.TabStop = false;
            this.groupBoxTask_AAI.Text = "Условие";
            // 
            // labelTask_AAI
            // 
            this.labelTask_AAI.AutoSize = true;
            this.labelTask_AAI.Location = new System.Drawing.Point(6, 16);
            this.labelTask_AAI.Name = "labelTask_AAI";
            this.labelTask_AAI.Size = new System.Drawing.Size(269, 39);
            this.labelTask_AAI.TabIndex = 1;
            this.labelTask_AAI.Text = "Протабулировать функцию F(X) = (2x+6)/(cosx+x) - 3 \r\nна заданном диапазоне [-5;5]" +
    ". \r\nРезультат вывести в виде таблицы.\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // groupBoxInPutData_AAI
            // 
            this.groupBoxInPutData_AAI.Controls.Add(this.labelStopValue);
            this.groupBoxInPutData_AAI.Controls.Add(this.labelStartValue_AAI);
            this.groupBoxInPutData_AAI.Controls.Add(this.textBoxStopValue_AAI);
            this.groupBoxInPutData_AAI.Controls.Add(this.textBoxStartValue_AAI);
            this.groupBoxInPutData_AAI.Location = new System.Drawing.Point(22, 274);
            this.groupBoxInPutData_AAI.Name = "groupBoxInPutData_AAI";
            this.groupBoxInPutData_AAI.Size = new System.Drawing.Size(200, 74);
            this.groupBoxInPutData_AAI.TabIndex = 1;
            this.groupBoxInPutData_AAI.TabStop = false;
            this.groupBoxInPutData_AAI.Text = "Ввод данных";
            // 
            // labelStopValue
            // 
            this.labelStopValue.AutoSize = true;
            this.labelStopValue.Location = new System.Drawing.Point(97, 25);
            this.labelStopValue.Name = "labelStopValue";
            this.labelStopValue.Size = new System.Drawing.Size(69, 13);
            this.labelStopValue.TabIndex = 1;
            this.labelStopValue.Text = "Конец шага:";
            // 
            // labelStartValue_AAI
            // 
            this.labelStartValue_AAI.AutoSize = true;
            this.labelStartValue_AAI.Location = new System.Drawing.Point(6, 25);
            this.labelStartValue_AAI.Name = "labelStartValue_AAI";
            this.labelStartValue_AAI.Size = new System.Drawing.Size(67, 13);
            this.labelStartValue_AAI.TabIndex = 1;
            this.labelStartValue_AAI.Text = "Старт шага:";
            // 
            // textBoxStopValue_AAI
            // 
            this.textBoxStopValue_AAI.Location = new System.Drawing.Point(100, 43);
            this.textBoxStopValue_AAI.Name = "textBoxStopValue_AAI";
            this.textBoxStopValue_AAI.Size = new System.Drawing.Size(94, 20);
            this.textBoxStopValue_AAI.TabIndex = 0;
            // 
            // textBoxStartValue_AAI
            // 
            this.textBoxStartValue_AAI.Location = new System.Drawing.Point(9, 43);
            this.textBoxStartValue_AAI.Name = "textBoxStartValue_AAI";
            this.textBoxStartValue_AAI.Size = new System.Drawing.Size(85, 20);
            this.textBoxStartValue_AAI.TabIndex = 0;
            // 
            // groupBoxOutPutData_AAI
            // 
            this.groupBoxOutPutData_AAI.Controls.Add(this.textBoxResult);
            this.groupBoxOutPutData_AAI.Controls.Add(this.labelResult_AAI);
            this.groupBoxOutPutData_AAI.Location = new System.Drawing.Point(463, 28);
            this.groupBoxOutPutData_AAI.Name = "groupBoxOutPutData_AAI";
            this.groupBoxOutPutData_AAI.Size = new System.Drawing.Size(244, 314);
            this.groupBoxOutPutData_AAI.TabIndex = 3;
            this.groupBoxOutPutData_AAI.TabStop = false;
            this.groupBoxOutPutData_AAI.Text = "Вывод данных";
            // 
            // labelResult_AAI
            // 
            this.labelResult_AAI.AutoSize = true;
            this.labelResult_AAI.Location = new System.Drawing.Point(7, 20);
            this.labelResult_AAI.Name = "labelResult_AAI";
            this.labelResult_AAI.Size = new System.Drawing.Size(62, 13);
            this.labelResult_AAI.TabIndex = 0;
            this.labelResult_AAI.Text = "Результат:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(6, 34);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(232, 274);
            this.textBoxResult.TabIndex = 1;
            // 
            // buttonReference_AAI
            // 
            this.buttonReference_AAI.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonReference_AAI.Location = new System.Drawing.Point(239, 274);
            this.buttonReference_AAI.Name = "buttonReference_AAI";
            this.buttonReference_AAI.Size = new System.Drawing.Size(83, 73);
            this.buttonReference_AAI.TabIndex = 4;
            this.buttonReference_AAI.Text = "Справка";
            this.buttonReference_AAI.UseVisualStyleBackColor = false;
            this.buttonReference_AAI.Click += new System.EventHandler(this.buttonReference_AAI_Click);
            // 
            // buttonDone_AAI
            // 
            this.buttonDone_AAI.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonDone_AAI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDone_AAI.Location = new System.Drawing.Point(328, 274);
            this.buttonDone_AAI.Name = "buttonDone_AAI";
            this.buttonDone_AAI.Size = new System.Drawing.Size(129, 74);
            this.buttonDone_AAI.TabIndex = 5;
            this.buttonDone_AAI.Text = "Выполнить";
            this.buttonDone_AAI.UseVisualStyleBackColor = false;
            this.buttonDone_AAI.Click += new System.EventHandler(this.buttonDone_AAI_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 354);
            this.Controls.Add(this.buttonDone_AAI);
            this.Controls.Add(this.buttonReference_AAI);
            this.Controls.Add(this.groupBoxOutPutData_AAI);
            this.Controls.Add(this.groupBoxInPutData_AAI);
            this.Controls.Add(this.groupBoxTask_AAI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6  | Таск 1 | Вариант 14 | Абдуллин А.И. ";
            this.groupBoxTask_AAI.ResumeLayout(false);
            this.groupBoxTask_AAI.PerformLayout();
            this.groupBoxInPutData_AAI.ResumeLayout(false);
            this.groupBoxInPutData_AAI.PerformLayout();
            this.groupBoxOutPutData_AAI.ResumeLayout(false);
            this.groupBoxOutPutData_AAI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_AAI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTask_AAI;
        private System.Windows.Forms.GroupBox groupBoxInPutData_AAI;
        private System.Windows.Forms.Label labelStopValue;
        private System.Windows.Forms.Label labelStartValue_AAI;
        private System.Windows.Forms.TextBox textBoxStopValue_AAI;
        private System.Windows.Forms.TextBox textBoxStartValue_AAI;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_AAI;
        private System.Windows.Forms.Label labelResult_AAI;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonReference_AAI;
        private System.Windows.Forms.Button buttonDone_AAI;
    }
}

