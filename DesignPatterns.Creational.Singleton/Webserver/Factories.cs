using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
