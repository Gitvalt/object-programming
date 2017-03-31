using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ohjelmiston_testaus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohjelmiston_testaus.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            // arrange
            Calculator calc = new Calculator();
            int number1 = 5;
            int number2 = 7;
            int expected = 12;

            // act
            int actual = calc.Add(number1, number2);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            // arrange
            Calculator calc = new Calculator();
            int number1 = 5;
            int number2 = 7;
            int expected = 35;

            // act
            int actual = calc.Multiply(number1, number2);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DivideTest()
        {
            Calculator calc = new Calculator();

            int number1 = 5;
            int number2 = 7;
            int result = number1 / number2;

            int actual = calc.Divide(number1, number2);

            Assert.AreEqual(result,actual);

        }
    }
}