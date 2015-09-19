using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GarbageCollection
{
    [TestClass]
    public class Cleaning
    {
        [TestMethod]
        public void TestGarbageCollection()
        {
            for (var i = 0; i < 1000000; i++)
            {
                var csharp = new CsharpClass(i.ToString(CultureInfo.InvariantCulture)); //You create a new memory allocation in every loop
            }
            //Approximately the GC ran 403 times for this loop
            Assert.IsTrue(GetTotalCollections() < 700);
        }

        [TestMethod]
        [ExpectedException(typeof(OutOfMemoryException))]
        public void OutOfMemory()
        {
            var csharpList = new List<CsharpClass>();

            for (var i = 0; i < 9000000; i++) //We increment the number of loops to create an OutOfMemoryException
            {
                var csharp = new CsharpClass(i.ToString(CultureInfo.InvariantCulture));
                csharpList.Add(csharp); 
            }
            //Performance is affected severely and program will never reach this point *On most commercial machines
            Assert.IsTrue(GetTotalCollections() < 403);
        }

        private static int GetTotalCollections() //How many GB collections ran in all generations
        {
            // 0 - When we first create an object, the references are placed in generation zero
            // 1 - If reference survives when the generatrion zero collection is placed, then the reference is placed on generation 1
            // 2 - If the references survive a collection on pass 1, they will be placed on generation 2
            return GC.CollectionCount(0) + GC.CollectionCount(1) + GC.CollectionCount(2); //We need to print the 3 generations of Garbage Collection
        }
    }


}

public class CsharpClass
{
    public CsharpClass(string propertyOne)
    {
        PropertyOne = propertyOne;
    }

    public string PropertyOne { get; set; }
    public byte[] PropertyTwo = new byte[1000];
}