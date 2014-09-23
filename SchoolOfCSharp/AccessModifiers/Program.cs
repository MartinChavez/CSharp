using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Access Modifiers*/ // -See Primitive Types Projects which is referencing this project to verify the examples
         
            PublicClass publicClass = new PublicClass(); //You can access a public class from anywhere, even outside the assembly
            InternalClass internalClass = new InternalClass(); //You can access an internal class from anywhere inside this assembly
            InternalClassChild internalClassChild = new InternalClassChild();

            //internalClass.ProtectedMethod();  -Impossible since we can't invoke protected methods outside the class and it's children
            internalClassChild.InvokeParentProtectedMehtod(); //Protected method invoked through's child's public method

            //publicClass.PrivateMethod();    -Impossible since we can't invoke private method's outside a class
            publicClass.PublicMethod(); //Acessing the private method through a public method, helpful when performing Encapsulation

            //AbtractClass abtractClass = new AbtractClass();  -Impossible since we can't instanciate Abtract classes
            AbstractClass abtractClass = new ImplementingClass();  //ImplementingClass imlpements every method fromo Abstract class
            abtractClass.AbtractMethod();

            //Virtual method that shares functionality between the base class and the child's class
            internalClassChild.VirtualMethod();

            Console.WriteLine(StaticClass.StaticString); //For static classes, you do not need to create an instance, you can invoke the methods directly
            
            SealedClass sealedClass = new SealedClass(); //You can create instances of a sealed class, but you can't inherit from it


            Console.ReadLine();

        }

       // public class inheritFromSealedClass : SealedClass {}  - You cannot inherit from a 'sealed' class
    }
}
