using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.AbdullinAI.Sprint6.Task5.V3.Lib;
using System.Diagnostics;

namespace Tyuiu.AbdullinAI.Sprint6.Task5.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\hahaha\source\repos\Tyuiu.AbdullinAI.Sprint6\Tyuiu.AbdullinAI.Sprint6.Task5.V3\bin\Debug\InPutFileTask5V3.txt";

        private void buttonDone_AAI_Click(object sender, EventArgs e)
        {
            dataGridViewResult_AAI.ColumnCount = 2;
            dataGridViewResult_AAI.Columns[0].Width = 20;
            dataGridViewResult_AAI.Columns[1].Width = 322;

            this.chartResult_AAI.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_AAI.ChartAreas[0].AxisY.Title = "Ось Y";

            chartResult_AAI.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for(int i = 0;i < numsMass.Length; i++)
            {
                dataGridViewResult_AAI.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartResult_AAI.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_AAI_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_AAI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУб-23-1 Абдуллин Артур Ильгизович", "Сообщение");
        }
    }
}
