using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AbdullinAI.Sprint6.Task1.V14.Lib
{
    public class DataService : ISprint6Task1V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] a = new double[len];
            double b;
            int k = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double c = ((2 * x + 6) / (Math.Cos(x) + x)) - 3;
                b = Math.Round(c,2);
                if((Math.Cos(x) + x) == 0)
                {
                    a[k] = 0;
                }
                else
                {
                    a[k] = b;
                }               
                k++;
            }
            return a;
        }
    }
}
