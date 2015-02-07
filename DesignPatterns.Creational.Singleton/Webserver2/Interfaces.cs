using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Webserver2
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
