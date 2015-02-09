using System;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reflection
{
    [TestClass]
    public class AttributesTest
    {
        [TestMethod]
        public void AttributesUsingReflection()
        {
            var human = new Human {Age = 11};

            var dangerZoneAttributeExists = false;

            foreach (var method in (typeof(Human)).GetMembers().Where(IsDangerZone))
            {
                dangerZoneAttributeExists = true;
            }

            Assert.IsTrue(dangerZoneAttributeExists);
        }

        private static bool IsDangerZone(MemberInfo member)
        {
            return member.GetCustomAttributes(true).OfType<DangerZoneAttribute>().Any(); //You can verify the attributes of a given method at runtime and act on them
        }
    }
}
