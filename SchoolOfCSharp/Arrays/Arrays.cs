using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arrays
{
    [TestClass]
    public class Arrays
    {
        [TestMethod]
        public void ArrayLength()
        {
            int[] IntArray = new int[5];
            const int expectedLength = 5;

            Assert.AreEqual(IntArray.Length, expectedLength);
        }

        [TestMethod]
        public void ArraysAreReferences()
        {
            int[] IntArray = new int[5]; // Int arrays are initialized on 0 by default
            modifyArray(IntArray);
            const int expectedVal = 1;
                //Since Arrays are references, by entering to the method, the value of the reference is modified

            Assert.AreEqual(IntArray[1], expectedVal);

        }

        private void modifyArray(int[] intArray)
        {
            intArray[1] = 1;
        }

        [TestMethod]
        public void ArrayIndexOf()
        {
            int[] intArray = {1, 2, 3, 4, 5};

            const int expectedVal = 2; //Since Arrays are zero based, we expect the integer 3 to be at position 2

            Assert.AreEqual(Array.IndexOf(intArray, 3), expectedVal);

        }
    }
}
