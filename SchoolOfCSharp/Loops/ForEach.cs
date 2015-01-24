using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loops
{
    [TestClass]
    public class ForEach
    {
        [TestMethod]
        public void YieldReturn()
        {
            var primerNumbers = EvenNumbers().Cast<int>().ToList();

            var evenNumbersResult = new List<int> { 0, 2, 4};

            var numTimes = 0;
            foreach (var evenNumberResult in evenNumbersResult)
            {
                Assert.AreEqual(evenNumberResult, primerNumbers[numTimes]);
                numTimes++;
            }
        }


        private static IEnumerable EvenNumbers()
        {
            for (var number = 0; number < 6; number++)
            {
                if (number%2 != 0) continue;
                yield return number;
            }
        }
    }
}
