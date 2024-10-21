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
    public class Bai09Tests
    {
        [TestMethod()]
        public void TestMethod1()
        {
            String expected = "Error";
            String actual = Module03.Bai09(3,2,4);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod2()
        {
            String expected = "5";
            String actual = Module03.Bai09(5,6,2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod3()
        {
            String expected = "7";
            String actual = Module03.Bai09(5,7,9);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod4()
        {
            String expected = "6";
            String actual = Module03.Bai09(5,8,6);
            Assert.AreEqual(expected, actual);
        }
    }
}