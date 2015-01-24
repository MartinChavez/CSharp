using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exceptions
{
    [TestClass]
    public class Throw
    {
        [TestMethod]
        [ExpectedException(typeof(NotImplementedException), "NotImplementedException")]
        public void TestNotImplementedException()
        {
            throwPrivateException(); //In normal circumstances this would halt the running program
        }

        [TestMethod]
        public void TryCatch()
        {
            try//Try catch statements 'catch' and handle exceptions that bubble up
            {
                throwPrivateException();
            }
            catch (NotImplementedException)
            { 
                //It does not break the excecution of the program
            }
        }

        [TestMethod]
        public void Finally()
        {
            var finallyReached = false;
            try
            {
                throwPrivateException();
            }
            catch (NotImplementedException)
            {
                finallyReached = false;
            }
            finally //You can use finally block to always force execution of a series of statements
            {
                finallyReached = true;
            }

            Assert.AreEqual(finallyReached , true);
        }

        private void throwPrivateException()
        {
            throw new NotImplementedException();//You only need to throw Exceptions in exceptional circumstances
        }
    }
}
