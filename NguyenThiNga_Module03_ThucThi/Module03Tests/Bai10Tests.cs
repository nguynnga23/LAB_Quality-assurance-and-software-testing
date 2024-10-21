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
    public class Bai10Tests
    {
        [TestMethod()]
        public void TestMethod1()
        {
            Assert.IsFalse(Module03.Bai10(3,4,0));
        }
        [TestMethod()]
        public void TestMethod2()
        {
            Assert.IsFalse(Module03.Bai10(4,6,12));
        }
        [TestMethod()]
        public void TestMethod3()
        {
            Assert.IsFalse(Module03.Bai10(4,14,7));
        }
        [TestMethod()]
        public void TestMethod4()
        {
            Assert.IsFalse(Module03.Bai10(22,7,9));
        }
        [TestMethod()]
        public void TestMethod5()
        {
            Assert.IsTrue(Module03.Bai10(3, 4, 5));
        }
    }
}