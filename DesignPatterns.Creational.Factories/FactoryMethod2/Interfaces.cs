
namespace DesignPatterns.Creational.Factories.FactoryMethod2
{
    public interface IMyDbFactory
    {
        IDbObject Create(FacDbType type);
    }

    public interface IDbObject
    {
        void OpenDatabase();
        string GetData();
        void CloseDatabase();
    }
}
