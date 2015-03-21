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
                                                                  //Open generic Type Parameters
            var disposer = new Disposer<ImplementsIDisposable>(); //Disposer will only accept Types which implement IDisposable
            var implementsIDisposable = new ImplementsIDisposable();
            var disposeSucceded = disposer.Dispose(implementsIDisposable);

            Assert.IsTrue(disposeSucceded);
        }

        [TestMethod]
        public void GenericReflection()
        {
            var disposer = CreateDisposer(typeof (ImplementsIDisposable)) as Disposer<ImplementsIDisposable>; //You can specify at runtime the Generic Type you want to create
            var implementsIDisposable = new ImplementsIDisposable();
            var disposeSucceded = disposer != null && disposer.Dispose(implementsIDisposable); //You can use Disposer as in the previous method

            Assert.IsTrue(disposeSucceded);
        }

        [TestMethod]
        public void GenericMethods()
        {
            var disposer = CreateDisposer<ImplementsIDisposable>(); //It simplifies Disposer creation
            var implementsIDisposable = new ImplementsIDisposable();
            var disposeSucceded = disposer != null && disposer.Dispose(implementsIDisposable); //You can use Disposer as in the previous method

            Assert.IsTrue(disposeSucceded);
        }

        private static object CreateDisposer(Type type)
        {
            var implementsIDisposableType = typeof (Disposer<>); //This is an unbound generic type
            return Activator.CreateInstance(implementsIDisposableType.MakeGenericType(type)); //We get the type at runtime via the Type parameter
        }

        //You can specify the T of the return value
        private static Disposer<T> CreateDisposer<T>() where T : IDisposable  //You can create Generic methods as well, with the same constrains as the class
        {
            var implementsIDisposableType = typeof(Disposer<>);
            return Activator.CreateInstance(implementsIDisposableType.MakeGenericType(typeof(T))) as Disposer<T>;  //We get the type at runtime via the T Type
        }
    }
}

internal class Disposer<TDisposer> where TDisposer : IDisposable // You can set conditions on the Generic Type in order to perform more activities with the given instance at runtime
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