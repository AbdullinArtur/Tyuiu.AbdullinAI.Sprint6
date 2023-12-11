using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Tyuiu.AbdullinAI.Sprint6.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\hahaha\source\repos\Tyuiu.AbdullinAI.Sprint6\Tyuiu.AbdullinAI.Sprint6.Task6.V4\InPutFileTask6V4.txt";
            FileInfo fileinf = new FileInfo(path);
            bool fileExists = fileinf.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
