
using System;

namespace DesignPatterns.Behavioral.Strategy.OrderProcessing
{
    public class UsTax : ICalculateTax
    {
        public decimal TaxAmount(long itemSold, decimal price, bool isFood)
        {
            // Normally, would implement some Canada-specific tax logic 
            // and return the value.
            // For this example we simply return a multiple of 
            // the itemSold and price and 7% but only if it is not food
            if (isFood)
            {
                // don't charge tax for food
                return 0.00m;
            }
            // charge 7% for non-food items
            return Decimal.Round(itemSold * price * 0.07m, 2);
        }
    }

    public class CanadianTax : ICalculateTax
    {
        public decimal TaxAmount(long itemSold, decimal price, bool isFood)
        {
            // Normally, would implement some Canada-specific tax logic 
            // and return the value.
            // For this example we use a scaled rate to demonstrate
            // more complex tax rules
            // NOTE: that isFood is not used in this particular variation
            if ((price * itemSold) <= 10.00m)
            {
                // use a flat rate for low value amounts
                return Decimal.Round(itemSold * price * 0.15m, 2);
            }
            // otherwise, charge 15% for the first 10.00 and 25% for remaing amount
            return Decimal.Round(1.50m + (((price * itemSold) - 10.00m) * 0.25m), 2);
        }
    }


}
