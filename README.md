<a name="README">[<img src="https://s3-us-west-2.amazonaws.com/testdrivenlearningbucket/csharp7.png"  width="200px" height="180px" />](https://github.com/MartinChavez/Learn-CSharp)</a>
C# : Test-Driven Learning
================

A project aimed to help the user master the C# language with a test-driven approach. Each unit contains an annotated tutorial on the code itself and the ability to run Unit Tests to verify the expected behavior.

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

Reflection - Code Generation
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


Questions ?
====================

If you have any questions, please feel free to ask me:
[Martin Chavez Aguilar](mailto:martin.chavez@live.com)

Contributors
====================

* [Martin Chavez Aguilar](http://martinchavezaguilar.com/) - Wrote the project

Continue Learning
====================
<a name="README">[<img src="https://camo.githubusercontent.com/eb464a60a4a47f8b600aa71bfbc6aff3fe5c5392/68747470733a2f2f7261772e6769746875622e636f6d2f766f6f646f6f74696b69676f642f6c6f676f2e6a732f6d61737465722f6a732e706e67" width="50px" height="50px" />](https://github.com/MartinChavez/Learn-Javascript)</a>
<a name="README">[<img src="https://pbs.twimg.com/profile_images/2149314222/square.png" width="50px" height="50px" />](https://github.com/MartinChavez/AngularJs-Basics)</a>
<a name="README">[<img src="https://s3-us-west-2.amazonaws.com/testdrivenlearningbucket/angularadvanced.png" width="50px" height="50px" />](https://github.com/MartinChavez/AngularJS-Advanced-Topics)</a>
<a name="README">[<img src="http://precision-software.com/wp-content/uploads/2014/04/jQurery.gif" width="50px" height="50px" />](https://github.com/MartinChavez/jQueryBasics)</a>
<a name="README">[<img src="https://s3-us-west-2.amazonaws.com/testdrivenlearningbucket/htmlcss.jpg" width="65px" height="50px" />](https://github.com/MartinChavez/HTML-CSS)</a>
<a name="README">[<img src="https://s3-us-west-2.amazonaws.com/testdrivenlearningbucket/htmlcssblack.jpg" width="50px" height="50px" />](https://github.com/MartinChavez/HTML-CSS-Advanced-Topics)</a>
