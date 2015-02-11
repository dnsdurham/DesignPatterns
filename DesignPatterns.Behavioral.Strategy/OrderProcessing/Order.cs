
using System;
namespace DesignPatterns.Behavioral.Strategy.OrderProcessing
{
    public class Order : IOrder
    {
        public decimal Process(ICalculateTax taxCalculator)
        {
            // hardcoding some quantities and prices for this example
            long itemNumber = 3;
            decimal itemPrice = 7.99m; // pretending that the price is the same in all currencies :)
            bool isFood = false;

            // Lots of other order pre-processing going on here...
            // ...

            // Calculate the tax
            decimal tax = taxCalculator.TaxAmount(itemNumber, itemPrice, isFood);

            // Lots of order payment processing and receipt generation going on here...
            // ...

            Console.WriteLine("Total tax amount on 23.97 is: {0}", tax);

            return (itemNumber * itemPrice) + tax;
        }
    }
}
