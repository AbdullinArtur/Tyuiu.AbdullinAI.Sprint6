﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AbdullinAI.Sprint6.Task7.V30.Lib
{
    public class DataService : ISprint6Task7V30
    {
        public int[,] GetMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            //int cols = matrix.GetLength(1);


            for (int i = 0; i < rows; i++)
            {
                
                if (matrix[i,0] != 4)
                {
                    matrix[i, 0] = 8;
                }
                
            }
            return matrix;
        }
    }
}
