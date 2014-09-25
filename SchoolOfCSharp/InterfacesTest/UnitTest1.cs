using System.Collections.Generic;
using Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterfacesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InvokingMethodWithoutKnowingAboutObject()
        {
            IAnimal Tiger = new Tiger();
            IAnimal Lion = new Lion();

            List<IAnimal> animalList = new List<IAnimal>();
            animalList.Add(Tiger);
            animalList.Add(Lion);


            foreach (var animal in animalList) //We can execute the methods of IAnimal without knowing the Object
            {
                animal.Breathe();
            }

        }
    }
}
