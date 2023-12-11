using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AbdullinAI.Sprint6.Task4.V10.Lib;
using System.IO;

namespace Tyuiu.AbdullinAI.Sprint6.Task4.V10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReference_AAI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы АСОиУб-23-1 Абдуллин Артур Ильгизович", "Сообщение");
        }
        DataService ds = new DataService();
        
        private void buttonDone_AAI_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_AAI.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_AAI.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                //this.chartFunction_AAI.Titles.Add("График функции ((5 * x + 2.5) / (Math.Sin(x) + 3)) + 2 * x + Math.Cos(x)");
                //добавляем через дезай
                this.chartFunction_AAI.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_AAI.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_AAI.Text = "";

                chartFunction_AAI.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.chartFunction_AAI.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_AAI.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch 
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_AAI_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V10.txt";
                File.WriteAllText(path, textBoxResult_AAI.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    //процесс запуска приложения notepad
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
