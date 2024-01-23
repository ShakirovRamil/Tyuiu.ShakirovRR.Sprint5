using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.ShakirovRR.Sprint5.Task6.V5.Lib;

namespace Tyuiu.ShakirovRR.Sprint5.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void ValidCalc()
        {
            string path = @"C:\Users\Рамиль\source\repos\Tyuiu.ShakirovRR.Sprint5\Tyuiu.ShakirovRR.Sprint5.Task6.V5\bin\Debug\InPutDataFileTask6V5.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 5;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckFileInFolder()
        {
            string path = @"C:\Users\Рамиль\source\repos\Tyuiu.ShakirovRR.Sprint5\Tyuiu.ShakirovRR.Sprint5.Task6.V5\bin\Debug\InPutDataFileTask6V5.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}