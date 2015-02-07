using System;

namespace DesignPatterns.Creational.Factories.FactoryMethod
{
    public class AirplaneFactory : IAirplaneFactory
    {
        public IAirplane Create(AirplaneType type)
        {
            switch (type)
            {
                case AirplaneType.CessnaSingleEngine: 
                    return new CessnaSingleEngine();
                case AirplaneType.CessnaMultiEngine: 
                    return new CessnaMultiEngine();
                case AirplaneType.PiperSingleEngine:
                    return new PiperSingleEngine();
                case AirplaneType.PiperMultiEnginePressurized:
                    return new PiperMultiEnginePressurized();
                //case AirplaneType.CessnaCitation:
                //    return new CessnaCitation();
                default: 
                    throw new Exception("Unknown Aircraft Type!");
            }
        }
    }
}
