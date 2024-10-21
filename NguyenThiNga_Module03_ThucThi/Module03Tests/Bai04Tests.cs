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
    public class Bai04Tests
    {
        [TestMethod()]
        public void TestMethod1()
        {
            int expected = 0;
            int actual = Module03.Bai04(0, 9, 8);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod2()
        {
            int expected = 10;
            int actual = Module03.Bai04(8,9,10);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod3()
        {
            int expected = 9;
            int actual = Module03.Bai04(9,7,8);

            Assert.AreEqual(expected, actual);
        }
    }
}