using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AbdullinAI.Sprint6.Task0.V14.Lib;

namespace Tyuiu.AbdullinAI.Sprint6.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalulate()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = -0.444;
            Assert.AreEqual(res, wait);
        }
    }
}
