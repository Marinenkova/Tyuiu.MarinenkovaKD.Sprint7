﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Project.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFile()
        {
            string path = @"C:\Users\Я твой-ты моя\source\repos\Tyuiu.MarinenkovaKD.Sprint7\Project.V15\bin\Debug\Документ.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);

        }
    }
}
