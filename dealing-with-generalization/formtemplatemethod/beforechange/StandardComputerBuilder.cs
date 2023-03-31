using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.formtemplatemethod.beforechange
{
     class StandardComputerBuilder: ComputerBuilder
    {
        public void buildComputer()
        {
            addMotherboard();
            setupMotherboard();
            addProcessor();
        }
        public void addMotherboard()
        {
        }
        public void setupMotherboard()
        {
        }
        public void addProcessor()
        {
        }
    }
}
