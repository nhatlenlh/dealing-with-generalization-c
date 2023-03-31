using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.extractsubclass.afterchange
{
    internal class JobItem
    {
        private int unitPrice;

        private int quantity;

        public JobItem(int unitPrice, int quantity)
        {
            this.unitPrice = unitPrice;
            this.quantity = quantity;
        }

        public int getTotalPrice()
        {
            return getUnitPrice() * quantity;
        }

        public int getUnitPrice()
        {
            return unitPrice;
        }

        protected bool isLabor()
        {
            return false;
        }

        public int getQuantity()
        {
            return quantity;
        }
    }
}
