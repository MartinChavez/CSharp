using System;

namespace Operators
{
    class Program
    {
        static void Main()
        {
            int x = 3;
            x += 2; //Short hand of x = x + 2
            Console.WriteLine(x);

            x++; //Short hand of x = x + 1 AND Short hand of x += 1
            Console.WriteLine(x);
            
            Console.ReadLine();

        }
    }
}
