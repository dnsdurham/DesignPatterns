using System;

namespace DesignPatterns.Creational.Singleton.Webserver2
{
    public class RequestHandler2 : IRequestHandler2
    {
        private IWebserver2Factory _factory;

        public RequestHandler2(IWebserver2Factory factory)
        {
            _factory = factory;
        }
        public string ProcessRequest(string request)
        {
            // do something with the request
            // ...

            // log the request
            IWebLogger2 logger = _factory.GetWebLogger(); // using Factory Method

            logger.WriteEntry(DateTime.Now + " " + request);

            return "Request result";
        }
    }
}
