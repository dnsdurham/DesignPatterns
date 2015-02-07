
namespace DesignPatterns.Creational.Webserver
{

    public interface IWebserverFactory
    {
        IRequestHandler GetRequestHandler();
    }

    public interface IRequestHandler
    {
        string ProcessRequest(string request);
    }
}
