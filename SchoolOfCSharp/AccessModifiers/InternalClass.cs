using System;

namespace AccessModifiers
{
    internal class InternalClass //Can only be accesed on this assembly
    {
        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected method invoked from Internal Class");
        }

        public virtual void VirtualMethod()
        {
            Console.WriteLine("VirtualMethod invoked from InternalClass");
        }
    }
}
