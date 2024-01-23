using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.ShakirovRR.Sprint5.Task7.V18.Lib;

namespace Tyuiu.ShakirovRR.Sprint5.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = @"C:\Users\Рамиль\source\repos\Tyuiu.ShakirovRR.Sprint5\Tyuiu.ShakirovRR.Sprint5.Task7.V18\bin\Debug\InPutDataFileTask7V18.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExist = fileinfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}