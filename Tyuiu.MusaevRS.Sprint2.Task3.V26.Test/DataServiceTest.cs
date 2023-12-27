using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint2.Task3.V26.Lib;

namespace Tyuiu.MusaevRS.Sprint2.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 4.702;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 1.667;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalculate3()
        {
            DataService ds = new DataService();
            double x = -1;
            double res = ds.Calculate(x);
            double wait = -4.754;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalculate4()
        {
            DataService ds = new DataService();
            double x = -40;
            double res = ds.Calculate(x);
            double wait = -319.975;
            Assert.AreEqual(wait, res);
        }
    }
}
