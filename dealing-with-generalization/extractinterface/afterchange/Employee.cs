using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.extractinterface.afterchange
{
    class Employee: Billable
    {
        private String name;

        private int rate;


        public int getRate()
            {
                return rate;
            }

        public bool hashSpecialSkill()
            {
                return true;
            }
    }
}
