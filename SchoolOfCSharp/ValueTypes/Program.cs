
using System;

namespace ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Value Types*/

            //No pointers or references
            //No object allocated on the heap
            int valueTypeInt = 4; //No need to use the 'new' keyword
            int valueTypeIntTwo = new int(); //but you could
            valueTypeIntTwo = 5;
            valueTypeInt = valueTypeIntTwo; //This is a copy and paste from memory, not a reference

            {    //Result should be 10
                int result = valueTypeInt + valueTypeIntTwo; //this is short lived, it dissapears after the context
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
