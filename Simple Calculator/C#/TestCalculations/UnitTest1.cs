using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCalculations
{
    [TestClass]
    public class UnitTest1
    {
        private Calculator.CalculatorSoapClient calcRef;

        [TestMethod]
        public void TestAdd()
        {
            calcRef = new Calculator.CalculatorSoapClient();
            double d = calcRef.Add(2.0, 2.0);
            Assert.AreEqual(d, 4.0);

        }

        [TestMethod]
        public void TestSubtract()
        {
            calcRef = new Calculator.CalculatorSoapClient();
            double d = calcRef.Subtract(2.0, 2.0);
            Assert.AreEqual(d, 0.0);

        }

        [TestMethod]
        public void TestMultiply()
        {
            calcRef = new Calculator.CalculatorSoapClient();
            double d = calcRef.Multiply(2.0, 2.0);
            Assert.AreEqual(d, 4.0);

        }

        [TestMethod]
        public void TestDivide()
        {
            calcRef = new Calculator.CalculatorSoapClient();
            double d = calcRef.Divide(2.0, 2.0);
            Assert.AreEqual(d, 1.0);

        }

        [TestMethod]
        public void TestSquareRoot()
        {
            calcRef = new Calculator.CalculatorSoapClient();
            double d = calcRef.SquareRoot(9.0);
            Assert.AreEqual(d, 3.0);

        }

        [TestMethod]
        public void TestHalve()
        {
            calcRef = new Calculator.CalculatorSoapClient();
            double d = calcRef.Halve(2.0);
            Assert.AreEqual(d, 1.0);

        }

        [TestMethod]
        public void TestQuarter()
        {
            calcRef = new Calculator.CalculatorSoapClient();
            double d = calcRef.Quarter(4.0);
            Assert.AreEqual(d, 1.0);

        }

    }
}
