using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Remoting.Messaging;
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
                new CsharpClass(i.ToString(CultureInfo.InvariantCulture)); //You create a new memory allocation in every loop
            }
            //Approximately the GC ran 403 times for this loop
            Assert.IsTrue(GetTotalCollections() < 403);
        }

            private static int GetTotalCollections()
            {
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