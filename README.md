<a name="README">[<img src="https://s3-us-west-2.amazonaws.com/testdrivenlearningbucket/c%23.jpg" width="200px" height="200px" />](https://github.com/MartinChavez/Learn-CSharp)</a>

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
 
Example: Reflection - Code Generation
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

References
====================

* [Pluralsight: Accelerated C# Fundamentals](http://www.pluralsight.com/courses/csharp-fundamentals)
