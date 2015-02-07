using System;
using DesignPatterns.Creational.Tests.Mocks;
using DesignPatterns.Creational.Webserver;
using DesignPatterns.Creational.Webserver2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Creational.Tests
{
    [TestClass]
    public class Webserver2Tests
    {
        /// <summary>
        /// This test method validates that two separate SampleSingleton 
        /// object variables are references to the same object
        /// </summary>
        [TestMethod]
        public void Webserver2_VerifyLoggerSingleton()
        {
            IWebserver2Factory factory1 = new Webserver2Factory();
            IWebserver2Factory factory2 = new Webserver2Factory();

            IWebLogger2 logger1 = factory1.GetWebLogger();
            IWebLogger2 logger2 = factory2.GetWebLogger();

            //verify that both object variables are referencing same instance
            Assert.AreSame(logger1, logger2);
        }

        /// <summary>
        /// This test method verifies that the request handler 
        /// properly writes requests to the designated log
        /// </summary>
        [TestMethod]
        public void Webserver2_WriteLogLines()
        {
            // create a mock factory that will use our mock logger
            Webserver2FactoryMock factory = new Webserver2FactoryMock();

            // create an instance of our mock logger and add to our factory
            WebLogger2Mock logger = new WebLogger2Mock();
            factory.WebLogger = logger;

            // test the handler
            IRequestHandler2 handler = new RequestHandler2(factory);

            handler.ProcessRequest("Test Request");

            string[] entries = logger.LogEntries.ToArray();
            
            Assert.IsTrue(entries.Length == 1);
            Assert.IsTrue(entries[0].Contains("Test Request"))
            ;
        }
    }
}
