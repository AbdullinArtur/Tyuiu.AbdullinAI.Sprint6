using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AbdullinAI.Sprint6.Task6.V4.Lib;
using System.IO;

namespace Tyuiu.AbdullinAI.Sprint6.Task6.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        
        string openFilePath;
        DataService ds = new DataService();             
        private void buttonDone_AAI_Click(object sender, EventArgs e)
        {
            string str = "n";
            textBoxResult_AAI.Text = ds.CollectTextFromFile(str, openFilePath);
        }

        private void buttonHelp_AAI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonLoadFile_AAI_Click(object sender, EventArgs e)
        {
            openFileDialogTask_AAI.ShowDialog();
            openFilePath = openFileDialogTask_AAI.FileName;
            textBoxLoadFromFile_AAI.Text = File.ReadAllText(openFilePath);
            groupBoxInPutData_AAI.Text = groupBoxOutPutData_AAI.Text + " " + openFileDialogTask_AAI.FileName;
            buttonDone_AAI.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        
    }
}
