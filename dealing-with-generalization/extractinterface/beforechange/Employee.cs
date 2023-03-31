using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.extractinterface.beforechange
{
    class Employee
    {
        private string name;

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
