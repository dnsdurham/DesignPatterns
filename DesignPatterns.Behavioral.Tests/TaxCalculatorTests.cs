using System;
using DesignPatterns.Behavioral.Strategy.OrderProcessing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Behavioral.Tests
{
    [TestClass]
    public class TaxCalculatorTests
    {
        /// <summary>
        /// Verify the US Tax Rules algorithm
        /// </summary>
        [TestMethod]
        public void UsTax_TaxAmount()
        {
            ICalculateTax taxCalculator = new UsTax();
   
            // test for non food items
            Assert.AreEqual(0.70m, taxCalculator.TaxAmount(2, 5.00m, false));
            Assert.AreEqual(27.96m, taxCalculator.TaxAmount(4, 99.87m, false));

            // test for food items
            Assert.AreEqual(0.00m, taxCalculator.TaxAmount(2, 5.00m, true));
        }

        /// <summary>
        /// Verify the Canadian Tax Rules algorithm
        /// </summary>
        [TestMethod]
        public void CanadianTax_TaxAmount()
        {
            ICalculateTax taxCalculator = new CanadianTax();

            Assert.AreEqual(1.50m, taxCalculator.TaxAmount(2, 5.00m, false));
            Assert.AreEqual(98.87m, taxCalculator.TaxAmount(4, 99.87m, false));

            // verify that food status is ignored
            Assert.AreEqual(1.50m, taxCalculator.TaxAmount(2, 5.00m, true));
            Assert.AreEqual(98.87m, taxCalculator.TaxAmount(4, 99.87m, true));
        }
    }
}
