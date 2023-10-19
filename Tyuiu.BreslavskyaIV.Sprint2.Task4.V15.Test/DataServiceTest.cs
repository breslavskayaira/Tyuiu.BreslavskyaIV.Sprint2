using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BreslavskyaIV.Sprint2.Task4.V15.Lib;

namespace Tyuiu.BreslavskyaIV.Sprint2.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 5;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 441;
            double res = ds.Calculate(x, y);
            double wait = 12.384;
            Assert.AreEqual(wait, res);
        }
    }
}
