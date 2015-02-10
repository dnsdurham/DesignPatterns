using DesignPatterns.Creational.Singleton.Webserver2;

namespace DesignPatterns.Creational.Tests.Mocks
{
    public class Webserver2FactoryMock : IWebserver2Factory
    {
        public IWebLogger2 WebLogger { get; set; }
       
        public IRequestHandler2 GetRequestHandler(IWebserver2Factory factory)
        {
            return new RequestHandler2(factory);
        }

        public IWebLogger2 GetWebLogger()
        {
            return WebLogger;
        }
    }
}
