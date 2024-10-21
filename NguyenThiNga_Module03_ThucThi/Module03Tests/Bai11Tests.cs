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
    public class Bai11Tests
    {
        [TestMethod()]
        public void TestMethod1()
        {
            float w,h,ww,wh,x = float.NaN, y = float.NaN;

            w = 0;
            h = 3;
            ww = 4;
            wh = 6;
            Assert.IsFalse(Module03.Bai11(out  x, out  y,w,h,ww,wh));
            Assert.AreEqual(float.NaN, x);
            Assert.AreEqual(float.NaN, y);
        }
        [TestMethod()]
        public void TestMethod2()
        {
            float w, h, ww, wh, x = float.NaN, y = float.NaN;

            w = 8;
            h = 9;
            ww = 6;
            wh = 5;
            Assert.IsTrue(Module03.Bai11(out x, out y, w, h, ww, wh));
            Assert.AreEqual(0, x);
            Assert.AreEqual(0, y);
        }
        [TestMethod()]
        public void TestMethod3()
        {
            float w, h, ww, wh, x = float.NaN, y = float.NaN;

            w = 4;
            h = 5;
            ww = 10;
            wh = 13;
            Assert.IsTrue(Module03.Bai11(out x, out y, w, h, ww, wh));
            Assert.AreEqual(3, x);
            Assert.AreEqual(4, y);
        }
    }
}