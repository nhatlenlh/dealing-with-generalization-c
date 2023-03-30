using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.extractsuperclass.afterchange
{
    class Person
    {
        protected string name;
        protected int age;

        public string getDescription()
        {
            return "Name: " + name + ", " + "Age: " + age;
        }
    }

    class Employee : Person
    {
        private string jobTitle;

        public string getJobTitle()
        {
            return jobTitle;
        }
    }

    class Student : Person
    {
        private string major;

        public string getMajor()
        {
            return major;
        }
    }
}
