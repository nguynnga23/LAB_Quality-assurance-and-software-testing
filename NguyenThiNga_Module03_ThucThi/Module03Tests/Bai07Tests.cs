using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03.Tests
{
    [TestClass()]
    public class Bai07Tests
    {
        [TestMethod()]
        public void TestMethod1()
        {
            ushort year = 2023;
            byte month = 7;
            int expected = 31;
            int actual = Module03.Bai07(year, month);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod2()
        {
            ushort year = 2023;
            byte month = 6;
            int expected = 30;
            int actual = Module03.Bai07(year, month);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod3()
        {
            ushort year = 2023;
            byte month = 14;
            int expected = 0;
            int actual = Module03.Bai07(year, month);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod4()
        {
            ushort year = 2000;
            byte month = 2;
            int expected = 29;
            int actual = Module03.Bai07(year, month);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod5()
        {
            ushort year = 1900;
            byte month = 2;
            int expected = 28;
            int actual = Module03.Bai07(year, month);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod6()
        {
            ushort year = 2020;
            byte month = 2;
            int expected = 29;
            int actual = Module03.Bai07(year, month);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod7()
        {
            ushort year = 2023;
            byte month = 2;
            int expected = 28;
            int actual = Module03.Bai07(year, month);
            Assert.AreEqual(expected, actual);
        }
    }
}