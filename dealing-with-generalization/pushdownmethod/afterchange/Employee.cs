using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.pushdownmethod.afterchange
{
     class Employee
    {
        protected float AddSalary(float multiplier, float standardSalary)
        {
            return multiplier * standardSalary;
        }

        protected float GetBonusSalary(float workingMonth, float dayOff)
        {
            return workingMonth * 70000 - dayOff * 10000;
        }
    }
}
