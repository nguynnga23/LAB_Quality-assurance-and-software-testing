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
    public class Bai18Tests
    {
        [TestMethod()]
        public void TestMethod1()
        {
            Assert.IsFalse(Module03.Bai18("tranthiendatgmailcom"));
        }
        [TestMethod()]
        public void TestMethod2()
        {
            Assert.IsFalse(Module03.Bai18("tranthiendatgamail..com"));
        }
        [TestMethod()]
        public void TestMethod3()
        {
            Assert.IsFalse(Module03.Bai18("tranthiendat@@@gamail.com"));
        }
        [TestMethod()]
        public void TestMethod4()
        {
            Assert.IsFalse(Module03.Bai18("tranthiendat@.gamail.com"));
        }
        [TestMethod()]
        public void TestMethod5()
        {
            Assert.IsTrue(Module03.Bai18("tranthiendat@gmai.com"));
        }

    }
}