using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.pushdownmethod.afterchange
{
    class Engineer: Employee
    {
            protected float AddSalary(float multiplier, float standardSalary)
            {
                return AddSalary(multiplier, standardSalary);
            }

        
            protected float GetBonusSalary(float workingMonth, float dayOff)
            {
                return GetBonusSalary(workingMonth, dayOff);
            }
            protected int FeedbackFromEngineer(int score)
            {
                return GetScoreFeedback(score) + 10;
            }

            private int GetScoreFeedback(int score)
            {
                return score * 10;

        }
    }

    class Manager: Employee
    {
        
        protected float AddSalary(float multiplier, float standardSalary)
            {
                return AddSalary(multiplier, standardSalary);
            }

        
        protected float GetBonusSalary(float workingMonth, float dayOff)
            {
                return GetBonusSalary(workingMonth, dayOff);
            }
        }
}
