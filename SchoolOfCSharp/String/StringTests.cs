using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace String
{
    [TestClass]
    public class StringTests
    {
        [TestMethod]
        public void StringEqualsComparison()
        {
            /*Although Strings are Reference Types, when making '==' comparisons it verifies the content of the string, and not the comparison of the reference*/
            string StringOne = "String";
            string StringTwo = "String";

            Assert.IsTrue(StringOne == StringTwo); //Verifies the strings have the same value
            Assert.IsTrue(StringOne.Equals(StringTwo));
        }

        [TestMethod]
        public void StringIsInmmutable()
        {
            /* Strings are inmmutable*/
            string StringOne = " String ";
            StringOne.Trim();
            Assert.IsFalse(StringOne == "String"); //Since we cannot change the value of a string, this is false
        }

        [TestMethod]
        public void StringIsInmmutableMakeNewInstance()
        {
            /* Strings are inmmutable*/
            string StringOne = " String ";
            StringOne = StringOne.Trim(); //But we can assign the new instance to the previous reference
            Assert.IsTrue(StringOne == "String"); 
        }
    }
}
