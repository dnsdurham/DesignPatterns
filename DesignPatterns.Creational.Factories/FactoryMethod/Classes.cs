using System;

namespace DesignPatterns.Creational.Factories.FactoryMethod
{
    class CessnaSingleEngine : IAirplane
    {
        public void Fly()
        {
            Console.WriteLine("Cessna SEL:  Flying, high wing, great view!");
        }
    }

    class CessnaMultiEngine : IAirplane
    {
        public void Fly()
        {
            Console.WriteLine("Cessna MEL:  Nice, smooth flight, FL180!");
        }
    }

    class PiperSingleEngine : IAirplane
    {
        public void Fly()
        {
            Console.WriteLine("Piper SEL:  Flying, low wing, great view!");
        }
    }

    class PiperMultiEnginePressurized : IAirplane
    {
        public void Fly()
        {
            Console.WriteLine("Piper MEL:  Nice, pressurized smooth flight, FL220!");
        }
    }

    //class CessnaCitation : IAirplane
    //{
    //    public void Fly()
    //    {
    //        Console.WriteLine("Cessna MEL:  Turbines rule!");
    //    }
    //}

}
