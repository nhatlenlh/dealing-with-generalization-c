using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.pushdownfield.beforechange
{
    class Employee
    {
        public string name;
        public int ID;
        public string score;
        public string getScore()
        {
            return score;
        }
        private void setScore(string score)
        {
            this.score = score;
        }
    }
    class Engineer: Employee
    {
        public string getEngineerScore()
        {
            return score + 5;
        }
        public void print()
        {
            Console.WriteLine("This  Engineer class and this class use grade properties");
        }
    }
    class Manager: Employee
    {
        public void print()
        {
            Console.WriteLine("This is Manager class and this class don't use grade properties");
        }
    }
}
