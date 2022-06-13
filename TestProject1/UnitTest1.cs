using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static delta.licz;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            delta.licz l = new delta.licz();
            double x1 = 0;
            double x2 = 0;
            double a = 1;
            double b = 2;
            double c = 1;
            delta.licz.liczdelta(a, b, c, x1, x2);
            Assert.AreNotEqual(x1, double.NaN);
            Assert.AreNotEqual(x2, double.NaN);
        }

        [TestMethod]
        public void TestMethod2()
        {
            delta.licz l = new delta.licz();
            double x1 = 0;
            double x2 = 0;
            double a = 4;
            double b = 10;
            double c = 4;
            delta.licz.liczdelta(a, b, c, x1, x2);
            Assert.AreNotEqual(x1, double.NaN);
            Assert.AreNotEqual(x2, double.NaN);
        }

        [TestMethod]
        public void TestMethod3()
        {
            delta.licz l = new delta.licz();
            double x1 = 0;
            double x2 = 0;
            double a = 1;
            double b = 1;
            double c = 1;
            delta.licz.liczdelta(a, b, c, x1, x2);
            Assert.AreNotEqual(x1, double.NaN);
            Assert.AreNotEqual(x2, double.NaN);
        }
    }
}