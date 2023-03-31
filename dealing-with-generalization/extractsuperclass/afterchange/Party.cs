using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.extractsuperclass.afterchange
{
    abstract class Party
    {

        public string Name { get; set; }
        public abstract int AnnualCost { get;}
        protected Party(string name)
        {
            Name = name; 
        }
    }
}
