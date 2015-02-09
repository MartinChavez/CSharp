using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Reflection
{
    [TestClass]
    public class Reflection //Another tool from CLR that allows us to obtain information from an Object at runtime
    {
        [TestMethod]
        public void ReflectionMembers()
        {
            var type = typeof (ReflectionClass);
            var members =
                type.GetMembers(BindingFlags.Static | BindingFlags.Instance | BindingFlags.NonPublic |
                                BindingFlags.Public);
            var isGetNamePresent = false;

            foreach (var member in members.Where(member => member.Name == "GetName")) //Through reflection we can know the method's name at runtime
            {
                isGetNamePresent = true;
            }

            Assert.IsTrue(isGetNamePresent);
        }


    }
}


public class ReflectionClass
{

    public int Property { get; set; }

    public string GetName()
    {
        return "ReflectionClass";
    }

}