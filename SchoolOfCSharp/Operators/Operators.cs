using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Operators
{
    [TestClass]
    public class Operators
    {
        [TestMethod]
        public void VerifyShortHandNotation()
        {
            var x = 3;
            x += 2; //Short hand of x = x + 2
            Assert.IsTrue(x == 5);
        }

        [TestMethod]
        public void VerifySingleOperatorShortHandNotation()
        {
            var x = 3;
            x++; //Short hand of x = x + 1 AND Short hand of x += 1
            Assert.IsTrue(x == 4);
        }
    }
}
