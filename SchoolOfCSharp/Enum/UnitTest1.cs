using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Enum
{
    [TestClass]
    public class UnitTest1
    {

        public enum Animal  //Value type that is a set of named constants
        {
            Cat,
            Dog,
            Tiger,
            Bear
        }

        [TestMethod]
        public void EnumComparison()
        {
            Animal animal = Animal.Bear;

            Assert.AreEqual(animal, Animal.Bear); //Less expensive than String comparison since it is an integer value
            Assert.AreNotEqual(animal, Animal.Dog);
        }
    }
}
