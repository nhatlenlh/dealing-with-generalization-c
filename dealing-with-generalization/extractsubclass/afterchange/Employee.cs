using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.extractsubclass.afterchange
{
    class Employee
    {
        private int rate;

        public Employee(int rate)
        {
            this.rate = rate;
        }

        public int getRate()
        {
            return rate;
        }
    }
}
