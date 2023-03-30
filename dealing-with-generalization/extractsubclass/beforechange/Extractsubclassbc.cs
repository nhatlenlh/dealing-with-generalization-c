using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.extractsuperclass.beforechange
{
    class Person
    {
        private string name;
        private int age;

        public string getDescription()
        {
            return "Name: " + name + ", " + "Age: " + age;
        }
    }
    class Employee
    {
        private string jobTitle;

        public string getJobTitle()
        {
            return jobTitle;
        }
    }
}
