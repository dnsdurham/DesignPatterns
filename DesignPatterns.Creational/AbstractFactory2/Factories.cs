

namespace DesignPatterns.Creational.Factories.AbstractFactory2
{
    public class LowResFactory : IResolutionFactory
    {
        public IDisplayDriver GetDisplayDriver()
        {
            return new LowResDisplayDriver();
        }

        public IPrintDriver GetPrintDriver()
        {
            return new LowResPrintDriver();
        }
    }

    public class HiResFactory : IResolutionFactory
    {
        public IDisplayDriver GetDisplayDriver()
        {
            return new HiResDisplayDriver();
        }

        public IPrintDriver GetPrintDriver()
        {
            return new HiResPrintDriver();
        }
    }
}
