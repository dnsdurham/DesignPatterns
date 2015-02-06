
namespace DesignPatterns.Creational.Singleton
{
    public class SampleSingleton
    {
        // static instance of the singleton
        //private static SampleSingleton _instance = null; // not thread-safe
        private static SampleSingleton _instance = new SampleSingleton(); // thread-safe
        
        // private constructor
        private SampleSingleton()
        {
        }

        // public accessor to get the instance
        public static SampleSingleton GetInstance
        {
            get
            {
                //if (_instance == null) // not thread-safe
                //{
                //    _instance = new SampleSingleton();
                //}
                return _instance;
            }
        }

        public int MyCounter { get; set; }
    }
}
