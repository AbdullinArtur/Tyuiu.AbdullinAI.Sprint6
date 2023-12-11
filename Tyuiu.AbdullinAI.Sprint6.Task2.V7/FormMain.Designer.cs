namespace Tyuiu.AbdullinAI.Sprint6.Task2.V7
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonDone_AAI = new System.Windows.Forms.Button();
            this.buttonReference_AAI = new System.Windows.Forms.Button();
            this.groupBoxOutPutData_AAI = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction_AAI = new System.Windows.Forms.DataGridView();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFUnction_AAI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelResult_AAI = new System.Windows.Forms.Label();
            this.groupBoxInPutData_AAI = new System.Windows.Forms.GroupBox();
            this.labelStopValue = new System.Windows.Forms.Label();
            this.labelStartValue_AAI = new System.Windows.Forms.Label();
            this.textBoxStopValue_AAI = new System.Windows.Forms.TextBox();
            this.textBoxStartValue_AAI = new System.Windows.Forms.TextBox();
            this.groupBoxTask_AAI = new System.Windows.Forms.GroupBox();
            this.labelTask_AAI = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxOutPutData_AAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_AAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFUnction_AAI)).BeginInit();
            this.groupBoxInPutData_AAI.SuspendLayout();
            this.groupBoxTask_AAI.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDone_AAI
            // 
            this.buttonDone_AAI.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonDone_AAI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDone_AAI.Location = new System.Drawing.Point(297, 248);
            this.buttonDone_AAI.Name = "buttonDone_AAI";
            this.buttonDone_AAI.Size = new System.Drawing.Size(129, 74);
            this.buttonDone_AAI.TabIndex = 10;
            this.buttonDone_AAI.Text = "Выполнить";
            this.buttonDone_AAI.UseVisualStyleBackColor = false;
            this.buttonDone_AAI.Click += new System.EventHandler(this.buttonDone_AAI_Click);
            this.buttonDone_AAI.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_AAI_MouseDown);
            this.buttonDone_AAI.MouseEnter += new System.EventHandler(this.buttonDone_AAI_MouseEnter);
            this.buttonDone_AAI.MouseLeave += new System.EventHandler(this.buttonDone_AAI_MouseLeave);
            // 
            // buttonReference_AAI
            // 
            this.buttonReference_AAI.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonReference_AAI.Location = new System.Drawing.Point(208, 249);
            this.buttonReference_AAI.Name = "buttonReference_AAI";
            this.buttonReference_AAI.Size = new System.Drawing.Size(83, 73);
            this.buttonReference_AAI.TabIndex = 9;
            this.buttonReference_AAI.Text = "Справка";
            this.buttonReference_AAI.UseVisualStyleBackColor = false;
            this.buttonReference_AAI.Click += new System.EventHandler(this.buttonReference_AAI_Click);
            // 
            // groupBoxOutPutData_AAI
            // 
            this.groupBoxOutPutData_AAI.Controls.Add(this.dataGridViewFunction_AAI);
            this.groupBoxOutPutData_AAI.Controls.Add(this.chartFUnction_AAI);
            this.groupBoxOutPutData_AAI.Controls.Add(this.labelResult_AAI);
            this.groupBoxOutPutData_AAI.Location = new System.Drawing.Point(443, 2);
            this.groupBoxOutPutData_AAI.Name = "groupBoxOutPutData_AAI";
            this.groupBoxOutPutData_AAI.Size = new System.Drawing.Size(477, 328);
            this.groupBoxOutPutData_AAI.TabIndex = 8;
            this.groupBoxOutPutData_AAI.TabStop = false;
            this.groupBoxOutPutData_AAI.Text = "Вывод данных";
            // 
            // dataGridViewFunction_AAI
            // 
            this.dataGridViewFunction_AAI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_AAI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnF});
            this.dataGridViewFunction_AAI.Location = new System.Drawing.Point(6, 30);
            this.dataGridViewFunction_AAI.Name = "dataGridViewFunction_AAI";
            this.dataGridViewFunction_AAI.ReadOnly = true;
            this.dataGridViewFunction_AAI.RowHeadersVisible = false;
            this.dataGridViewFunction_AAI.Size = new System.Drawing.Size(104, 292);
            this.dataGridViewFunction_AAI.TabIndex = 11;
            // 
            // ColumnX
            // 
            this.ColumnX.HeaderText = "X";
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.ReadOnly = true;
            this.ColumnX.Width = 50;
            // 
            // ColumnF
            // 
            this.ColumnF.HeaderText = "F(X)";
            this.ColumnF.Name = "ColumnF";
            this.ColumnF.ReadOnly = true;
            this.ColumnF.Width = 50;
            // 
            // chartFUnction_AAI
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFUnction_AAI.ChartAreas.Add(chartArea1);
            this.chartFUnction_AAI.Location = new System.Drawing.Point(116, 26);
            this.chartFUnction_AAI.Name = "chartFUnction_AAI";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            this.chartFUnction_AAI.Series.Add(series1);
            this.chartFUnction_AAI.Size = new System.Drawing.Size(355, 292);
            this.chartFUnction_AAI.TabIndex = 2;
            this.chartFUnction_AAI.Text = "chart1";
            // 
            // labelResult_AAI
            // 
            this.labelResult_AAI.AutoSize = true;
            this.labelResult_AAI.Location = new System.Drawing.Point(6, 12);
            this.labelResult_AAI.Name = "labelResult_AAI";
            this.labelResult_AAI.Size = new System.Drawing.Size(62, 13);
            this.labelResult_AAI.TabIndex = 0;
            this.labelResult_AAI.Text = "Результат:";
            // 
            // groupBoxInPutData_AAI
            // 
            this.groupBoxInPutData_AAI.Controls.Add(this.labelStopValue);
            this.groupBoxInPutData_AAI.Controls.Add(this.labelStartValue_AAI);
            this.groupBoxInPutData_AAI.Controls.Add(this.textBoxStopValue_AAI);
            this.groupBoxInPutData_AAI.Controls.Add(this.textBoxStartValue_AAI);
            this.groupBoxInPutData_AAI.Location = new System.Drawing.Point(2, 248);
            this.groupBoxInPutData_AAI.Name = "groupBoxInPutData_AAI";
            this.groupBoxInPutData_AAI.Size = new System.Drawing.Size(200, 74);
            this.groupBoxInPutData_AAI.TabIndex = 7;
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
            // groupBoxTask_AAI
            // 
            this.groupBoxTask_AAI.Controls.Add(this.labelTask_AAI);
            this.groupBoxTask_AAI.Controls.Add(this.label1);
            this.groupBoxTask_AAI.Location = new System.Drawing.Point(2, 2);
            this.groupBoxTask_AAI.Name = "groupBoxTask_AAI";
            this.groupBoxTask_AAI.Size = new System.Drawing.Size(435, 240);
            this.groupBoxTask_AAI.TabIndex = 6;
            this.groupBoxTask_AAI.TabStop = false;
            this.groupBoxTask_AAI.Text = "Условие";
            // 
            // labelTask_AAI
            // 
            this.labelTask_AAI.AutoSize = true;
            this.labelTask_AAI.Location = new System.Drawing.Point(6, 16);
            this.labelTask_AAI.Name = "labelTask_AAI";
            this.labelTask_AAI.Size = new System.Drawing.Size(295, 39);
            this.labelTask_AAI.TabIndex = 1;
            this.labelTask_AAI.Text = "Протабулировать функцию F(X) = 3x+ 2 - ((2x-x)/(cosx +1)) \r\nна заданном диапазоне" +
    " [-5;5]. \r\nРезультат вывести в виде таблицы.\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 332);
            this.Controls.Add(this.buttonDone_AAI);
            this.Controls.Add(this.buttonReference_AAI);
            this.Controls.Add(this.groupBoxOutPutData_AAI);
            this.Controls.Add(this.groupBoxInPutData_AAI);
            this.Controls.Add(this.groupBoxTask_AAI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6  | Таск 2 | Вариант 7 | Абдуллин А.И. ";
            this.groupBoxOutPutData_AAI.ResumeLayout(false);
            this.groupBoxOutPutData_AAI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_AAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFUnction_AAI)).EndInit();
            this.groupBoxInPutData_AAI.ResumeLayout(false);
            this.groupBoxInPutData_AAI.PerformLayout();
            this.groupBoxTask_AAI.ResumeLayout(false);
            this.groupBoxTask_AAI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_AAI;
        private System.Windows.Forms.Button buttonReference_AAI;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_AAI;
        private System.Windows.Forms.Label labelResult_AAI;
        private System.Windows.Forms.GroupBox groupBoxInPutData_AAI;
        private System.Windows.Forms.Label labelStopValue;
        private System.Windows.Forms.Label labelStartValue_AAI;
        private System.Windows.Forms.TextBox textBoxStopValue_AAI;
        private System.Windows.Forms.TextBox textBoxStartValue_AAI;
        private System.Windows.Forms.GroupBox groupBoxTask_AAI;
        private System.Windows.Forms.Label labelTask_AAI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFUnction_AAI;
        private System.Windows.Forms.DataGridView dataGridViewFunction_AAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnF;
    }
}

