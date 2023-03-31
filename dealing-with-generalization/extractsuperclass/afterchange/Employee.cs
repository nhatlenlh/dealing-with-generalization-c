using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.extractsuperclass.afterchange
{
    class Employee: Party
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private int _annualCost;

        public override int AnnualCost {
            get
            {
                return _annualCost;
            }
        }
        public Employee(string jobTitle, string name, int age, int annualCost):base(name)
        {
            Age = age;
            _annualCost = annualCost;
        }
    }
}
