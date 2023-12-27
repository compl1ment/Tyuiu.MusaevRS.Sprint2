using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint2.Task4.V16.Lib;

namespace Tyuiu.MusaevRS.Sprint2.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x, y, res, wait;
            x = 1;
            y = 2;
            res = ds.Calculate(x, y);
            wait = 1.25;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x, y, res, wait;
            x = 2;
            y = 1;
            res = ds.Calculate(x, y);
            wait = 0.75;
            Assert.AreEqual(wait, res);
        }
    }
}
