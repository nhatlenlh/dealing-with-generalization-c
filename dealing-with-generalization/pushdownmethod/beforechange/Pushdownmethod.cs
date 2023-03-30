using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.pushdownmethod.beforechange
{
    
    
    class Engineer: Employee
    {
        
        protected  double AddSalary(double multiplier, double standardSalary)
            {
                return AddSalary(multiplier, standardSalary);
            }

       
        protected  double GetBonusSalary(double workingMonth, double dayOff)
            {
                return GetBonusSalary(workingMonth, dayOff);
            }



            protected int FeedbackFromEngineer(int score)
            {
                return GetScoreFeedback(score) + 10;
            }
    }

    class Manager: Employee
    {
        

        protected  double AddSalary(double multiplier, double standardSalary)
            {
                return AddSalary(multiplier, standardSalary);
            }

        protected  double GetBonusSalary(double workingMonth, double dayOff)
            {
                return GetBonusSalary(workingMonth, dayOff);
            }
    }
}
