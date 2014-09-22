using System;

namespace Classes
{
    class Program
    {
        static void Main()
        {
            /* Objects and Classes*/
            
            Animal dogAnimal = new Animal(); // You create an instance of the Class 'Animal' with the empty constructor
            dogAnimal.Name = "Dog"; //You set the property Name to Dog

            Animal catAnimal = new Animal("Cat"); // You create an instance of the Class 'Animal' with a parameter for Name

            Console.WriteLine("Dog's animal name is " + dogAnimal.Name);
            Console.WriteLine("Cats's animal name is " + catAnimal.Name);

            //Two vars can reference the same Object
            Animal bearOne = new Animal("Bear");
            Animal bearTwo = bearOne;
            Console.WriteLine("bearTwo name is " + bearTwo.Name);

            //One var can reference different Objects (at different time)
            Animal lion = new Animal("Tiger");
            lion = new Animal("Lion");
            Console.WriteLine("lion name is " + lion.Name);

            /* Inheritance*/

            Animal dog = new Dog("Dog");
            Console.WriteLine("Dog's name is " + dog.Name);

            Animal cat = new Cat("Cat");
            Console.WriteLine("Cat's name is " + cat.Name);
            Console.WriteLine("Cat's, which are Animals, breathe like this ");
            cat.Breathe(); //method defined for all Animals 
        

            Console.ReadLine();
        }
    }
}
