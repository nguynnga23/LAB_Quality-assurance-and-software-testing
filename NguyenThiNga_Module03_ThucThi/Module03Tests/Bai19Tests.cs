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
    public class Bai19Tests
    {
        [TestMethod()]
        public void TestMethod1()
        {
            sbyte expected = -1;
            sbyte actual = Module03.Bai19(-7, 56);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestMethod2()
        {
            sbyte expected = -1;
            sbyte actual = Module03.Bai19(168, -8);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestMethod3()
        {
            sbyte expected = 2;
            sbyte actual = Module03.Bai19(168, 50);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestMethod4()
        {
            sbyte expected = 1;
            sbyte actual = Module03.Bai19(168, 60);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod5()
        {
            sbyte expected = 0;
            sbyte actual = Module03.Bai19(168, 55);
            Assert.AreEqual(expected, actual);
        }
    }
}