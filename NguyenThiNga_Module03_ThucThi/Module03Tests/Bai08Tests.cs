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
    public class Bai08Tests
    {
        [TestMethod()]
        public void TestMethod1()
        {
            float a, b, c, x1=float.NaN, x2=float.NaN;

            a = 0;
            b = 4;
            c = 8;
            Assert.IsTrue(Module03.Bai08(a, b, c, out x1, out x2));
            Assert.AreEqual(-2, x1);
            Assert.AreEqual(float.NaN, x2);
        }
        [TestMethod()]
        public void TestMethod2()
        {
            float a, b, c, x1 = float.NaN, x2 = float.NaN;

            a = 9;
            b = 2;
            c = 3;
            Assert.IsFalse(Module03.Bai08(a, b, c, out x1, out x2));
            Assert.AreEqual(float.NaN, x1);
            Assert.AreEqual(float.NaN, x2);
        }
        [TestMethod()]
        public void TestMethod3()
        {
            float a, b, c, x1 = float.NaN, x2 = float.NaN;

            a = 4;
            b = 4;
            c = 1;
            Assert.IsTrue(Module03.Bai08(a, b, c, out x1, out x2));
            Assert.AreEqual(-0.5, x1);
            Assert.AreEqual(-0.5, x2);
        }
        [TestMethod()]
        public void TestMethod4()
        {
            float a, b, c, x1 = float.NaN, x2 = float.NaN;

            a = 1;
            b = -5;
            c = 4;
            Assert.IsTrue(Module03.Bai08(a, b, c, out x1, out x2));
            Assert.AreEqual(4, x1);
            Assert.AreEqual(1, x2);
        }
    }
}