using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;  // Make sure to add this
using System;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAddition()
        {
            double result = Calculator.Calculate(5, '+', 3);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            double result = Calculator.Calculate(10, '-', 4);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            double result = Calculator.Calculate(6, '*', 7);
            Assert.AreEqual(42, result);
        }

        [TestMethod]
        public void TestDivision()
        {
            double result = Calculator.Calculate(20, '/', 5);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivisionByZero()
        {
            Calculator.Calculate(10, '/', 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidOperator()
        {
            Calculator.Calculate(10, '%', 2);
        }
    }
}
