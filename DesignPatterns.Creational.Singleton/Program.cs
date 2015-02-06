using DesignPatterns.Creational.Webserver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    class Program
    {
        static void Main()
        {
            bool exitApp = false;
            // get the first menu selection
            int menuSelection = InitConsoleMenu();

            while (menuSelection != 99)
            {
                switch (menuSelection)
                {
                    case 1: // Run Webserver Scenario
                        RunWebserver(new WebserverFactory());
                        break;
                    case 2: // Run Webserver2 Scenario
                        //RunWebserver2(new HiResFactory());
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

        private static void RunWebserver(IWebserverFactory webServerFactory)
        {
            // create a couple of handlers
            IRequestHandler handler1 = webServerFactory.GetRequestHandler();
            IRequestHandler handler2 = webServerFactory.GetRequestHandler();

            Task.Factory.StartNew(WebserverRequestSimulator1, handler1);
            Task.Factory.StartNew(WebserverRequestSimulator2, handler2);
        }

        private static void WebserverRequestSimulator1(Object name)
        {
            IRequestHandler handler = (IRequestHandler)name;
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                handler.ProcessRequest(String.Format("Requests {0} from handler {1}", i, "1"));
                // pause for a random number of milliseconds
                Thread.Sleep(1000 * rand.Next(3));
            }
        }

        private static void WebserverRequestSimulator2(Object name)
        {
            IRequestHandler handler = (IRequestHandler)name;
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                handler.ProcessRequest(String.Format("Requests {0} from handler {1}", i, "2"));
                // pause for a random number of milliseconds
                Thread.Sleep(1000 * rand.Next(3));
            }
        }

        private static int InitConsoleMenu()
        {
            int result;

            Console.WriteLine("");
            Console.WriteLine("Select desired option:");
            Console.WriteLine(" 1: Run Webserver");
            Console.WriteLine(" 2: Run Webserver 2");
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
