using System;

namespace DesignPatterns.Creational
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
                    case 1: // Run Abstract Factory
                        RunAbstractFactory();
                        break;
                    case 2: // Run Factory Method
                        RunFactoryMethod();
                        break;
                    case 3: // Run Service Locator
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

        private static void RunFactoryMethod()
        {
            FactoryMethod.AirplaneFactory airplaneFactory = new FactoryMethod.AirplaneFactory();

            FactoryMethod.IAirplane airplane;

            Console.WriteLine("Creating Cessna SE...");

            airplane = airplaneFactory.Create(FactoryMethod.AirplaneType.CessnaSingleEngine);

            airplane.Fly();

            Console.WriteLine("Creating Piper ME...");

            airplane = airplaneFactory.Create(FactoryMethod.AirplaneType.PiperMultiEnginePressurized);

            airplane.Fly();

            //Console.WriteLine("Creating Cessna Citation...");

            //airplane = airplaneFactory.Create(FactoryMethod.AirplaneType.CessnaCitation);

            //airplane.Fly();

        }

        private static void RunAbstractFactory()
        {
            AbstractFactory.CessnaFactory cessnaFactory = new AbstractFactory.CessnaFactory();
            AbstractFactory.PiperFactory piperFactory = new AbstractFactory.PiperFactory();

            AbstractFactory.ISingleEngineAirplane singleEngine;
            AbstractFactory.IMultiEngineAirplane multiEngine;

            Console.WriteLine("Creating Cessna SE, Piper ME...");

            singleEngine = cessnaFactory.CreateSingleEngine();
            multiEngine = piperFactory.CreateMultiEngine();

            singleEngine.Fly();
            multiEngine.Fly();

            Console.WriteLine("Creating Piper SE, Cessna ME...");

            singleEngine = piperFactory.CreateSingleEngine();
            multiEngine = cessnaFactory.CreateMultiEngine();

            singleEngine.Fly();
            multiEngine.Fly();
        }

        private static int InitConsoleMenu()
        {
            int result;
 
            Console.WriteLine("");
            Console.WriteLine("Select desired option:");
            Console.WriteLine(" 1: Abstract Factory");
            Console.WriteLine(" 2: Factory Method");
            Console.WriteLine(" 3: Service Locator");
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
