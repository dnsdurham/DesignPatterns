
namespace DesignPatterns.Creational.Factories.FactoryMethod
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
