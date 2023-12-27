using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint2.Task7.V11.Lib;

namespace Tyuiu.MusaevRS.Sprint2.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool wait, res;
            DataService ds = new DataService();
            double x = 0.5;
            double y = 0.6;
            wait = true;
            res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
