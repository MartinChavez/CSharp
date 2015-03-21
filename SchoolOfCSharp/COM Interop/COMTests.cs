using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SKYPE4COMLib;

namespace COM_Interop
{
    [TestClass]
    public class ComTests
    {
        [TestMethod]
        [ExpectedException(typeof(System.Runtime.InteropServices.COMException), "System.Runtime.InteropServices.COMException")] //It will throw if you don't have an skype Instance running
        public void SkypeComCalls()//This method will make COM calls to a running instance of Skype
        {
            var skypeClass = new Skype();//Note: On the running instance of Skype,you will get a message saying that another application wants to access Skype
            var currentUser = skypeClass.CurrentUser;//You can interact with the COM object and execute methods and properties
            Assert.IsNotNull(currentUser.FullName);//My skype name is being retrieved at runtime
        }
    }
}
