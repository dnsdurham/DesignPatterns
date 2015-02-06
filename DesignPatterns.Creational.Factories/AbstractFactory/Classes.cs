using System;

namespace DesignPatterns.Creational.Factories.AbstractFactory
{
    class CessnaSingleEngine : ISingleEngineAirplane
    {
        public void Fly()
        {
            Console.WriteLine("Cessna SEL:  Flying, high wing, great view!");
        }
    }

    class CessnaMultiEngine : IMultiEngineAirplane
    {
        public void Fly()
        {
            Console.WriteLine("Cessna MEL:  Nice, smooth flight, FL180!");
        }
    }

    class PiperSingleEngine : ISingleEngineAirplane
    {
        public void Fly()
        {
            Console.WriteLine("Piper SEL:  Flying, low wing, great view!");
        }
    }

    class PiperMultiEngine : IMultiEngineAirplane
    {
        public void Fly()
        {
            Console.WriteLine("Piper MEL:  Nice, smooth flight, FL220!");
        }
    }
}
