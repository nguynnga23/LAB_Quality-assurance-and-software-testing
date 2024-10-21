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
    public class Bai17Tests
    {
        [TestMethod()]
        public void TestMethod1()
        {
            Assert.IsFalse(Module03.Bai17(2023,14,15));
        }
        [TestMethod()]
        public void TestMethod2()
        {
            Assert.IsFalse(Module03.Bai17(2023, 10, 0));
        }
        [TestMethod()]
        public void TestMethod3()
        {
            Assert.IsFalse(Module03.Bai17(2023, 2, 30));
        }
        [TestMethod()]
        public void TestMethod4()
        {
            Assert.IsTrue(Module03.Bai17(2023, 8, 23));
        }
    }
}