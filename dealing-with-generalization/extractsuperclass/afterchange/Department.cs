using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.extractsuperclass.afterchange
{
    class Department: Party
    {
        public string Name { get; set; }
        public IEnumerable<Party> Staff { get; set; }

        public override int AnnualCost
        {
            get
            {
                return Staff.Sum(s => s.AnnualCost);
            }
        }
        public void addStaff(Party employee)
        {
            ((List<Party>)Staff).Add(employee);
        }
    }
}
