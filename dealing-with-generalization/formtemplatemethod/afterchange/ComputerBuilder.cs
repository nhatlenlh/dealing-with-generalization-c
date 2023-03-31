using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.formtemplatemethod.afterchange
{
    abstract class ComputerBuilder
    {
        public  void BuildComputer()
        {
            AddMotherboard();
            SetupMotherboard();
            AddProcessor();
        }
        public abstract void AddMotherboard();
        public abstract void SetupMotherboard();
        public abstract void AddProcessor();
    }

    
}
