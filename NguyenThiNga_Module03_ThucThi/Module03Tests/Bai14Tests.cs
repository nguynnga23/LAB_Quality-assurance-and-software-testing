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
    public class Bai14Tests
    {
        [TestMethod()]
        public void TestMethod1()
        {
            Exception expectedException = null;
            try
            {
                float x, y, s;
                Boolean actual = Module03.Bai14(3,-2,out s,out x,out y);
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }
        [TestMethod()]
        public void TestMethod2()
        {
            float x, y, s;
            Assert.IsTrue(Module03.Bai14(8, 6, out s, out x, out y));
            Assert.AreEqual(1, x);
            Assert.AreEqual(0, y);
            Assert.AreEqual(6, s);
        }
        [TestMethod()]
        public void TestMethod3()
        {
            float x, y, s;
            Assert.IsTrue(Module03.Bai14(5, 7, out s, out x, out y));
            Assert.AreEqual(0, x);
            Assert.AreEqual(1, y);
            Assert.AreEqual(5, s);
        }
      
    }
}