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
    public class Bai20Tests
    {
        [TestMethod()]
        public void TestMethod1()
        {
            int expected = 1;
            int actual = Module03.Bai20('t');
            Assert.AreEqual(expected, actual);
        }
    }
}