using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Parameters
{
    [TestClass]
    public class DefaultParameters
    {
        [TestMethod]
        public void DefaultParametersWithoutParameter()
        {
            //GetString will execute using the default parameter of 'OptionalString'
            Assert.AreEqual(GetString(), "OptionalString");
        }

        [TestMethod]
        public void DefaultParametersWithParameter()
        {
            //GetString will execute using the para,eter defined at the method's execution
            Assert.AreEqual(GetString("NewString"), "NewString");
        }

        [TestMethod]
        public void NamedParameters()
        {
            //By stating the name of the optional parameter, the code becomes more readable
            Assert.AreEqual(GetString(optionalString : "NewString"), "NewString");
        }

        private static string GetString(string optionalString = "OptionalString") //You can specify the method signature with default values
        {
            return optionalString;
        }
    }
}
