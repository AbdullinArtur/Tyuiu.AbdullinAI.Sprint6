using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint6.Task1.V14.Lib;

namespace Tyuiu.AbdullinAI.Sprint6.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
            double[] wait = new double[11];
            wait[0] = -2.15;
            wait[1] = -2.57;
            wait[2] = -3.00;
            wait[3] = -3.83;
            wait[4] = -11.70;
            wait[5] = 3;
            wait[6] = 2.19;
            wait[7] = 3.31;
            wait[8] = 2.97;
            wait[9] = 1.18;
            wait[10] = 0.03;
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
