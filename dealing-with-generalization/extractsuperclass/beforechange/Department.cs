using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.extractsuperclass.beforechange
{
    internal class Department
    {
        public string Name { get; set; }
        public IEnumerable<Employee> Staff { get; set; }

        public int TotalAnnualCost
        {
            get
            {
                return Staff.Sum(s => s.AnnualCost);
            }
        }
        public void addStaff(Employee employee)
        {
            ((List<Employee>)Staff).Add(employee);
        }
    }
}
