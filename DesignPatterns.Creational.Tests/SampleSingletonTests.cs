using System;
using System.Reflection;
using DesignPatterns.Creational.Singleton.Sample;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatterns.Creational.Tests
{
    [TestClass]
    public class SampleSingletonTests
    {
        /// <summary>
        /// This test method validates that two separate SampleSingleton 
        /// object variables are references to the same object
        /// </summary>
        [TestMethod]
        public void SampleSingleton_Instance()
        {
            SampleSingleton s1 = SampleSingleton.GetInstance;
            SampleSingleton s2 = SampleSingleton.GetInstance;

            // verify that both object variables are referencing same instance
            Assert.AreSame(s1, s2);

            // use the MyCounter to do a similar verification
            Assert.AreEqual(0, s1.MyCounter);
            s2.MyCounter = 7;
            Assert.AreEqual(7, s1.MyCounter);
        }

        /// <summary>
        /// This test method verifies that there are no ways to instantiate a
        /// SampleSingleton object through any sort of public constructor
        /// </summary>
        [TestMethod]
        public void SampleSingleton_NoPublicConstructors()
        {
            Type sampleSingleton = typeof (SampleSingleton);
            ConstructorInfo[] constructors = sampleSingleton.GetConstructors();
            bool hasPubliConstructor = false;
            foreach (var c in constructors)
            {
                if (c.IsPublic)
                {
                    hasPubliConstructor = true;
                    break;
                }
            }

            // verify that no public constructors are found
            Assert.IsFalse(hasPubliConstructor);
        }
    }
}
