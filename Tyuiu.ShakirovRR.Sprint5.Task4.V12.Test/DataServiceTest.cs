using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShakirovRR.Sprint5.Task4.V12.Lib;
using System.IO;

namespace Tyuiu.ShakirovRR.Sprint5.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFile()
        {
            {
                string path = @"C:\Users\Рамиль\source\repos\Tyuiu.ShakirovRR.Sprint5\Tyuiu.ShakirovRR.Sprint5.Task4.V12\bin\Debug\InPutDataFileTask4V12.txt";


                FileInfo fl = new FileInfo(path);
                bool fileExists = fl.Exists;
                bool wait = true;
                Assert.AreEqual(wait, fileExists);
            }
        }
        [TestMethod]
        public void CheckCalc()
        {
            {
                DataService ds = new DataService();
                string path = @"C:\Users\Рамиль\source\repos\Tyuiu.ShakirovRR.Sprint5\Tyuiu.ShakirovRR.Sprint5.Task4.V12\bin\Debug\InPutDataFileTask4V12.txt";

                double res = ds.LoadFromDataFile(path);
                double wait = 1.989;
                Assert.AreEqual(wait, res);
            }
        }
    }
}