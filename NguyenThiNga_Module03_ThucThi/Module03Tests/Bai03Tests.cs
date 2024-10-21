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
    public class Bai03Tests
    {
        [TestMethod()]
        public void TestMethod1()
        {
            double mean_actual;
            double mean_exp =8;
            int max_exp=9;
            int max_actual = Module03.Bai03(9, 8, 7, out mean_actual);

            Assert.AreEqual(max_exp,max_actual);
            Assert.AreEqual(mean_exp, mean_actual);
        }
        [TestMethod()]
        public void TestMethod2()
        {
            double mean_actual;
            double mean_exp = 9;
            int max_exp = 10;
            int max_actual = Module03.Bai03(9, 8, 10, out mean_actual);

            Assert.AreEqual(max_exp, max_actual);
            Assert.AreEqual(mean_exp, mean_actual);
        }
        [TestMethod()]
        public void TestMethod3()
        {
            double mean_actual;
            double mean_exp = 8;
            int max_exp = 9;
            int max_actual = Module03.Bai03(7,9,8, out mean_actual);

            Assert.AreEqual(max_exp, max_actual);
            Assert.AreEqual(mean_exp, mean_actual);
        }
        [TestMethod()]
        public void TestMethod4()
        {
            double mean_actual;
            double mean_exp = 8;
            int max_exp = 9;
            int max_actual = Module03.Bai03(7,8,9, out mean_actual);

            Assert.AreEqual(max_exp, max_actual);
            Assert.AreEqual(mean_exp, mean_actual);
        }
    }
}