using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Sprint2.Task1.V30.Lib;

namespace Tyuiu.MusaevRS.Sprint2.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            bool[] res = new bool[6];
            int a, b, c, d;
            a = 657;
            b = 874;
            c = 14;
            d = 654;
            bool[] wait = new bool[6] { true, false, true, true, true, false };
            res = ds.GetLogicOperations(a, b, c, d);
            CollectionAssert.AreEqual(wait, res);

        }
    }
}
