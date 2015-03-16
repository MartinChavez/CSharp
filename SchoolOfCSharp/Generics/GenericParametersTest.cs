using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Generics
{
    [TestClass]
    public class GenericParametersTest
    {
        [TestMethod]
        public void GenericParameterClass()
        {
            //Randomizer class does not specify the Type of object it receives, but we can use any Type, because it is generic 
            var randomInt = new Randomizer<int>();

            randomInt.Insert(1);
            randomInt.Insert(2);
            randomInt.Insert(3);
            randomInt.Insert(4);
            randomInt.Insert(5);

            randomInt.Remove();
            //We verify that in fact, we removed an Int value from the Randomizer
            Assert.IsTrue(randomInt.Count() < 5);
        }
    }
}

internal class Randomizer<T>//This Type 'T' refers to any object, at runtime you can instanciate this class with any Type
{
    public void Insert(T item)//You could use the Type 'T' all over the class
    {
        _list.Add(item);
    }

    public void Remove()
    {
        var random = new Random();
        _list.RemoveAt(random.Next(0, _list.Count));
    }

    public int Count()
    {
        return _list.Count;
    }

    readonly List<T> _list = new List<T>(); 

}
