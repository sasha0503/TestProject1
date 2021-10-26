using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void EvaluateTestExponent()
        {
            Assert.AreEqual(Calculator.Evaluate("0 ^ 0"), 1);
            Assert.AreEqual(Calculator.Evaluate("1 ^ 10"), 1);
            Assert.AreEqual(Calculator.Evaluate("10 ^ 1"), 10);
            Assert.AreEqual(Calculator.Evaluate("10 ^ 2"), 100);
            Assert.AreEqual(Calculator.Evaluate("10 ^ 0"), 1);
        }

        [TestMethod()]
        public void EvaluateTestSubtract()
        {
            Assert.AreEqual(Calculator.Evaluate("0-4"), -4);
            Assert.AreEqual(Calculator.Evaluate("-1-1"), -2);
            Assert.AreEqual(Calculator.Evaluate("2-2*2"), -2);
            Assert.AreEqual(Calculator.Evaluate("2-2+2"), 2);
            Assert.AreEqual(Calculator.Evaluate("-(102+2)"), -104);
        }
        [TestMethod()]
        public void EvaluateTestMod()
        {
            Assert.AreEqual(Calculator.Evaluate("12 mod 2"), 0);
            Assert.AreEqual(Calculator.Evaluate("13 mod 2"), 1);
            Assert.IsTrue(Math.Abs(Calculator.Evaluate("13.1 mod 2") - 1.1) < 0.1);
            Assert.AreEqual(Calculator.Evaluate("0 mod 2"), 0);
            Assert.AreEqual(Calculator.Evaluate("13 mod -2"), 1);
        }
    }
}
