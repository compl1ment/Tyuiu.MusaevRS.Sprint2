using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint2.Task0.V7.Lib;

namespace Tyuiu.MusaevRS.Sprint2.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test()
        {
            DataService ds = new DataService();
            int x, y;
            x = 103;
            y = 475;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, false, true, true, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
