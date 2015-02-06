using System;
using DesignPatterns.Creational.Webserver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Creational.Tests
{
    [TestClass]
    public class Webserver2Tests
    {
        [TestMethod]
        public void Webserver_WriteLogLines()
        {
            WebLogger log = WebLogger.GetInstance;
            log.WriteEntry("Hello world!");   
        }
    }
}
