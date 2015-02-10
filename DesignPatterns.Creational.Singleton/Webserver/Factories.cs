
namespace DesignPatterns.Creational.Singleton.Webserver
{
    public class WebserverFactory : IWebserverFactory
    {
        public IRequestHandler GetRequestHandler()
        {
            return new RequestHandler();
        }

    }
}
