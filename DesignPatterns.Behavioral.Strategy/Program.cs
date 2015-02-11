using System;
using DesignPatterns.Behavioral.Strategy.OrderProcessing;

namespace DesignPatterns.Behavioral.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitApp = false;
            // get the first menu selection
            int menuSelection = InitConsoleMenu();

            while (menuSelection != 99)
            {
                switch (menuSelection)
                {
                    case 1: // Run US Order Scenario
                        ProcessOrder(new UsTax());
                        break;
                    case 2: // Run Canadian Order Scenario
                        ProcessOrder(new CanadianTax());
                        break;
                    case 99:
                        exitApp = true;
                        break;
                }

                // check to see if we want to exit the app
                if (exitApp)
                {
                    break; // exit the while loop
                }

                // re-initialize the menu selection
                menuSelection = InitConsoleMenu();
            }
        }

        private static void ProcessOrder(ICalculateTax taxCalculator)
        {
            IOrder order = new Order(); // NOTE: We would normally use a factory or something to create the Order class
            decimal total = order.Process(taxCalculator);
            
        }

        private static int InitConsoleMenu()
        {
            int result;

            Console.WriteLine("");
            Console.WriteLine("Select desired option:");
            Console.WriteLine(" 1: Run US Order");
            Console.WriteLine(" 2: Run Canadian Order");
            Console.WriteLine("99: exit");
            string selection = Console.ReadLine();
            if (int.TryParse(selection, out result) == false)
            {
                result = 0;
            }

            return result;
        }

    }
}
