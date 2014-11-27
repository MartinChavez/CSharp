using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods
{
    [TestClass]
    public class Methods
    {
        [TestMethod]
        public void SingleParameter()
        {
           var bytes =  WriteAsBytes(32);
           Assert.AreEqual(bytes, "0x200x000x000x00");
        }

        [TestMethod] public void MultipleParameter()
        {
            var bytes = WriteAsBytes(32, 20, 17);
            Assert.AreEqual(bytes, "0x200x000x000x000x140x000x000x000x110x000x000x00");
            //You can also pass an array
            Assert.AreEqual(new[] {32, 20, 17}, "0x200x000x000x000x140x000x000x000x110x000x000x00");
        }

        [TestMethod]
        public void MethodOverloading() //You can define two methods that are named the same, as long as they recieve different parameters
        {
            var bytes = WriteAsBytes(2.3, 4.54);
            Assert.AreEqual(bytes, "0x660x660x660x660x660x660x020x400x290x5C0x8F0xC20xF50x280x120x40");
        }

        private static string WriteAsBytes(params int[] values)//This is the method signature
        {
            //Every method should have a return type
            return values.Select(BitConverter.GetBytes).Aggregate<byte[], string>(null, (current1, bytes) => bytes.Aggregate(current1, (current, currentByte) => current + String.Format("0x{0:X2}", currentByte)));
        }

        private static string WriteAsBytes(params double[] values)//This is the method signature
        {
            //Every method should have a return type
            return values.Select(BitConverter.GetBytes).Aggregate<byte[], string>(null, (current1, bytes) => bytes.Aggregate(current1, (current, currentByte) => current + String.Format("0x{0:X2}", currentByte)));
        }
    }
}
