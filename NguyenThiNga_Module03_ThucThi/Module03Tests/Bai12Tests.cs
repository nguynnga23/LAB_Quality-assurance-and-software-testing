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
    public class Bai12Tests
    {
        [TestMethod()]
        public void TestMethod1()
        {
            Exception expectedException = null;
            try {
                float actual = Module03.Bai12(9, 8, -1, 7);
            }catch(Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }
        [TestMethod()]
        public void TestMethod2()
        {
            float expected = 600;
            float actual = Module03.Bai12(40,15,20,30);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod3()
        {
            float expected = 2500;
            float actual = Module03.Bai12(120,20,25,30);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void TestMethod4()
        {
            float expected = 4750;
            float actual = Module03.Bai12(200,20,25,30);
            Assert.AreEqual(expected, actual);
        }
    }
}