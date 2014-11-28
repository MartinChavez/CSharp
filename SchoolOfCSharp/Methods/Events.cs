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

        [TestMethod]
        public void Delegate()
        {
            var logger = new Logger();
            var write = new WriteMessage(logger.WriteMessage); //The method you will execute is the parameter
            var result = write("Use");

            Assert.AreEqual(result, "UseDelegate");
        }
    }
}
