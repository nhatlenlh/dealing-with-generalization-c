using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.collapsehierarchy.beforechange
{
    class Engineer: Employee
    {
        public bool IsActive()
        {
            return true;
        }
    }
}
