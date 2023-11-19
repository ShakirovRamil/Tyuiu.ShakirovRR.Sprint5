using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.ShakirovRR.Sprint5.Task1.V25.Lib;

namespace Tyuiu.ShakirovRR.Sprint5.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\rgoog\source\repos\Tyuiu.GoogeRA.Sprint5\Tyuiu.GoogeRA.Sprint5.Task1.V25\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}