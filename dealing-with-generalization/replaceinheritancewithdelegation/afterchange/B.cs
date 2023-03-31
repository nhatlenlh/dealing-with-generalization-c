using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.replaceinheritancewithdelegation.beforechange
{
    class B: A
    {
        public void bar()
        {
            Console.WriteLine("bar");
            foo();
        }
    }
}
