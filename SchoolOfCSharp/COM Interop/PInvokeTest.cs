using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace COM_Interop
{
    [TestClass]
    public class PInvokeTest
    {
        [TestMethod]
        public void PInvoke()//This method calls into the Windows API and unmanaged code
        {
           NativeBeep.Beep();
        }
    }

    public static class NativeBeep
    {
        public static void Beep()
        {
            MessageBeep(0);
        }

        [DllImport("User32.dll")] //DllImport attribute allows us to load an assembly
        private static extern Boolean MessageBeep(UInt32 beepType); //We can define the method we want to  use to execute the WIN API action
    }
}
