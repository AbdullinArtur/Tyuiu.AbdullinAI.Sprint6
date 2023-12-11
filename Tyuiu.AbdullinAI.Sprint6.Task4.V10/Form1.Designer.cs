namespace Tyuiu.AbdullinAI.Sprint6.Task4.V10
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxInPutData_AAI = new System.Windows.Forms.GroupBox();
            this.textBoxStopStep_AAI = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_AAI = new System.Windows.Forms.TextBox();
            this.labelStopStep_AAI = new System.Windows.Forms.Label();
            this.labelStartStep_AAI = new System.Windows.Forms.Label();
            this.groupBoxCondition_AAI = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_AAI = new System.Windows.Forms.TextBox();
            this.buttonDone_AAI = new System.Windows.Forms.Button();
            this.buttonSave_AAI = new System.Windows.Forms.Button();
            this.buttonReference_AAI = new System.Windows.Forms.Button();
            this.groupBoxOutPutData_AAI = new System.Windows.Forms.GroupBox();
            this.textBoxResult_AAI = new System.Windows.Forms.TextBox();
            this.chartFunction_AAI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxInPutData_AAI.SuspendLayout();
            this.groupBoxCondition_AAI.SuspendLayout();
            this.groupBoxOutPutData_AAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_AAI)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInPutData_AAI
            // 
            this.groupBoxInPutData_AAI.Controls.Add(this.textBoxStopStep_AAI);
            this.groupBoxInPutData_AAI.Controls.Add(this.textBoxStartStep_AAI);
            this.groupBoxInPutData_AAI.Controls.Add(this.labelStopStep_AAI);
            this.groupBoxInPutData_AAI.Controls.Add(this.labelStartStep_AAI);
            this.groupBoxInPutData_AAI.Location = new System.Drawing.Point(463, 12);
            this.groupBoxInPutData_AAI.Name = "groupBoxInPutData_AAI";
            this.groupBoxInPutData_AAI.Size = new System.Drawing.Size(209, 71);
            this.groupBoxInPutData_AAI.TabIndex = 0;
            this.groupBoxInPutData_AAI.TabStop = false;
            this.groupBoxInPutData_AAI.Text = "Ввод данных";
            // 
            // textBoxStopStep_AAI
            // 
            this.textBoxStopStep_AAI.Location = new System.Drawing.Point(110, 32);
            this.textBoxStopStep_AAI.Name = "textBoxStopStep_AAI";
            this.textBoxStopStep_AAI.Size = new System.Drawing.Size(93, 20);
            this.textBoxStopStep_AAI.TabIndex = 3;
            // 
            // textBoxStartStep_AAI
            // 
            this.textBoxStartStep_AAI.Location = new System.Drawing.Point(10, 32);
            this.textBoxStartStep_AAI.Name = "textBoxStartStep_AAI";
            this.textBoxStartStep_AAI.Size = new System.Drawing.Size(94, 20);
            this.textBoxStartStep_AAI.TabIndex = 2;
            // 
            // labelStopStep_AAI
            // 
            this.labelStopStep_AAI.AutoSize = true;
            this.labelStopStep_AAI.Location = new System.Drawing.Point(106, 16);
            this.labelStopStep_AAI.Name = "labelStopStep_AAI";
            this.labelStopStep_AAI.Size = new System.Drawing.Size(69, 13);
            this.labelStopStep_AAI.TabIndex = 1;
            this.labelStopStep_AAI.Text = "Конец шага:";
            // 
            // labelStartStep_AAI
            // 
            this.labelStartStep_AAI.AutoSize = true;
            this.labelStartStep_AAI.Location = new System.Drawing.Point(7, 16);
            this.labelStartStep_AAI.Name = "labelStartStep_AAI";
            this.labelStartStep_AAI.Size = new System.Drawing.Size(67, 13);
            this.labelStartStep_AAI.TabIndex = 0;
            this.labelStartStep_AAI.Text = "Старт шага:";
            // 
            // groupBoxCondition_AAI
            // 
            this.groupBoxCondition_AAI.Controls.Add(this.textBoxCondition_AAI);
            this.groupBoxCondition_AAI.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_AAI.Name = "groupBoxCondition_AAI";
            this.groupBoxCondition_AAI.Size = new System.Drawing.Size(445, 71);
            this.groupBoxCondition_AAI.TabIndex = 1;
            this.groupBoxCondition_AAI.TabStop = false;
            this.groupBoxCondition_AAI.Text = "Условие:";
            // 
            // textBoxCondition_AAI
            // 
            this.textBoxCondition_AAI.Location = new System.Drawing.Point(6, 16);
            this.textBoxCondition_AAI.Multiline = true;
            this.textBoxCondition_AAI.Name = "textBoxCondition_AAI";
            this.textBoxCondition_AAI.Size = new System.Drawing.Size(424, 46);
            this.textBoxCondition_AAI.TabIndex = 0;
            this.textBoxCondition_AAI.Text = resources.GetString("textBoxCondition_AAI.Text");
            // 
            // buttonDone_AAI
            // 
            this.buttonDone_AAI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDone_AAI.Location = new System.Drawing.Point(678, 28);
            this.buttonDone_AAI.Name = "buttonDone_AAI";
            this.buttonDone_AAI.Size = new System.Drawing.Size(75, 46);
            this.buttonDone_AAI.TabIndex = 2;
            this.buttonDone_AAI.Text = "Выполнить";
            this.buttonDone_AAI.UseVisualStyleBackColor = false;
            this.buttonDone_AAI.Click += new System.EventHandler(this.buttonDone_AAI_Click);
            // 
            // buttonSave_AAI
            // 
            this.buttonSave_AAI.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSave_AAI.Location = new System.Drawing.Point(759, 28);
            this.buttonSave_AAI.Name = "buttonSave_AAI";
            this.buttonSave_AAI.Size = new System.Drawing.Size(75, 46);
            this.buttonSave_AAI.TabIndex = 3;
            this.buttonSave_AAI.Text = "Сохранить";
            this.buttonSave_AAI.UseVisualStyleBackColor = false;
            this.buttonSave_AAI.Click += new System.EventHandler(this.buttonSave_AAI_Click);
            // 
            // buttonReference_AAI
            // 
            this.buttonReference_AAI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonReference_AAI.Location = new System.Drawing.Point(928, 28);
            this.buttonReference_AAI.Name = "buttonReference_AAI";
            this.buttonReference_AAI.Size = new System.Drawing.Size(75, 46);
            this.buttonReference_AAI.TabIndex = 4;
            this.buttonReference_AAI.Text = "Справка";
            this.buttonReference_AAI.UseVisualStyleBackColor = false;
            this.buttonReference_AAI.Click += new System.EventHandler(this.buttonReference_AAI_Click);
            // 
            // groupBoxOutPutData_AAI
            // 
            this.groupBoxOutPutData_AAI.Controls.Add(this.textBoxResult_AAI);
            this.groupBoxOutPutData_AAI.Location = new System.Drawing.Point(18, 100);
            this.groupBoxOutPutData_AAI.Name = "groupBoxOutPutData_AAI";
            this.groupBoxOutPutData_AAI.Size = new System.Drawing.Size(220, 381);
            this.groupBoxOutPutData_AAI.TabIndex = 5;
            this.groupBoxOutPutData_AAI.TabStop = false;
            this.groupBoxOutPutData_AAI.Text = "Вывод:";
            // 
            // textBoxResult_AAI
            // 
            this.textBoxResult_AAI.Location = new System.Drawing.Point(7, 20);
            this.textBoxResult_AAI.Multiline = true;
            this.textBoxResult_AAI.Name = "textBoxResult_AAI";
            this.textBoxResult_AAI.ReadOnly = true;
            this.textBoxResult_AAI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_AAI.Size = new System.Drawing.Size(203, 355);
            this.textBoxResult_AAI.TabIndex = 0;
            // 
            // chartFunction_AAI
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_AAI.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_AAI.Legends.Add(legend2);
            this.chartFunction_AAI.Location = new System.Drawing.Point(253, 94);
            this.chartFunction_AAI.Name = "chartFunction_AAI";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "F(x)";
            this.chartFunction_AAI.Series.Add(series2);
            this.chartFunction_AAI.Size = new System.Drawing.Size(750, 381);
            this.chartFunction_AAI.TabIndex = 6;
            this.chartFunction_AAI.Text = "chart1";
            title2.BackColor = System.Drawing.Color.White;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.ForeColor = System.Drawing.Color.Red;
            title2.Name = "TitleF(x)";
            title2.Text = "График функции F(x) = ((5 * x + 2.5) / (Sin(x) + 3)) + 2 * x + Cos(x) ";
            title2.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Frame;
            this.chartFunction_AAI.Titles.Add(title2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 493);
            this.Controls.Add(this.chartFunction_AAI);
            this.Controls.Add(this.groupBoxOutPutData_AAI);
            this.Controls.Add(this.buttonReference_AAI);
            this.Controls.Add(this.buttonSave_AAI);
            this.Controls.Add(this.buttonDone_AAI);
            this.Controls.Add(this.groupBoxCondition_AAI);
            this.Controls.Add(this.groupBoxInPutData_AAI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1020, 39);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6  | Таск 4 | Вариант 10 | Абдуллин А.И. ";
            this.groupBoxInPutData_AAI.ResumeLayout(false);
            this.groupBoxInPutData_AAI.PerformLayout();
            this.groupBoxCondition_AAI.ResumeLayout(false);
            this.groupBoxCondition_AAI.PerformLayout();
            this.groupBoxOutPutData_AAI.ResumeLayout(false);
            this.groupBoxOutPutData_AAI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_AAI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInPutData_AAI;
        private System.Windows.Forms.Label labelStopStep_AAI;
        private System.Windows.Forms.Label labelStartStep_AAI;
        private System.Windows.Forms.TextBox textBoxStopStep_AAI;
        private System.Windows.Forms.TextBox textBoxStartStep_AAI;
        private System.Windows.Forms.GroupBox groupBoxCondition_AAI;
        private System.Windows.Forms.TextBox textBoxCondition_AAI;
        private System.Windows.Forms.Button buttonDone_AAI;
        private System.Windows.Forms.Button buttonSave_AAI;
        private System.Windows.Forms.Button buttonReference_AAI;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_AAI;
        private System.Windows.Forms.TextBox textBoxResult_AAI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_AAI;
    }
}

