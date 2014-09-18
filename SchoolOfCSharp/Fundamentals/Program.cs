using System;  //Use 'using' keyboard to tell the compiler that you are using the 'System' namespace


namespace Fundamentals
{
    class Program //Every single time you want to execute code, it needs to be inside of a Type, in this case, a Class
    {
        static void Main() //Method that will execute first when running the program
        {

            Console.WriteLine("Hello World"); //Your first statement, this will output to console 'Hello World'
            /*When writting Console Applications, you can use this statement to wait for User Input
             Then the CMD Window won't automatically close*/
            Console.ReadLine();
        }
    }
}
