using System;  //Use 'using' keyword to tell the compiler that you are using the 'System' namespace

namespace Fundamentals //'namespace' is a special keyword that allows to separate the code in a meaninful manner
{
    class LearnThisFirst //Every single time you want to execute code, it needs to be inside of a Type, in this case, a Class
    {
        static void Main() //Method that will execute first when running the program
        {
            //Every Object you work with, has a type, in this case, it is a System.Int type, which we use the keyword 'int' to represent it
            int firstType = 3; //Your first Type
            
            Console.WriteLine("Hello World"); //Your first statement, this will output to console 'Hello World'
            /*When writting Console Applications, you can use this statement to wait for User Input
             Then the CMD Window won't automatically close*/
            int sum = 3 + 3;// '3+3' is an Expression  Statement since it evaluates and creates a value

            Console.ReadLine();
        }
    }
}
