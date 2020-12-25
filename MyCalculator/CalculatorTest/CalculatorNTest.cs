using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculator;
using System;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorNTest
    {
        [TestMethod]
        public void Calculator_Add_Std()
        {
            // Arrange
            Calculator calc = new Calculator();
            int a = 7;
            int b = 3;
            int expected_result = 10;

            // Act
            int result = calc.Add(a, b);

            // Assert
            Assert.AreEqual(expected_result+1, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(1, 0);
        }
        [TestMethod]
        public void TestMethod3()
        {
        }
    }
}
