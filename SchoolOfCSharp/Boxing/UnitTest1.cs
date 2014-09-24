using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Boxing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Boxing()
        {
            int Integer = 5;
            object Object = Integer;
        }
    }
}
