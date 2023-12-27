using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint2.Task5.V13.Lib;

namespace Tyuiu.MusaevRS.Sprint2.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g, m, n;
            string wait, res;
            n = 12;
            m = 7;
            g = 2024;
            wait = "13 июля 2024 года";
            res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(wait, res);
        }
    }
}
