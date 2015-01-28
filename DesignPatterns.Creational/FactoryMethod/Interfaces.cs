using System;
using System.Collections.Generic;

namespace DesignPatterns.Creational.FactoryMethod
{
    public interface IAirplane
    {
        void Fly();
    }

    public interface IAirplaneFactory
    {
        IAirplane Create(AirplaneType type);
    }
}
