using System;


namespace DesignPatterns.Creational.Factories.AbstractFactory2
{
    public class AfClient
    {
        private IResolutionFactory _factory;

        public AfClient(IResolutionFactory factory)
        {
            _factory = factory;
        }

        public void DoDraw()
        {
            IDisplayDriver driver = _factory.GetDisplayDriver();
            driver.Draw();
        }

        public void DoPrint()
        {
            IPrintDriver driver = _factory.GetPrintDriver();
            driver.Print();
        }
    }

    #region Driver Classes
    public class LowResDisplayDriver : IDisplayDriver
    {
        public void Draw()
        {
            Console.WriteLine("I am a LOW resolution drawing!");
        }
    }

    public class HiResDisplayDriver : IDisplayDriver
    {
        public void Draw()
        {
            Console.WriteLine("I am a HIGH resolution drawing!");
        }
    }

    public class LowResPrintDriver : IPrintDriver
    {
        public void Print()
        {
            Console.WriteLine("I am a LOW resolution print!");
        }
    }

    public class HiResPrintDriver : IPrintDriver
    {
        public void Print()
        {
            Console.WriteLine("I am a HIGH resolution print!");
        }
    }		 
    #endregion

}
