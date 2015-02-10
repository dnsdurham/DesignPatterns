using System;

namespace DesignPatterns.Creational.Singleton.Webserver
{
    public class RequestHandler : IRequestHandler
    {
        public string ProcessRequest(string request)
        {
            // do something with the request
            // ...

            // log the request
            WebLogger log = WebLogger.GetInstance; // using classic Singleton access
            log.WriteEntry(DateTime.Now + " " + request);

            return "Request result";
        }
    }
}
