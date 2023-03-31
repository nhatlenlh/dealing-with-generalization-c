using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.extractinterface.beforechange
{
    class DataEmployee
    {
        public double charge(Employee emp, int days)
        {
             var result = emp.getRate() * days;

            if (emp.hashSpecialSkill())
            {
                return result * 1.05;
            }
            return result;
        }
    }
}
