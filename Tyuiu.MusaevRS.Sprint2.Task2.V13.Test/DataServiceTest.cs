using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint2.Task2.V13.Lib;

namespace Tyuiu.MusaevRS.Sprint2.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x, y;
            x = 6;
            y = 10;
            bool wait = true;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
