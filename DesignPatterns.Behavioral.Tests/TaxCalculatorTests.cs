using System;
using DesignPatterns.Behavioral.Strategy.OrderProcessing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Behavioral.Tests
{
    [TestClass]
    public class TaxCalculatorTests
    {
        [TestMethod]
        public void UsTax_TaxAmount()
        {
            ICalculateTax taxCalculator = new UsTax();
   
            Assert.AreEqual(0.70m, taxCalculator.TaxAmount(2, 5.00m, false));
            Assert.AreEqual(27.96m, taxCalculator.TaxAmount(4, 99.87m, false));

        }

        [TestMethod]
        public void CanadianTax_TaxAmount()
        {
            ICalculateTax taxCalculator = new CanadianTax();

            Assert.AreEqual(1.50m, taxCalculator.TaxAmount(2, 5.00m, false));
            Assert.AreEqual(98.87m, taxCalculator.TaxAmount(4, 99.87m, false));

        }
    }
}
