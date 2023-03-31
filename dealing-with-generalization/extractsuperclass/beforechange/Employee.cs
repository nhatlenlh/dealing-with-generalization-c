using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.extractsuperclass.beforechange
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int AnnualCost { get; set; }
        public Employee(string jobTitle, string name, int age, int annualCost)
        {
            Name = name;
            Age = age;
            AnnualCost = annualCost;
        }
    }
}
