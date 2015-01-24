
using System;

namespace Classes
{
    class Cat : Animal
    {
        public Cat()
        {

        }

        public Cat(string catName)
            : base(catName) //You could use the Animal's constructor
        {
            //Name = catName;
        }

        public void Talk()
        {
            Console.WriteLine("Meow");
        }
    }
}

