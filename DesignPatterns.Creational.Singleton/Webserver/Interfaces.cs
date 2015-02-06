using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
