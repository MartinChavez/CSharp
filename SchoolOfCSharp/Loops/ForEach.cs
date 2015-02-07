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
            var evenNumbers = EvenNumbers().Cast<int>().ToList();

            var evenNumbersResult = new List<int> { 0, 2, 4};

            var numTimes = 0;
            foreach (var evenNumberResult in evenNumbersResult)
            {
                Assert.AreEqual(evenNumberResult, evenNumbers[numTimes]);
                numTimes++;
            }
        }


        private static IEnumerable EvenNumbers() //Instead of returning a list
        {
            for (var number = 0; number < 6; number++)
            {
                if (number%2 != 0) continue;
                yield return number;
            }
        }
    }
}
