using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Boxing
{
    [TestClass]
    public class BoxingTests
    {
        [TestMethod]
        public void Boxing()
        {
            int Integer = 5;
            object Object = Integer; //This is known as boxing, we create a reference of the integer value on the heap

            Assert.IsInstanceOfType(Object, typeof(object));
        }

        public void UnBoxing()
        {
            Object integer = 5;
            int Object = (int)integer; //This is known as unboxing, we create a local var with the value of Object

            Assert.IsInstanceOfType(Object, typeof(object));
        }
    }
}
