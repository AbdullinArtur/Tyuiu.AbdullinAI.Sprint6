using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AbdullinAI.Sprint6.Task2.V7.Lib;

namespace Tyuiu.AbdullinAI.Sprint6.Task2.V7
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_AAI_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartValue_AAI.Text);
                int stopStep = Convert.ToInt32(textBoxStopValue_AAI.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFUnction_AAI.Titles.Add("График функции 3x + 2 - ((2x-x)/(cosx +1)) ");
                this.chartFUnction_AAI.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFUnction_AAI.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewFunction_AAI.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFUnction_AAI.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch 
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReference_AAI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУб-23-1 Абдуллин Артур Ильгизович", "Сообщение");
        }

        private void buttonDone_AAI_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_AAI.BackColor = Color.Red;
        }

        private void buttonDone_AAI_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_AAI.BackColor = Color.Green;
        }

        private void buttonDone_AAI_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_AAI.BackColor = Color.Blue;
        }
    }
}
