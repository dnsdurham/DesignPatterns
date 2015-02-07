using System;

namespace DesignPatterns.Creational.Webserver2
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
            IWebLogger2 logger = _factory.GetWebLogger();

            logger.WriteEntry(DateTime.Now + " " + request);

            return "Request result";
        }
    }
}
