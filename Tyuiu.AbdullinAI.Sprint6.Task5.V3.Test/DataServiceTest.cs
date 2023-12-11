using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Tyuiu.AbdullinAI.Sprint6.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\hahaha\source\repos\Tyuiu.AbdullinAI.Sprint6\Tyuiu.AbdullinAI.Sprint6.Task5.V3\bin\Debug\InPutFileTask5V3.txt";
            FileInfo fileInf = new FileInfo(path);
            bool fileExists = fileInf.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
