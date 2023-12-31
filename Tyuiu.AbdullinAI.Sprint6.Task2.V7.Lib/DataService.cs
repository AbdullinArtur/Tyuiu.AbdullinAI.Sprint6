﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AbdullinAI.Sprint6.Task2.V7.Lib
{
    public class DataService : ISprint6Task2V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] a = new double[len];
            int k = 0;
            for ( int x = startValue; x <= stopValue; x++ )
            {
                double c = Math.Round(3 * x + 2 - ((2 * x - x) / (Math.Cos(x) + 1)),2);
                if (Math.Cos(x) + 1 == 0)
                {
                    a[k] = 0;
                }
                else
                {
                    a[k] = c;
                }         
                k++;
            }
            return a;
        }
    }
}
