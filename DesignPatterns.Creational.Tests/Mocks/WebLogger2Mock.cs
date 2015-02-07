using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Creational.Webserver2;

namespace DesignPatterns.Creational.Tests.Mocks
{
    public class WebLogger2Mock : IWebLogger2
    {
        private List<String> _logEntries = new List<string>();

        public List<string> LogEntries
        {
            get
            {
                return _logEntries;   
            }
        }

        public void WriteEntry(string logLine)
        {
            // save the entry in an internal array
            _logEntries.Add(logLine);
        }
    }
}
