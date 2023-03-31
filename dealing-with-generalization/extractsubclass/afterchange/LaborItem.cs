using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.extractsubclass.afterchange
{
     class LaborItem: JobItem
    {
        private Employee employee;

        public LaborItem(int unitPrice, int quantity, Employee employee):base(unitPrice, quantity)
        {
        }

        public Employee getEmployee()
        {
            return employee;
        }


        public int getUnitPrice()
        {
            return employee.getRate();
        }

        protected bool isLabor()
        {
            return true;
        }
    }
}
