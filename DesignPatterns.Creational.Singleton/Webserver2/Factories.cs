
namespace DesignPatterns.Creational.Singleton.Webserver2
{
    public class Webserver2Factory : IWebserver2Factory
    {
        // We will ensure a single instance here
        private static WebLogger2 _logger = new WebLogger2();

        public IRequestHandler2 GetRequestHandler(IWebserver2Factory factory)
        {
            return new RequestHandler2(factory);
        }

        public IWebLogger2 GetWebLogger()
        {
            return _logger;
        }
    }
}
