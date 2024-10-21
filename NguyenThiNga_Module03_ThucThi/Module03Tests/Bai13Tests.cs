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
    public class Bai13Tests
    {
        [TestMethod()]
        public void TestMethod1()
        {
            Exception expectedException = null;
            try
            {
                Boolean actual = Module03.Bai13(6,8,1,2,3,4);
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
            Assert.IsFalse(Module03.Bai13(1,2,6,8,0,8));
        }
        [TestMethod()]
        public void TestMethod3()
        {
            Assert.IsFalse(Module03.Bai13(1, 2, 6, 8, 3,12));
        }
        [TestMethod()]
        public void TestMethod4()
        {
            Assert.IsTrue(Module03.Bai13(1, 2, 6, 8, 3,7));
        }
    }
}