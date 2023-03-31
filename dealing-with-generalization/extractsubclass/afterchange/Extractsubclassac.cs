using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.extractsuperclass.afterchange
{
    class Party
    {
        protected string name;
        protected int age;

        public string getDescription()
        {
            return "Name: " + name + ", " + "Age: " + age;
        }
    }

    class Employee : Party
    {
        private string jobTitle;

        public string getJobTitle()
        {
            return jobTitle;
        }
    }

    class Student : Party
    {
        private string major;

        public string getMajor()
        {
            return major;
        }
    }
}
