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
    public class Bai15Tests
    {
        [TestMethod()]
        public void TestMethod1()
        {
            Assert.IsFalse(Module03.Bai15(10));
        }
        [TestMethod()]
        public void TestMethod2()
        {
            Assert.IsTrue(Module03.Bai15(2000));
        }
        [TestMethod()]
        public void TestMethod3()
        {
            Assert.IsFalse(Module03.Bai15(2100));
        }
        [TestMethod()]
        public void TestMethod4()
        {
            Assert.IsTrue(Module03.Bai15(2024));
        }
        [TestMethod()]
        public void TestMethod5()
        {
            Assert.IsFalse(Module03.Bai15(2023));
        }

    }
}