using System;
using AccessModifiers;

namespace PrimitiveTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Integral Types

            // If the value represented by an integer literal exceeds the range of Type, a compilation error will occur, Try it!.
            sbyte signedSbyteNeg = -128;
            byte unsignedByte = 255;
            char character = 'a';
            short shortNumber = 32767;
            int integer = 2147483647;
            uint unsignedInteger = 4294967295;
            long longNumber = 9223372036854775807;
            var varWhichIsInt = 3;
            Console.WriteLine(signedSbyteNeg.GetType().ToString());
            Console.WriteLine(varWhichIsInt.GetType().ToString());

            // If the value exceds at runtime
            sbyte signedSbyte = 127;
            signedSbyte++;
            Console.WriteLine(signedSbyte); //You get -128 since C# uses the two's complement's system


            //Floating-point Types
            double doubleNumber = 3.5;
            float floatNumber = 3.5F; //Need to add the F to force the double number into a float

            Console.WriteLine(doubleNumber);
            Console.WriteLine(floatNumber);

            //DateTime
            DateTime dateTime = new DateTime(1987,8,24);
            Console.WriteLine(dateTime.ToShortDateString());
            Console.ReadLine();

            //AccessModifiers example
            PublicClass publicClass = new PublicClass(); //possible since the class is public
          //InternalClass internalClass = new InternalClass(); *Impossible since Internal only works on the current assembly
            
        }
    }
}
