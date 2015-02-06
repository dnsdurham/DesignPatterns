

namespace DesignPatterns.Creational.Factories.AbstractFactory2
{
    public interface IDisplayDriver
    {
        void Draw();
    }

    public interface IPrintDriver
    {
        void Print();
    }

    public interface IResolutionFactory
    {
        IDisplayDriver GetDisplayDriver();
        IPrintDriver GetPrintDriver();
    }
}
