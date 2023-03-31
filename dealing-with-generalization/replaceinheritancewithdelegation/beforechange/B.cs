using dealing_with_generalization.replaceinheritancewithdelegation.beforechange;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.replaceinheritancewithdelegation.afterchange
{
    class B: A
    {
        private A a = new A();
        public void bar()
        {
            Console.WriteLine("Bar");
            a.foo();
        }
    }
}
