using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.pushdownfield.afterchange
{
    class Employee
    {
        public string name;
        public int ID;
        
    }
    class Engineer : Employee
        
    {
        public string score;
        public string getScore()
        {
            return score;
        }
        public string getEngineerScore()
        {
            return score + 5;
        }
        public void print()
        {
            Console.WriteLine("This  Engineer class and this class use grade properties");
        }
    }
    class Manager : Employee
    {
        public void print()
        {
            Console.WriteLine("This is Manager class and this class don't use grade properties");
        }
    }
}
