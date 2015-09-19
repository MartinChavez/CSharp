using System;  //Use 'using' keyword to tell the compiler that you are using the 'System' namespace

namespace Fundamentals //'namespace' is a special keyword that allows to separate the code in a meaninful manner
{
    class LearnThisFirst //Every single time you want to execute code, it needs to be inside of a Type, in this case, a Class
    {
        static void Main() //The 'Main' method that will execute first when running a console application
        {
            //Every Object you work with, has a type, in this case, it is a System.Int type, which we use the keyword 'int' to represent it
            int firstType = 3; //Your first Type
            
            Console.WriteLine("Hello World"); //Your first statement, this will output to console 'Hello World'

            int sum = 3 + 3;// '3+3' is an expression statement since it evaluates and creates a value

            /*When writting Console Applications, you can use 'Console.ReadLine()' statement to wait for User Input ,
            then the CMD Window won't automatically close*/
            Console.ReadLine();
        }
    }
}
