using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AbdullinAI.Sprint6.Task4.V10.Lib
{
    public class DataService : ISprint6Task4V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];
            int k = 0;
            for(int x = startValue; x <= stopValue; x++)
            {
                if ((Math.Sin(x) + 3) != 0)
                {
                    double y = ((5 * x + 2.5) / (Math.Sin(x) + 3)) + 2 * x + Math.Cos(x);
                    valueArray[k] = Math.Round(y, 2);
                    k++;
                }
                else
                {
                    valueArray[k] = 0;
                }
            }
            return valueArray;
        }
    }
}
