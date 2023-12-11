namespace Tyuiu.AbdullinAI.Sprint6.Task6.V4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHelp_AAI = new System.Windows.Forms.Button();
            this.buttonDone_AAI = new System.Windows.Forms.Button();
            this.buttonLoadFile_AAI = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxCondition_AAI = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBoxInPutData_AAI = new System.Windows.Forms.GroupBox();
            this.textBoxLoadFromFile_AAI = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBoxOutPutData_AAI = new System.Windows.Forms.GroupBox();
            this.textBoxResult_AAI = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.openFileDialogTask_AAI = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxCondition_AAI.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxInPutData_AAI.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBoxOutPutData_AAI.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHelp_AAI);
            this.panel1.Controls.Add(this.buttonDone_AAI);
            this.panel1.Controls.Add(this.buttonLoadFile_AAI);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 76);
            this.panel1.TabIndex = 0;
            // 
            // buttonHelp_AAI
            // 
            this.buttonHelp_AAI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_AAI.Image = global::Tyuiu.AbdullinAI.Sprint6.Task6.V4.Properties.Resources.help;
            this.buttonHelp_AAI.Location = new System.Drawing.Point(1097, 3);
            this.buttonHelp_AAI.Name = "buttonHelp_AAI";
            this.buttonHelp_AAI.Size = new System.Drawing.Size(75, 67);
            this.buttonHelp_AAI.TabIndex = 2;
            this.toolTip.SetToolTip(this.buttonHelp_AAI, "Информация");
            this.buttonHelp_AAI.UseVisualStyleBackColor = true;
            this.buttonHelp_AAI.Click += new System.EventHandler(this.buttonHelp_AAI_Click);
            // 
            // buttonDone_AAI
            // 
            this.buttonDone_AAI.Image = global::Tyuiu.AbdullinAI.Sprint6.Task6.V4.Properties.Resources.page_go;
            this.buttonDone_AAI.Location = new System.Drawing.Point(94, 3);
            this.buttonDone_AAI.Name = "buttonDone_AAI";
            this.buttonDone_AAI.Size = new System.Drawing.Size(75, 67);
            this.buttonDone_AAI.TabIndex = 1;
            this.toolTip.SetToolTip(this.buttonDone_AAI, "Производит поиск в файле вхожденний символов \"n\"\r\nи конкатинирует строки в которы" +
        "х находятся \r\nэти символы\r\n");
            this.buttonDone_AAI.UseVisualStyleBackColor = true;
            this.buttonDone_AAI.Click += new System.EventHandler(this.buttonDone_AAI_Click);
            // 
            // buttonLoadFile_AAI
            // 
            this.buttonLoadFile_AAI.Image = global::Tyuiu.AbdullinAI.Sprint6.Task6.V4.Properties.Resources.folder_page_white;
            this.buttonLoadFile_AAI.Location = new System.Drawing.Point(6, 3);
            this.buttonLoadFile_AAI.Name = "buttonLoadFile_AAI";
            this.buttonLoadFile_AAI.Size = new System.Drawing.Size(82, 67);
            this.buttonLoadFile_AAI.TabIndex = 0;
            this.toolTip.SetToolTip(this.buttonLoadFile_AAI, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            this.buttonLoadFile_AAI.UseVisualStyleBackColor = true;
            this.buttonLoadFile_AAI.Click += new System.EventHandler(this.buttonLoadFile_AAI_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxCondition_AAI);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 75);
            this.panel2.TabIndex = 0;
            // 
            // groupBoxCondition_AAI
            // 
            this.groupBoxCondition_AAI.Controls.Add(this.textBox3);
            this.groupBoxCondition_AAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCondition_AAI.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCondition_AAI.Name = "groupBoxCondition_AAI";
            this.groupBoxCondition_AAI.Size = new System.Drawing.Size(1184, 75);
            this.groupBoxCondition_AAI.TabIndex = 0;
            this.groupBoxCondition_AAI.TabStop = false;
            this.groupBoxCondition_AAI.Text = "Условие:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 19);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(772, 49);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBoxInPutData_AAI);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 151);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(681, 310);
            this.panel3.TabIndex = 0;
            // 
            // groupBoxInPutData_AAI
            // 
            this.groupBoxInPutData_AAI.Controls.Add(this.textBoxLoadFromFile_AAI);
            this.groupBoxInPutData_AAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPutData_AAI.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPutData_AAI.Name = "groupBoxInPutData_AAI";
            this.groupBoxInPutData_AAI.Size = new System.Drawing.Size(681, 310);
            this.groupBoxInPutData_AAI.TabIndex = 0;
            this.groupBoxInPutData_AAI.TabStop = false;
            this.groupBoxInPutData_AAI.Text = "Ввод:";
            // 
            // textBoxLoadFromFile_AAI
            // 
            this.textBoxLoadFromFile_AAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLoadFromFile_AAI.Location = new System.Drawing.Point(3, 16);
            this.textBoxLoadFromFile_AAI.Multiline = true;
            this.textBoxLoadFromFile_AAI.Name = "textBoxLoadFromFile_AAI";
            this.textBoxLoadFromFile_AAI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLoadFromFile_AAI.Size = new System.Drawing.Size(675, 291);
            this.textBoxLoadFromFile_AAI.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBoxOutPutData_AAI);
            this.panel4.Controls.Add(this.splitter1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(681, 151);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(503, 310);
            this.panel4.TabIndex = 1;
            // 
            // groupBoxOutPutData_AAI
            // 
            this.groupBoxOutPutData_AAI.Controls.Add(this.textBoxResult_AAI);
            this.groupBoxOutPutData_AAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutData_AAI.Location = new System.Drawing.Point(3, 0);
            this.groupBoxOutPutData_AAI.Name = "groupBoxOutPutData_AAI";
            this.groupBoxOutPutData_AAI.Size = new System.Drawing.Size(500, 310);
            this.groupBoxOutPutData_AAI.TabIndex = 1;
            this.groupBoxOutPutData_AAI.TabStop = false;
            this.groupBoxOutPutData_AAI.Text = "Вывод:";
            // 
            // textBoxResult_AAI
            // 
            this.textBoxResult_AAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_AAI.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult_AAI.Multiline = true;
            this.textBoxResult_AAI.Name = "textBoxResult_AAI";
            this.textBoxResult_AAI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_AAI.Size = new System.Drawing.Size(494, 291);
            this.textBoxResult_AAI.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 310);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // openFileDialogTask_AAI
            // 
            this.openFileDialogTask_AAI.FileName = "openFileDialog1";
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1200, 500);
            this.Name = "FormMain";
            this.Text = "Спринт 6  | Таск 6 | Вариант 4 | Абдуллин А.И. ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBoxCondition_AAI.ResumeLayout(false);
            this.groupBoxCondition_AAI.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBoxInPutData_AAI.ResumeLayout(false);
            this.groupBoxInPutData_AAI.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBoxOutPutData_AAI.ResumeLayout(false);
            this.groupBoxOutPutData_AAI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_AAI;
        private System.Windows.Forms.GroupBox groupBoxInPutData_AAI;
        private System.Windows.Forms.TextBox textBoxLoadFromFile_AAI;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_AAI;
        private System.Windows.Forms.TextBox textBoxResult_AAI;
        private System.Windows.Forms.Button buttonDone_AAI;
        private System.Windows.Forms.Button buttonLoadFile_AAI;
        private System.Windows.Forms.GroupBox groupBoxCondition_AAI;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button buttonHelp_AAI;
    }
}

