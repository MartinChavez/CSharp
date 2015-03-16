using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Generics
{
    [TestClass]
    public class GenericsTest
    {
        [TestMethod]
        public void GenericsTypeSafety() //Generics types allow code reuse with type safety and Performance benefits
        {
            var dovesList = new List<Dove>(); //A List<T> is a Type that has one implementation but can work with any Object

            var firstDove = new Dove();
            var secondDove = new Dove();

            dovesList.Add(firstDove);
            dovesList.Add(secondDove);
            // dovesList.Add("StringDove");   This fails at compile time since the List<Dove> can only accept Doves

            Assert.AreEqual(true, dovesList.Any());
        }

        [TestMethod]
        public void GenericsPerformanceGains() //Generics perform so much better than normal collections
        {
            const int iterations = 10000000;

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var list = new ArrayList();

            for (var currentIteration = 0; currentIteration <= iterations; currentIteration++)
            {
                list.Add(currentIteration);
            }

            foreach (var value in list.Cast<int>())  //We need to perform a cast in every member of the list
            {
            }

            stopwatch.Stop();

            var arrayListMilliseconds = stopwatch.ElapsedMilliseconds;

            stopwatch.Reset();
            stopwatch.Start();

            var intList = new List<int>();

            for (var currentIteration = 0; currentIteration <= iterations; currentIteration++)
            {
                intList.Add(currentIteration); //No cast is required
            }

            foreach (var integer in intList)
            {
                var value = integer;
            }

            stopwatch.Stop();

            var listMilliseconds = stopwatch.ElapsedMilliseconds;

            //List<T> will always outperform ArrayList, CLR performs internal optimizations as well
            Assert.IsTrue(arrayListMilliseconds > listMilliseconds);
        }

        //dictionary
        //quick lookup or exception
    }
}

internal class Dove
{

}
