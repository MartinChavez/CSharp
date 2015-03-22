Learn C# (Test-Driven Learning)
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
  
 ### Example: Reflection - Code Generation

In this example we explain the use of Reflection and how to dynamically create code using C# / .Net

<!--  -->

[TestMethod]
        public void DynamicallyCreatingCode()
        {
            var methodInfo = typeof (Debug).GetMethod("WriteLine", new Type[] {typeof (string)}); //This extracts the method information from Debug.Writeline 
            var dynamicMethod = new DynamicMethod("DynamicMethod",typeof(void),new Type[]{}); //This specified the method signature
            var ilGenerator = dynamicMethod.GetILGenerator(); //We use GetILGenerator() in order to be able to create IL 
            /*We use MS Intermidiate language calls to load the required info*/
            ilGenerator.Emit(OpCodes.Ldstr, "Test Dynamic Method");
            ilGenerator.Emit(OpCodes.Call, methodInfo);
            ilGenerator.Emit(OpCodes.Ret);//Return statement

            var action = (Action)dynamicMethod.CreateDelegate(typeof(Action)); //We can create dynamic delegates and execute our method

            action();//Prints in Debug console
        }

Questions?
----------

If you have any questions, please feel free to ask me:
[Martin Chavez Aguilar](mailto:martin.chavez@live.com)

Contributors
====================

* [Martin Chavez Aguilar](https://www.linkedin.com/in/martinchavezaguilar) - Wrote the project
