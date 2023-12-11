using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint6.Task2.V7.Lib;

namespace Tyuiu.AbdullinAI.Sprint6.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
            double[] wait = new double[res.Length];
            wait[0] = -9.10;
            wait[1] = 1.55;
            wait[2] = 292.78;
            wait[3] = -0.57;
            wait[4] = -0.35;
            wait[5] = 2;
            wait[6] = 4.35;
            wait[7] = 4.57;
            wait[8] = -288.78;
            wait[9] = 2.45;
            wait[10] = 13.10;
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
