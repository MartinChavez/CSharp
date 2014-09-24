using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Parameters
{
    [TestClass]
    public class Parameters
    {
        [TestMethod]
        public void PassByValue()
        {
            Animal animal = new Animal();
            animal.Age = 5;
            int animalAge = 5;

            addBirthday(animal, animalAge);

            Assert.IsTrue(animal.Age == 6); //animal variable is a reference, therfore, changes inside the method will alter the Object
            Assert.IsTrue(animalAge == 5);  //animalAge is passed by value, since it is a primitive type, which means we send a copy of the variable, which once it is out of scope,
                                            //it is lost
        }

        private void addBirthday(Animal animal, int animalAge)
        {
            animal.Age++;
            animalAge++;
        }

        [TestMethod]
        public void PassObjectReferenceByValue()
        {
            Animal animal = new Animal();
            animal.Age = 5;

            SetAgeToTwo(animal);

            Assert.IsTrue(animal.Age == 5); //Object vars should remain the same
            Assert.IsFalse(animal.Age == 2);
        }

        private void SetAgeToTwo(Animal animal)
        {
            animal = new Animal(); //We are changing the reference of the veriable 'animal', therfore the original object won't be changed
            animal.Age = 2;
        }

        [TestMethod]
        public void PassObjectReferenceByReference()
        {
            Animal animal = new Animal();
            animal.Age = 5;

            SetAgeToTwoByRef(ref animal);

            Assert.IsTrue(animal.Age == 2); 
            Assert.IsFalse(animal.Age == 5);
        }


        private void SetAgeToTwoByRef(ref Animal animal)
        {
            animal = new Animal(); //We are changing the reference of the variable animal which is a reference of the object animal
            animal.Age = 2; //we change the value on the object 'animal'
        }

        [TestMethod]
        public void PassPrimitveTypeByReference()
        {
            int animalAge = 5;

            SetAgeToPrimitiveToTwoByRef(ref animalAge);

            Assert.IsTrue(animalAge == 2);
            Assert.IsFalse(animalAge == 5);
        }

        private void SetAgeToPrimitiveToTwoByRef(ref int animalAge)
        {
            animalAge = 2; //we change the value on the object 'animal'
        }

        [TestMethod]
        public void PassPrimitveTypeByReferenceOut()
        {
            int animalAge; // You don't need to initialize out references

            PassPrimitveTypeByReferenceOut(out animalAge);

            Assert.IsTrue(animalAge == 2);
            Assert.IsFalse(animalAge == 5);
        }

        private void PassPrimitveTypeByReferenceOut(out int animalAge)
        {
            animalAge = 2; //we change the value on the object 'animal'
        }
    }
}
