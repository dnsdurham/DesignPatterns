
namespace DesignPatterns.Creational.Singleton.Webserver2
{
    public interface IWebserver2Factory
    {
        IRequestHandler2 GetRequestHandler(IWebserver2Factory factory);

        IWebLogger2 GetWebLogger();
    }

    public interface IRequestHandler2
    {
        string ProcessRequest(string request);
    }

    public interface IWebLogger2
    {
        void WriteEntry(string logLine);
    }
}
