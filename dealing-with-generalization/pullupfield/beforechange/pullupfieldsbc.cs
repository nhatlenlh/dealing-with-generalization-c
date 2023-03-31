using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.pullupfield.beforechange
{
    class Vehicle
    {
    }
    class Truck: Vehicle
    {
   public string Name { get; set; }
    }
    class Car: Vehicle
    {
        public string Name { get; set; }
    }
    
}
