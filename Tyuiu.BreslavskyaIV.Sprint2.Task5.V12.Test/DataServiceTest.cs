using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BreslavskyaIV.Sprint2.Task5.V12.Lib;

namespace Tyuiu.BreslavskyaIV.Sprint2.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            int g = 2023;
            int n = 1;
            Assert.AreEqual("31.12.2022", ds.FindDateOfPreviousDay(g, 1, n));
            Assert.AreEqual("31.01.2023", ds.FindDateOfPreviousDay(g, 2, n));
            Assert.AreEqual("29.02.2023", ds.FindDateOfPreviousDay(g, 3, n));
            Assert.AreEqual("31.03.2023", ds.FindDateOfPreviousDay(g, 4, n));
            Assert.AreEqual("30.04.2023", ds.FindDateOfPreviousDay(g, 5, n));
            Assert.AreEqual("31.05.2023", ds.FindDateOfPreviousDay(g, 6, n));
            Assert.AreEqual("30.06.2023", ds.FindDateOfPreviousDay(g, 7, n));
            Assert.AreEqual("31.07.2023", ds.FindDateOfPreviousDay(g, 8, n));
            Assert.AreEqual("31.08.2023", ds.FindDateOfPreviousDay(g, 9, n));
            Assert.AreEqual("30.09.2023", ds.FindDateOfPreviousDay(g, 10, n));
            Assert.AreEqual("31.10.2023", ds.FindDateOfPreviousDay(g, 11, n));
            Assert.AreEqual("30.11.2023", ds.FindDateOfPreviousDay(g, 12, n));
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            int g = 2023;
            int m = 3;
            int n = 3;
            Assert.AreEqual("02.03.2023", ds.FindDateOfPreviousDay(g, m, n));
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            int g = 2023;
            int m = 3;
            int n = 12;
            Assert.AreEqual("11.03.2023", ds.FindDateOfPreviousDay(g, m, n));
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            int g = 2023;
            int m = 11;
            int n = 12;
            Assert.AreEqual("11.11.2023", ds.FindDateOfPreviousDay(g, m, n));
        }
    }
}
