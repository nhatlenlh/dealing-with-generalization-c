using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.extractinterface.afterchange
{
    class DataEmployee
    {
        public double charge(Billable emp, int days)
        {
            int result = emp.getRate() * days;

            if (emp.hashSpecialSkill())
            {
                return result * 1.05;
            }
            return result;
        }
    }
}
