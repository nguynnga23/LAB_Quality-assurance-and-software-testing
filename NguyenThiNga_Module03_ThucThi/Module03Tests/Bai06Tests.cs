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
    public class Bai06Tests
    {
        [TestMethod()]
        public void TestMethod1()
        {
            double sum =6;
            double count = 1;
            double expected = 6;
            double actual = Module03.Bai06(sum,count);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod2()
        {
            double sum = 6;
            double count = 2;
            double expected = 3;
            double actual = Module03.Bai06(sum, count);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod3()
        {
            double sum = 6;
            double count = -3;
            double expected = 0;
            double actual = Module03.Bai06(sum, count);

            Assert.AreEqual(expected, actual);
        }
    }
}