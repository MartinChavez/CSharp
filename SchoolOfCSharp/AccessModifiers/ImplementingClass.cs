using System;

namespace AccessModifiers
{
    class ImplementingClass : AbstractClass
    {
        public override void AbtractMethod()
        {
            Console.WriteLine("Implementing AbstractMethod");
        }

        public override void AbtractMethodTwo()
        {
            Console.WriteLine("Implementing AbstractMethodTwo");
        }
    }
}
