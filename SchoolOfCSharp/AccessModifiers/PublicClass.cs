
using System;

namespace AccessModifiers
{
    public class PublicClass
    {
        private void PrivateMethod()
        {
            Console.WriteLine("Invoking Private method");
        }

        public void PublicMethod()
        {
            PrivateMethod();
        }

    }
}
