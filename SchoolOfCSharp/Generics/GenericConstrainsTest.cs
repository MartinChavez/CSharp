using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Generics
{
    [TestClass]
    public class GenericConstrainsTest
    {
        [TestMethod]
        public void GenericConstrains()
        {
            var disposer = new Disposer<ImplementsIDisposable>(); //Disposer will only accept Types which implement IDisposable

            var implementsIDisposable = new ImplementsIDisposable();

            var disposeSucceded = disposer.Dispose(implementsIDisposable);

            Assert.IsTrue(disposeSucceded);
        }
    }
}


internal class Disposer<TDisposer> where TDisposer : IDisposable // You can set conditions on the Generic Type in order to perform more activities with give instance at runtime
{
    public bool Dispose(TDisposer item)
    {
        item.Dispose();
        return true;
    }
}

internal class ImplementsIDisposable : IDisposable //This is a class that implements IDisposable
{
    public void Dispose() //This gets executed at runtime by the Disposer Class
    {
    }
}