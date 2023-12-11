namespace Tyuiu.AbdullinAI.Sprint6.Task5.V3
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHelp_AAI = new System.Windows.Forms.Button();
            this.groupBoxCondition_AAI = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxOutPutData_AAI = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dataGridViewResult_AAI = new System.Windows.Forms.DataGridView();
            this.chartResult_AAI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonOpenFile_AAI = new System.Windows.Forms.Button();
            this.buttonDone_AAI = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBoxCondition_AAI.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxOutPutData_AAI.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_AAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_AAI)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDone_AAI);
            this.panel1.Controls.Add(this.buttonOpenFile_AAI);
            this.panel1.Controls.Add(this.buttonHelp_AAI);
            this.panel1.Controls.Add(this.groupBoxCondition_AAI);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 100);
            this.panel1.TabIndex = 0;
            // 
            // buttonHelp_AAI
            // 
            this.buttonHelp_AAI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_AAI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonHelp_AAI.Location = new System.Drawing.Point(612, 22);
            this.buttonHelp_AAI.Name = "buttonHelp_AAI";
            this.buttonHelp_AAI.Size = new System.Drawing.Size(75, 66);
            this.buttonHelp_AAI.TabIndex = 1;
            this.buttonHelp_AAI.Text = "Справка";
            this.buttonHelp_AAI.UseVisualStyleBackColor = false;
            this.buttonHelp_AAI.Click += new System.EventHandler(this.buttonHelp_AAI_Click);
            // 
            // groupBoxCondition_AAI
            // 
            this.groupBoxCondition_AAI.Controls.Add(this.textBox1);
            this.groupBoxCondition_AAI.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCondition_AAI.Name = "groupBoxCondition_AAI";
            this.groupBoxCondition_AAI.Size = new System.Drawing.Size(417, 91);
            this.groupBoxCondition_AAI.TabIndex = 0;
            this.groupBoxCondition_AAI.TabStop = false;
            this.groupBoxCondition_AAI.Text = "Условие:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxOutPutData_AAI);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 361);
            this.panel2.TabIndex = 0;
            // 
            // groupBoxOutPutData_AAI
            // 
            this.groupBoxOutPutData_AAI.Controls.Add(this.dataGridViewResult_AAI);
            this.groupBoxOutPutData_AAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutData_AAI.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPutData_AAI.Name = "groupBoxOutPutData_AAI";
            this.groupBoxOutPutData_AAI.Size = new System.Drawing.Size(200, 361);
            this.groupBoxOutPutData_AAI.TabIndex = 0;
            this.groupBoxOutPutData_AAI.TabStop = false;
            this.groupBoxOutPutData_AAI.Text = "Вывод данных:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chartResult_AAI);
            this.panel3.Controls.Add(this.splitter1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(499, 361);
            this.panel3.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 361);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // dataGridViewResult_AAI
            // 
            this.dataGridViewResult_AAI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_AAI.ColumnHeadersVisible = false;
            this.dataGridViewResult_AAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_AAI.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult_AAI.Name = "dataGridViewResult_AAI";
            this.dataGridViewResult_AAI.RowHeadersVisible = false;
            this.dataGridViewResult_AAI.Size = new System.Drawing.Size(194, 342);
            this.dataGridViewResult_AAI.TabIndex = 0;
            // 
            // chartResult_AAI
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult_AAI.ChartAreas.Add(chartArea1);
            this.chartResult_AAI.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartResult_AAI.Legends.Add(legend1);
            this.chartResult_AAI.Location = new System.Drawing.Point(3, 0);
            this.chartResult_AAI.Name = "chartResult_AAI";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult_AAI.Series.Add(series1);
            this.chartResult_AAI.Size = new System.Drawing.Size(496, 361);
            this.chartResult_AAI.TabIndex = 1;
            this.chartResult_AAI.Text = "chart1";
            // 
            // buttonOpenFile_AAI
            // 
            this.buttonOpenFile_AAI.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonOpenFile_AAI.Location = new System.Drawing.Point(507, 22);
            this.buttonOpenFile_AAI.Name = "buttonOpenFile_AAI";
            this.buttonOpenFile_AAI.Size = new System.Drawing.Size(75, 66);
            this.buttonOpenFile_AAI.TabIndex = 2;
            this.buttonOpenFile_AAI.Text = "Открыть файл";
            this.buttonOpenFile_AAI.UseVisualStyleBackColor = false;
            this.buttonOpenFile_AAI.Click += new System.EventHandler(this.buttonOpenFile_AAI_Click);
            // 
            // buttonDone_AAI
            // 
            this.buttonDone_AAI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDone_AAI.Location = new System.Drawing.Point(426, 22);
            this.buttonDone_AAI.Name = "buttonDone_AAI";
            this.buttonDone_AAI.Size = new System.Drawing.Size(75, 66);
            this.buttonDone_AAI.TabIndex = 3;
            this.buttonDone_AAI.Text = "Выполнить";
            this.buttonDone_AAI.UseVisualStyleBackColor = false;
            this.buttonDone_AAI.Click += new System.EventHandler(this.buttonDone_AAI_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(402, 50);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Прочитать данные из файла InPutFileTask5V3.txt. Вывести в dataGridView. Вывести в" +
    "се вещественные числа.  \r\nПостроить диаграмму по этим значениям. ";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 461);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(715, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6  | Таск 5 | Вариант 3 | Абдуллин А.И. ";
            this.panel1.ResumeLayout(false);
            this.groupBoxCondition_AAI.ResumeLayout(false);
            this.groupBoxCondition_AAI.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBoxOutPutData_AAI.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_AAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_AAI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHelp_AAI;
        private System.Windows.Forms.GroupBox groupBoxCondition_AAI;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_AAI;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dataGridViewResult_AAI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_AAI;
        private System.Windows.Forms.Button buttonDone_AAI;
        private System.Windows.Forms.Button buttonOpenFile_AAI;
        private System.Windows.Forms.TextBox textBox1;
    }
}

