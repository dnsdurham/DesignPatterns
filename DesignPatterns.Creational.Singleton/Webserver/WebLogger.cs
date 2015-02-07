using System.IO;

namespace DesignPatterns.Creational.Webserver
{
    /// <summary>
    /// This class implements a webservers logfile writing as a class Singleton
    /// </summary>
    public class WebLogger
    {
        private static WebLogger _instance = new WebLogger();
        static readonly object _locker = new object(); // used for synchronization
        private WebLogger()
        {
        }

        public static WebLogger GetInstance
        {
            get
            {
                return _instance;
            }
        }

        public void WriteEntry(string logLine)
        {
            lock (_locker) // need to synchronize thread access to this method
            {
                using (StreamWriter logFile = new StreamWriter(@"webserverlog.txt", true))
                {
                    logFile.WriteLine(logLine);
                }
            }
        }
    }
}
