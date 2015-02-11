
using System;
using System.Text;

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

        #region Process Using Switches
         //public enum OrderCountryType
        //{
        //    US,
        //    Canada,
        //    Germany,
        //    England
        //}
        //public decimal Process()
        //{
        //    var orderCountry = OrderCountryType.US;
        //    bool inQuebec = true;

        //    // Order processing logic here...
        //    // ...
        //    // Handle tax rules...
        //    switch (orderCountry)
        //    {
        //        case OrderCountryType.US:
        //            // implement US Tax rules here
        //            break;
        //        case OrderCountryType.Canada:
        //            // Implement Canada tax rules here
        //            break;
        //        case OrderCountryType.Germany:
        //            // Implement Euro tax rules here
        //            break;
        //    }
        //    //Handle language rules...
        //    switch (orderCountry)
        //    {
        //        case OrderCountryType.US:
        //        case OrderCountryType.Canada:
        //            if (inQuebec)
        //            {
        //                // use French
        //                // ReSharper disable once RedundantJumpStatement
        //                break;
        //            }
        //            // use English
        //            break;
        //        case OrderCountryType.Germany:
        //            // Use German
        //            break;
        //    }
        //    // ...
        //    // More order processing logic here...

        //    return 0.00m;
        //}
       
        #endregion
    }
}
