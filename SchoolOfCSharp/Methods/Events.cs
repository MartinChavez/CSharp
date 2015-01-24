using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods
{
    [TestClass]
    public class Events
    {
        public delegate string WriteMessage(string message); //Delegate is a special type that references methods and has a method signature

        public class Logger
        {
            public string WriteMessage(String message)
            {
                return String.Format("{0}{1}", message, "Delegate");
            }
        }

        public class BetterLogger
        {
            public string WriteMessage(String message)
            {
                return String.Format("{0}{1}", message, "Delegate with Better");
            }
        }


        [TestMethod]
        public void UseDelegate()
        {
            var logger = new Logger();
            var write = new WriteMessage(logger.WriteMessage); //The method you will execute is the parameter
            var result = write("Use");//Once you subscribed to the method, you can use the delegate

            Assert.AreEqual(result, "UseDelegate");
        }

        [TestMethod]
        public void UseSeveralDelegates()
        {
            var logger = new Logger();
            var betterLogger = new BetterLogger();

            var write = new WriteMessage(logger.WriteMessage); 

            var result = write("Use");

            write += betterLogger.WriteMessage; // The delegate can subscribe to another method

            var betterResult = write("Use");//Once you subscribed to the new  method, you can use the delegate

            Assert.AreEqual(betterResult, "UseDelegate with Better");
        }

        [TestMethod]
        public void SubscribeToEvents()
        {
            var logger = new Logger();
            var write = new WriteMessage(logger.WriteMessage); //The method you will execute is the parameter
            var result = write("Use");//Once you subscribed to the method, you can use the delegate

            Assert.AreEqual(result, "UseDelegate");
        }
    }
}
