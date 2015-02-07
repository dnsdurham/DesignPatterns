
namespace DesignPatterns.Creational.Webserver
{
    public class WebserverFactory : IWebserverFactory
    {
        public IRequestHandler GetRequestHandler()
        {
            return new RequestHandler();
        }

    }
}
