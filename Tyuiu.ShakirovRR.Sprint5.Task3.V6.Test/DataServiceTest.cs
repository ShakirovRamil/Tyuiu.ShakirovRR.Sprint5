using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.ShakirovRR.Sprint5.Task3.V6.Lib;

namespace Tyuiu.ShakirovRR.Sprint5.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\Tatur\source\repos\Tyuiu.TaturinAM.Sprint5\Tyuiu.TaturinAM.Sprint5.Task3.V6\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}