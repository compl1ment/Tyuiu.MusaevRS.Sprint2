using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint2.Task6.Lib.V5;

namespace Tyuiu.MusaevRS.Sprint2.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int m = 12;
            string wait = "Дама";
            string res = ds.FindCardValue(m);
            Assert.AreEqual(wait, res);
        }
    }
}
