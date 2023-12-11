namespace Tyuiu.AbdullinAI.Sprint6.Task7.V30
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
            this.panelTop_AAI = new System.Windows.Forms.Panel();
            this.buttonDone_AAI = new System.Windows.Forms.Button();
            this.buttonHelp_AAI = new System.Windows.Forms.Button();
            this.buttonSave_AAI = new System.Windows.Forms.Button();
            this.buttonLoadFile_AAI = new System.Windows.Forms.Button();
            this.panelTask_AAI = new System.Windows.Forms.Panel();
            this.groupBoxCondition_AAI = new System.Windows.Forms.GroupBox();
            this.textBoxTask_AAI = new System.Windows.Forms.TextBox();
            this.panelOutPutdata_AAI = new System.Windows.Forms.Panel();
            this.groupBoxOutPutData_AAI = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut_AAI = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelInPutData_AAI = new System.Windows.Forms.Panel();
            this.groupBoxInPutData_AAI = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_AAI = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_AAI = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_AAI = new System.Windows.Forms.SaveFileDialog();
            this.toolTip_AAI = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop_AAI.SuspendLayout();
            this.panelTask_AAI.SuspendLayout();
            this.groupBoxCondition_AAI.SuspendLayout();
            this.panelOutPutdata_AAI.SuspendLayout();
            this.groupBoxOutPutData_AAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_AAI)).BeginInit();
            this.panelInPutData_AAI.SuspendLayout();
            this.groupBoxInPutData_AAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_AAI)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_AAI
            // 
            this.panelTop_AAI.Controls.Add(this.buttonDone_AAI);
            this.panelTop_AAI.Controls.Add(this.buttonHelp_AAI);
            this.panelTop_AAI.Controls.Add(this.buttonSave_AAI);
            this.panelTop_AAI.Controls.Add(this.buttonLoadFile_AAI);
            this.panelTop_AAI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_AAI.Location = new System.Drawing.Point(0, 0);
            this.panelTop_AAI.Name = "panelTop_AAI";
            this.panelTop_AAI.Size = new System.Drawing.Size(1034, 80);
            this.panelTop_AAI.TabIndex = 0;
            // 
            // buttonDone_AAI
            // 
            this.buttonDone_AAI.Enabled = false;
            this.buttonDone_AAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_AAI.Image = global::Tyuiu.AbdullinAI.Sprint6.Task7.V30.Properties.Resources.page_go;
            this.buttonDone_AAI.Location = new System.Drawing.Point(94, 7);
            this.buttonDone_AAI.Name = "buttonDone_AAI";
            this.buttonDone_AAI.Size = new System.Drawing.Size(75, 67);
            this.buttonDone_AAI.TabIndex = 4;
            this.toolTip_AAI.SetToolTip(this.buttonDone_AAI, "Нажмите, чтобы изменить в первом столбце значения не равные 4 на 8 . ");
            this.buttonDone_AAI.UseVisualStyleBackColor = true;
            this.buttonDone_AAI.Click += new System.EventHandler(this.buttonDone_AAI_Click);
            this.buttonDone_AAI.MouseEnter += new System.EventHandler(this.buttonDone_AAI_MouseEnter);
            // 
            // buttonHelp_AAI
            // 
            this.buttonHelp_AAI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_AAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_AAI.Image = global::Tyuiu.AbdullinAI.Sprint6.Task7.V30.Properties.Resources.help;
            this.buttonHelp_AAI.Location = new System.Drawing.Point(947, 7);
            this.buttonHelp_AAI.Name = "buttonHelp_AAI";
            this.buttonHelp_AAI.Size = new System.Drawing.Size(75, 67);
            this.buttonHelp_AAI.TabIndex = 3;
            this.toolTip_AAI.SetToolTip(this.buttonHelp_AAI, "Сведение о программе");
            this.buttonHelp_AAI.UseVisualStyleBackColor = true;
            this.buttonHelp_AAI.Click += new System.EventHandler(this.buttonHelp_AAI_Click);
            this.buttonHelp_AAI.MouseEnter += new System.EventHandler(this.buttonHelp_AAI_MouseEnter);
            // 
            // buttonSave_AAI
            // 
            this.buttonSave_AAI.Enabled = false;
            this.buttonSave_AAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_AAI.Image = global::Tyuiu.AbdullinAI.Sprint6.Task7.V30.Properties.Resources.page_save;
            this.buttonSave_AAI.Location = new System.Drawing.Point(175, 7);
            this.buttonSave_AAI.Name = "buttonSave_AAI";
            this.buttonSave_AAI.Size = new System.Drawing.Size(75, 67);
            this.buttonSave_AAI.TabIndex = 2;
            this.toolTip_AAI.SetToolTip(this.buttonSave_AAI, "Нажмите, чтобы сохранить файл");
            this.buttonSave_AAI.UseVisualStyleBackColor = true;
            this.buttonSave_AAI.Click += new System.EventHandler(this.buttonSave_AAI_Click);
            this.buttonSave_AAI.MouseEnter += new System.EventHandler(this.buttonSave_AAI_MouseEnter);
            // 
            // buttonLoadFile_AAI
            // 
            this.buttonLoadFile_AAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadFile_AAI.Image = global::Tyuiu.AbdullinAI.Sprint6.Task7.V30.Properties.Resources.folder_page_white;
            this.buttonLoadFile_AAI.Location = new System.Drawing.Point(6, 7);
            this.buttonLoadFile_AAI.Name = "buttonLoadFile_AAI";
            this.buttonLoadFile_AAI.Size = new System.Drawing.Size(82, 67);
            this.buttonLoadFile_AAI.TabIndex = 1;
            this.toolTip_AAI.SetToolTip(this.buttonLoadFile_AAI, "Откройте нужный файл для обработки\r\n");
            this.buttonLoadFile_AAI.UseVisualStyleBackColor = true;
            this.buttonLoadFile_AAI.Click += new System.EventHandler(this.buttonLoadFile_AAI_Click);
            this.buttonLoadFile_AAI.MouseEnter += new System.EventHandler(this.buttonLoadFile_AAI_MouseEnter);
            // 
            // panelTask_AAI
            // 
            this.panelTask_AAI.Controls.Add(this.groupBoxCondition_AAI);
            this.panelTask_AAI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_AAI.Location = new System.Drawing.Point(0, 80);
            this.panelTask_AAI.Name = "panelTask_AAI";
            this.panelTask_AAI.Size = new System.Drawing.Size(1034, 78);
            this.panelTask_AAI.TabIndex = 1;
            // 
            // groupBoxCondition_AAI
            // 
            this.groupBoxCondition_AAI.Controls.Add(this.textBoxTask_AAI);
            this.groupBoxCondition_AAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCondition_AAI.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCondition_AAI.Name = "groupBoxCondition_AAI";
            this.groupBoxCondition_AAI.Size = new System.Drawing.Size(1034, 78);
            this.groupBoxCondition_AAI.TabIndex = 1;
            this.groupBoxCondition_AAI.TabStop = false;
            this.groupBoxCondition_AAI.Text = "Условие:";
            // 
            // textBoxTask_AAI
            // 
            this.textBoxTask_AAI.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_AAI.Multiline = true;
            this.textBoxTask_AAI.Name = "textBoxTask_AAI";
            this.textBoxTask_AAI.Size = new System.Drawing.Size(816, 56);
            this.textBoxTask_AAI.TabIndex = 0;
            this.textBoxTask_AAI.Text = resources.GetString("textBoxTask_AAI.Text");
            // 
            // panelOutPutdata_AAI
            // 
            this.panelOutPutdata_AAI.Controls.Add(this.groupBoxOutPutData_AAI);
            this.panelOutPutdata_AAI.Controls.Add(this.splitter1);
            this.panelOutPutdata_AAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutPutdata_AAI.Location = new System.Drawing.Point(542, 158);
            this.panelOutPutdata_AAI.Name = "panelOutPutdata_AAI";
            this.panelOutPutdata_AAI.Size = new System.Drawing.Size(492, 303);
            this.panelOutPutdata_AAI.TabIndex = 1;
            // 
            // groupBoxOutPutData_AAI
            // 
            this.groupBoxOutPutData_AAI.Controls.Add(this.dataGridViewOut_AAI);
            this.groupBoxOutPutData_AAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutData_AAI.Location = new System.Drawing.Point(3, 0);
            this.groupBoxOutPutData_AAI.Name = "groupBoxOutPutData_AAI";
            this.groupBoxOutPutData_AAI.Size = new System.Drawing.Size(489, 303);
            this.groupBoxOutPutData_AAI.TabIndex = 1;
            this.groupBoxOutPutData_AAI.TabStop = false;
            this.groupBoxOutPutData_AAI.Text = "Вывод:";
            // 
            // dataGridViewOut_AAI
            // 
            this.dataGridViewOut_AAI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_AAI.ColumnHeadersVisible = false;
            this.dataGridViewOut_AAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut_AAI.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOut_AAI.Name = "dataGridViewOut_AAI";
            this.dataGridViewOut_AAI.RowHeadersVisible = false;
            this.dataGridViewOut_AAI.Size = new System.Drawing.Size(483, 284);
            this.dataGridViewOut_AAI.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 303);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // panelInPutData_AAI
            // 
            this.panelInPutData_AAI.Controls.Add(this.groupBoxInPutData_AAI);
            this.panelInPutData_AAI.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInPutData_AAI.Location = new System.Drawing.Point(0, 158);
            this.panelInPutData_AAI.Name = "panelInPutData_AAI";
            this.panelInPutData_AAI.Size = new System.Drawing.Size(542, 303);
            this.panelInPutData_AAI.TabIndex = 1;
            // 
            // groupBoxInPutData_AAI
            // 
            this.groupBoxInPutData_AAI.Controls.Add(this.dataGridViewIn_AAI);
            this.groupBoxInPutData_AAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPutData_AAI.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPutData_AAI.Name = "groupBoxInPutData_AAI";
            this.groupBoxInPutData_AAI.Size = new System.Drawing.Size(542, 303);
            this.groupBoxInPutData_AAI.TabIndex = 0;
            this.groupBoxInPutData_AAI.TabStop = false;
            this.groupBoxInPutData_AAI.Text = "Ввод:";
            // 
            // dataGridViewIn_AAI
            // 
            this.dataGridViewIn_AAI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_AAI.ColumnHeadersVisible = false;
            this.dataGridViewIn_AAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn_AAI.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewIn_AAI.Name = "dataGridViewIn_AAI";
            this.dataGridViewIn_AAI.RowHeadersVisible = false;
            this.dataGridViewIn_AAI.Size = new System.Drawing.Size(536, 284);
            this.dataGridViewIn_AAI.TabIndex = 0;
            // 
            // openFileDialogTask_AAI
            // 
            this.openFileDialogTask_AAI.FileName = "openFileDialogTask_AAI";
            // 
            // toolTip_AAI
            // 
            this.toolTip_AAI.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolTip_AAI.IsBalloon = true;
            this.toolTip_AAI.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_AAI.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 461);
            this.Controls.Add(this.panelOutPutdata_AAI);
            this.Controls.Add(this.panelInPutData_AAI);
            this.Controls.Add(this.panelTask_AAI);
            this.Controls.Add(this.panelTop_AAI);
            this.MinimumSize = new System.Drawing.Size(1050, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6  | Таск 7 | Вариант 30 | Абдуллин А.И. ";
            this.panelTop_AAI.ResumeLayout(false);
            this.panelTask_AAI.ResumeLayout(false);
            this.groupBoxCondition_AAI.ResumeLayout(false);
            this.groupBoxCondition_AAI.PerformLayout();
            this.panelOutPutdata_AAI.ResumeLayout(false);
            this.groupBoxOutPutData_AAI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_AAI)).EndInit();
            this.panelInPutData_AAI.ResumeLayout(false);
            this.groupBoxInPutData_AAI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_AAI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_AAI;
        private System.Windows.Forms.Panel panelTask_AAI;
        private System.Windows.Forms.GroupBox groupBoxCondition_AAI;
        private System.Windows.Forms.TextBox textBoxTask_AAI;
        private System.Windows.Forms.Button buttonLoadFile_AAI;
        private System.Windows.Forms.Button buttonSave_AAI;
        private System.Windows.Forms.Button buttonHelp_AAI;
        private System.Windows.Forms.Button buttonDone_AAI;
        private System.Windows.Forms.Panel panelOutPutdata_AAI;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_AAI;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelInPutData_AAI;
        private System.Windows.Forms.GroupBox groupBoxInPutData_AAI;
        private System.Windows.Forms.DataGridView dataGridViewOut_AAI;
        private System.Windows.Forms.DataGridView dataGridViewIn_AAI;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_AAI;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_AAI;
        private System.Windows.Forms.ToolTip toolTip_AAI;
    }
}

