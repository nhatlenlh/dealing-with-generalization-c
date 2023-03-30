using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.pullupfield.afterchange
{
    class Vehicle
    {
        public String Name { get; set; }
    }
    class Truck : Vehicle
    {
    }
    class pullupfields : Vehicle
    {
    }
}
