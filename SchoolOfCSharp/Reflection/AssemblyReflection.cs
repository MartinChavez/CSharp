using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reflection
{
    [TestClass]
    public class AssemblyReflection
    {
        [TestMethod]
        public void LoadAssemblyAtRuntime()
        {
            var loggerInstanciated = false;
            //You can load assemblies at runtime, Find all the Types from the dll and execute methods
            foreach (var logger in (from type in Assembly.GetExecutingAssembly().GetTypes() where type.GetInterface("ILogger") != null select Activator.CreateInstance(type)).OfType<ILogger>())
            {
                //You can load assemblies  execute methods
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
        public ConsoleLogger() //while loading dynamically this assembly, we can execute this method without an instance of ConsoleLogger, due to Reflection
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
