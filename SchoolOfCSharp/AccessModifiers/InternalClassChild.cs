using System;

namespace AccessModifiers
{
    class InternalClassChild : InternalClass
    {
       public void InvokeParentProtectedMehtod()
        {
            ProtectedMethod();
        }

       public override void VirtualMethod()
       {
           base.VirtualMethod();
           Console.WriteLine("Invoking VirtualMethod from InternalClassChild");
       }
    }
}
