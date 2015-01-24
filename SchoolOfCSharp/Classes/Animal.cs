using System;

namespace Classes
{
    public class Animal //Your first class, think about it as a template for objects running in memory
    {
        public Animal() //Constructor with no param
        {

        }

        ~Animal() //Destructor - Used to cleanup an object instance
        {  //Not really needen unless you do win32 calls
            Console.WriteLine("Animal object is being destroyed...");
        }


        public Animal(string name) //Constructor with one param, this is called Overloading
        {
            Name = name;
        }

        public String Name { get; set; } //Simplified syntax to create getter and setter in an elegant manner

        public int Age { get; set; }

        public void Breathe() //Method that will be shared by all Animals
        {
            Console.WriteLine("Breathing...");
        }
    }  
}
