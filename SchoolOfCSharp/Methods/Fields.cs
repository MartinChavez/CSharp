using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods
{
    [TestClass]
    public class Fields
    {
        private const string ReadOnlyVariable = "ReadOnlyValue";

        public string Property { get; set; } //Properties define independent get and set, either one could be public or private

        [TestMethod]
        public void ReadOnlyFields()
        {
            const string readOnlyVariable = "ReadOnlyValue";

            // ReadOnlyVariable = "test"; -You can't assign a variable to a readonly field, except on declaration or in  a contructor

            Assert.AreEqual(readOnlyVariable, ReadOnlyVariable);
        }

        public void VerifyProperty()
        {
            Property = "PropertyValue";
            Assert.AreEqual(Property, "PropertyValue");
        }
    }
}
