<a name="README">[<img src="https://s3-us-west-2.amazonaws.com/testdrivenlearningbucket/CSHARP.png" width="200px" height="200px" />](https://github.com/MartinChavez/Learn-CSharp)</a>
C# : Test-Driven Learning
================

This project is aimed to help the user further study C# with a test-driven approach. Each unit contains an annotated tutorial and a platform where you can test your understanding of the topic.

Topics:

 - Fundamentals
 - Classes and Objects 
 - Primitive Types
 - Types
 - Events 
 - Access Modifiers
 - Arrays
 - Boxing
 - Exceptions
 - Loops
 - Methods
 - Operators
 - Value Types
 - Garbage Collection
 - Threads
 - Reflection
 - COM Interop
 - PInvoke
 - Generics
 
Tools
====================
<a name="README">[<img src="http://www.codeproject.com/KB/cross-platform/860150/vs2015.png" width="50px" height="50px" />](https://www.visualstudio.com/en-us/products/vs-2015-product-editions.aspx)</a>

Basics
====================
```CSharp
using System;  //Use 'using' keyword to tell the compiler that you are using the 'System' namespace

namespace Fundamentals //'namespace' is a special keyword that allows to separate the code in a meaninful manner
{
    class LearnThisFirst //Every single time you want to execute code, it needs to be inside of a Type, in this case, a Class
    {
        static void Main() //The 'Main' method that will execute first when running a console application
        {
            //Every Object you work with, has a type, in this case, it is a System.Int type, which we use the keyword 'int' to represent it
            int firstType = 3; //Your first Type
            
            Console.WriteLine("Hello World"); //Your first statement, this will output to console 'Hello World'

            int sum = 3 + 3;// '3+3' is an expression statement since it evaluates and creates a value

            /*When writting Console Applications, you can use 'Console.ReadLine()' statement to wait for User Input,
            then the CMD Window won't automatically close*/
            Console.ReadLine();
```
Garbage Collection
====================
```CSharp
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

```
Generics
====================
```CSharp
        [TestMethod]
        public void DefaultKeyword() //The default keyword is used in a context where you do not know the Type at runtime
        {
            // default of Referenece Types is Null
            Assert.IsNull(ReturnDefault<ImplementsIDisposable>());
            // default of Value Numeric types is generally 0
            Assert.IsTrue(ReturnDefault<int>() == 0);
        }

        private static object CreateDisposer(Type type)
        {
            var implementsIDisposableType = typeof (Disposer<>); //This is an unbound generic type
            return Activator.CreateInstance(implementsIDisposableType.MakeGenericType(type)); //We get the type at runtime via the Type parameter
        }

        //You can specify the T of the returned value
        private static Disposer<T> CreateDisposer<T>() where T : IDisposable  //You can create Generic methods as well, with the same constrains as the class
        {
            var implementsIDisposableType = typeof(Disposer<>);
return Activator.CreateInstance(implementsIDisposableType.MakeGenericType(typeof(T))) as Disposer<T>;  //We get the type at runtime via the T Type
        }

        private static T ReturnDefault<T>()
        {
            return default(T);//This could be null or 0 *for most Int types
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
```
Reflection: Code Generation
====================
In this example we explain the use of Reflection and how to dynamically create code using C# / .Net
```CSharp
        [TestMethod]
        public void DynamicallyCreatingCode()
        {   //The method ‘GetMethod’ extracts the method information from Debug.Writeline 
            var methodInfo = typeof(Debug).GetMethod("WriteLine", new[] { typeof(string) }); 
            //We can specify the method signature by using a type of DynamicMethod
            var dynamicMethod = new DynamicMethod("DynamicMethod", typeof(void), new Type[] { }); 
            //We use 'GetILGenerator()' in order to create IL statements
            var ilGenerator = dynamicMethod.GetILGenerator();
            /*We use MS Intermediate Language calls to load the required information*/
            ilGenerator.Emit(OpCodes.Ldstr, "Test Dynamic Method");
            ilGenerator.Emit(OpCodes.Call, methodInfo);
            ilGenerator.Emit(OpCodes.Ret);//Return statement
            //We can create dynamic delegates and execute our method
            var action = (Action)dynamicMethod.CreateDelegate(typeof(Action)); 

            action();//Prints in Debug Console
            //This statement verifies that the action was created at runtime
            Assert.AreEqual(action.GetType(), typeof(Action));
            }
```

Run the Unit Tests
====================
All Unit Tests are passing, you can modify the content of the tests in order to try different combinations or concepts.

<a name="README">[<img src="https://s3-us-west-2.amazonaws.com/testdrivenlearningbucket/PassingRunningTests.png" />](https://github.com/MartinChavez/Learn-CSharp)</a>

Contact
====================
[<img src="https://s3-us-west-2.amazonaws.com/martinsocial/MARTIN2.png" />](http://martinchavezaguilar.com/)
[<img src="https://s3-us-west-2.amazonaws.com/martinsocial/github.png" />](https://github.com/martinchavez)
[<img src="https://s3-us-west-2.amazonaws.com/martinsocial/mail.png" />](mailto:info@martinchavezaguilar.com)
[<img src="https://s3-us-west-2.amazonaws.com/martinsocial/linkedin.png" />](https://www.linkedin.com/in/martinchavezaguilar)
[<img src="https://s3-us-west-2.amazonaws.com/martinsocial/twitter.png" />](https://twitter.com/martinchavezag)

Continue Learning
====================
<a name="README">[<img src="https://s3-us-west-2.amazonaws.com/martinbucket/JS.png" width="50px" height="50px" />](https://github.com/MartinChavez/Learn-Javascript)</a>
<a name="README">[<img src="http://nodejs-cloud.com/img/128px/nodejs.png" width="50px" height="50px" />](https://github.com/MartinChavez/Node.js-Tutorial)</a>
<a name="README">[<img src="https://pbs.twimg.com/profile_images/2149314222/square.png" width="50px" height="50px" />](https://github.com/MartinChavez/AngularJs-Basics)</a>
<a name="README">[<img src="https://s3-us-west-2.amazonaws.com/testdrivenlearningbucket/angularadvanced.png" width="50px" height="50px" />](https://github.com/MartinChavez/AngularJS-Advanced-Topics)</a>
<a name="README">[<img src="https://s3-us-west-2.amazonaws.com/testdrivenlearningbucket/CSHARP.png" width="50px" height="50px" />](https://github.com/MartinChavez/CSharp)</a>
<a name="README">[<img src="https://s3-us-west-2.amazonaws.com/testdrivenlearningbucket/linqblack.png" width="50px" height="50px" />](https://github.com/MartinChavez/LINQ)</a>
<a name="README">[<img src="http://precision-software.com/wp-content/uploads/2014/04/jQurery.gif" width="50px" height="50px" />](https://github.com/MartinChavez/jQueryBasics)</a>
<a name="README">[<img src="https://s3-us-west-2.amazonaws.com/testdrivenlearningbucket/htmlcss.jpg" width="65px" height="50px" />](https://github.com/MartinChavez/HTML-CSS)</a>
<a name="README">[<img src="https://s3-us-west-2.amazonaws.com/testdrivenlearningbucket/htmlcssblack.jpg" width="65px" height="50px" />](https://github.com/MartinChavez/HTML-CSS-Advanced-Topics)</a>
