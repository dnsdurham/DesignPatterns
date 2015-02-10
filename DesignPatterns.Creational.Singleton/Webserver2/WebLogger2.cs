using System.IO;

namespace DesignPatterns.Creational.Singleton.Webserver2
{
    public class WebLogger2 : IWebLogger2
    {
        static readonly object _locker = new object(); // used for synchronization

        public void WriteEntry(string logLine)
        {
            lock (_locker) // need to synchronize thread access to this method
            {
                using (StreamWriter logFile = new StreamWriter(@"webserver2log.txt", true))
                {
                    logFile.WriteLine(logLine);
                }
            }
        }
    }
}
