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
            var methodInfo = typeof (Debug).GetMethod("WriteLine", new Type[] {typeof (string)}); //This extracts the method information from Debug.Writeline 
            var dynamicMethod = new DynamicMethod("DynamicMethod",typeof(void),new Type[]{}); //This specifies the method signature
            var ilGenerator = dynamicMethod.GetILGenerator(); //We use GetILGenerator() in order to create IL
            /*We use MS Intermidiate language calls to load the required info*/
            ilGenerator.Emit(OpCodes.Ldstr, "Test Dynamic Method");
            ilGenerator.Emit(OpCodes.Call, methodInfo);
            ilGenerator.Emit(OpCodes.Ret);//Return statement

            var action = (Action)dynamicMethod.CreateDelegate(typeof(Action)); //We can create dynamic delegates and execute our method

            action();//Prints in Debug console

            Assert.AreEqual(action.GetType(), typeof(Action)); //This statement verifies that the action was created at runtime
        }
    }
}
