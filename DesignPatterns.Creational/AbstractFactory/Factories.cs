
namespace DesignPatterns.Creational.AbstractFactory
{
    public class CessnaFactory : IAirplaneFactory
    {
        public ISingleEngineAirplane CreateSingleEngine()
        {
            return new CessnaSingleEngine();
        }

        public IMultiEngineAirplane CreateMultiEngine()
        {
            return new CessnaMultiEngine();
        }
    }

    public class PiperFactory : IAirplaneFactory
    {
        public ISingleEngineAirplane CreateSingleEngine()
        {
            return new PiperSingleEngine();
        }

        public IMultiEngineAirplane CreateMultiEngine()
        {
            return new PiperMultiEngine();
        }
    }
}
