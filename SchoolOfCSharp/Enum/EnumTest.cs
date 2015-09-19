using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Enum
{
    [TestClass]
    public class EnumTest
    {
        private enum Animal  //Value type that is a set of named constants
        {
            Dog,
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
