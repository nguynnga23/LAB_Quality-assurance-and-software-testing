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
    public class Bai21Tests
    {
        [TestMethod()]
        public void TestMethod1()
        {
            long expected = 427;
            long actual = Module03.Bai21("1aBx");
            Assert.AreEqual(expected, actual);
        }
    }
}