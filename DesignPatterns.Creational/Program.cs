using System;
using DesignPatterns.Creational.AbstractFactory2;
using DesignPatterns.Creational.FactoryMethod2;

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
                    case 1: // Run Abstract Factory - Low Res
                        RunDriverScenario(new LowResFactory());
                        break;
                    case 2: // Run Abstract Factory Method - Hi Res
                        RunDriverScenario(new HiResFactory());
                        break;
                    case 3: // Run Factory Method for Oracle
                        RunDatabaseScenario(FacDbType.Oracle);
                        break;
                    case 4: // Run Factory Method for Sql Server
                        RunDatabaseScenario(FacDbType.SqlServer);
                        break;
                    case 5: // Run Factory Method for PostGres
                        RunDatabaseScenario(FacDbType.PostGres);
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


        #region Abstract Factory

        private static void RunDriverScenario(IResolutionFactory factory)
        {
            AfClient client = new AfClient(factory);

            client.DoDraw();
            client.DoPrint();
        }
        #endregion

        #region Factory Method

        private static void RunDatabaseScenario(FacDbType db)
        {
            FacClient client = new FacClient(new MyMyDbFactory());
            client.GetTheData(db);
        }
        #endregion

        #region Extras
        private static void RunAirplaneAbFAcClient(AbstractFactory.IAirplaneFactory factory)
        {

            AbstractFactory.ISingleEngineAirplane singleEngine;
            AbstractFactory.IMultiEngineAirplane multiEngine;

            Console.WriteLine("Creating Single engine...");

            singleEngine = factory.CreateSingleEngine();

            singleEngine.Fly();

            Console.WriteLine("Creating multi-engine...");

            multiEngine = factory.CreateMultiEngine();

            multiEngine.Fly();
        }

        private static void FaClient()
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

        #endregion

        private static int InitConsoleMenu()
        {
            int result;
 
            Console.WriteLine("");
            Console.WriteLine("Select desired option:");
            Console.WriteLine(" 1: Abstract Factory - Low Res");
            Console.WriteLine(" 2: Abstract Factory - Hi Res");
            Console.WriteLine(" 3: Factory Method - Oracle");
            Console.WriteLine(" 4: Factory Method - Sql Server");
            Console.WriteLine(" 5: Factory Method - PostGres");
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
