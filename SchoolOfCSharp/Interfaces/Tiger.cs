using System;

namespace Interfaces
{
    public class Tiger : IAnimal //Classes can inherit from an interface
    {
        public void Breathe()  // And provide an implementation
        {
           Console.WriteLine("Tiger's breathe like this");
        }
    }
}
