using System;
using System.Diagnostics;
using System.Reflection.Emit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reflection
{
    [TestClass]
    public class CodeGeneration
    {
        [TestMethod]
        public void DynamicallyCreatingCode()
        {
            var methodInfo = typeof(Debug).GetMethod("WriteLine", new[] { typeof(string) }); //The method ‘GetMethod’ extracts the method information from Debug.Writeline 
            var dynamicMethod = new DynamicMethod("DynamicMethod", typeof(void), new Type[] { }); //We can specify the method signature by using a type of DynamicMethod
            var ilGenerator = dynamicMethod.GetILGenerator(); //We use 'GetILGenerator()' in order to create IL statements
            /*We use MS Intermediate Language calls to load the required information*/
            ilGenerator.Emit(OpCodes.Ldstr, "Test Dynamic Method");
            ilGenerator.Emit(OpCodes.Call, methodInfo);
            ilGenerator.Emit(OpCodes.Ret);//Return statement

            var action = (Action)dynamicMethod.CreateDelegate(typeof(Action)); //We can create dynamic delegates and execute our method

            action();//Prints in Debug Console

            Assert.AreEqual(action.GetType(), typeof(Action)); //This statement verifies that the action was created at runtime
        }
    }
}
