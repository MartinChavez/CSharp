using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal(); // You create an instance of the Class 'Animal' with the empty constructor
            dog.Name = "Dog"; //You set the property Name to Dog

            Animal cat = new Animal("Cat"); // You create an instance of the Class 'Animal' with a parameter for Name

            Console.WriteLine("Dog's name is " + dog.Name);
            Console.WriteLine("Cats's name is " + cat.Name);
            Console.ReadLine();
        }
    }
}
