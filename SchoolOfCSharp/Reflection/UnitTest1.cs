using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reflection
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LoadAssemblyAtRuntime()
        {
            var loggerInstanciated = false;
            //You can load assemblies at runtime and create Types
            foreach (var logger in (from type in Assembly.GetExecutingAssembly().GetTypes() where type.GetInterface("ILogger") != null select Activator.CreateInstance(type)).OfType<ILogger>())
            {
                //You can  execute methods at runtime as well
                logger.LogMessage("Complete");
                loggerInstanciated = logger.LoggerInstanciated();
            }

            Assert.IsTrue(loggerInstanciated);
        }
    }

    public interface ILogger
    {
        void LogMessage(String message);
        bool LoggerInstanciated();

    }

    public class ConsoleLogger : ILogger
    {
        public ConsoleLogger()
        {
            Debug.WriteLine("ConsoleLogger created");
        }

        public bool LoggerInstanciated()
        {
            return true;
        }

        public void LogMessage(string message)
        {
            Debug.WriteLine(message);
        }
    }

}
