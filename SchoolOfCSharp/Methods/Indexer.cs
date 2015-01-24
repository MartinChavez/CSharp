using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods
{
    [TestClass]
    public class Indexer
    {

        public class Organization
        {
            public Dictionary<int,string> EmpList = new Dictionary<int, string>();

            public string this[int index]
            {
                get
                {
                    return EmpList.ContainsKey((index)) ? EmpList[index] : null;
                }
            }
        }

        [TestMethod]
        public void IndexIsNull()
        {
            var organization = new Organization();
            var empName = organization[0];
            Assert.AreEqual(empName , null);
        }

        [TestMethod]
        public void Index()
        {
            var organization = new Organization();
            organization.EmpList.Add(1,"EmployeeOne");
            organization.EmpList.Add(2, "EmployeeTwo");

            var empName = organization[2];
            var empName2 = organization.EmpList[2];
            Assert.AreEqual(empName, empName2);
        }
    }
}
