using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.ShakirovRR.Sprint5.Task0.V13.Lib;

namespace Tyuiu.ShakirovRR.Sprint5.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\polimer\source\repos\Tyuiu.PoznyakIA.Sprint5\Tyuiu.PoznyakIA.Sprint5.Task0.V13\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}