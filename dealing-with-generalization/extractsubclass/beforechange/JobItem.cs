using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.extractsubclass.beforechange
{
    internal class JobItem
    {
        private int unitPrice;

        private int quantity;

        private bool isLabor;

        private Employee employee;

        public JobItem(int unitPrice, int quantity, bool isLabor, Employee employee)
        {
            this.unitPrice = unitPrice;
            this.quantity = quantity;
            this.isLabor = isLabor;
            this.employee = employee;
        }

        public int getTotalPrice()
        {
            return getUnitPrice() * quantity;
        }

        public int getUnitPrice()
        {
            return (isLabor) ? employee.getRate() : unitPrice;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public Employee getEmployee()
        {
            return employee;
        }
    }
}
