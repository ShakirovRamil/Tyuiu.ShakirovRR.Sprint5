﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShakirovRR.Sprint5.Task2.V18.Lib;
using System.IO;

namespace Tyuiu.ShakirovRR.Sprint5.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTets
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\Пользователь\source\repos\Tyuiu.ShakirovRR.Sprint5\Tyuiu.ShakirovRR.Sprint5.Task2.V18\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}