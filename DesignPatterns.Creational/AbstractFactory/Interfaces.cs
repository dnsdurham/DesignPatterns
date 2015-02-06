
namespace DesignPatterns.Creational.Factories.AbstractFactory
{
    public interface ISingleEngineAirplane
    {
        void Fly();
    }

    public interface IMultiEngineAirplane
    {
        void Fly();
    }

    public interface IAirplaneFactory
    {
        ISingleEngineAirplane CreateSingleEngine();
        IMultiEngineAirplane CreateMultiEngine();
    }
}
