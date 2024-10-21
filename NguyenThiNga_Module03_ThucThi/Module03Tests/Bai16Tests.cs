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
    public class Bai16Tests
    {
        [TestMethod()]
        public void TestMethod1()
        {
            Assert.IsFalse(Module03.Bai16("abc"));
        }
        [TestMethod()]
        public void TestMethod2()
        {
            Assert.IsFalse(Module03.Bai16("abcdllklafdasdfdaf"));
        }
        [TestMethod()]
        public void TestMethod3()
        {
            Assert.IsFalse(Module03.Bai16("abcdefg"));
        }
        [TestMethod()]
        public void TestMethod4()
        {
            Assert.IsTrue(Module03.Bai16("12abcd3e"));
        }

    }
}