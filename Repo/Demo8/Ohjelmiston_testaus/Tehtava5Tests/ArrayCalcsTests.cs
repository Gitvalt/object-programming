using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tehtava5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava5.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {
        [TestMethod()]
        public void SumFTest()
        {
            double[] array = { 1.1, 2, 3, 4.4, 77, 5.6 };
            double expected = 93.1;

            double actual = ArrayCalcs.SumF(array);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AVGTest()
        {
            double[] array = { 1.1, 2, 3, 4.4, 77, 5.6 };
            double expected = 15.52;

            double actual = ArrayCalcs.AVG(array);
            actual = Math.Round(actual, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinTest()
        {
            double[] array = { 1.1, 2, 3, 4.4, 77, 5.6 };
            double expected = 1.1;

            double actual = ArrayCalcs.Min(array);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxTest()
        {
            double[] array = { 1.1, 2, 3, 4.4, 77, 5.6 };
            double expected = 77;

            double actual = ArrayCalcs.Max(array);
            Assert.AreEqual(expected, actual);
        }
    }
}