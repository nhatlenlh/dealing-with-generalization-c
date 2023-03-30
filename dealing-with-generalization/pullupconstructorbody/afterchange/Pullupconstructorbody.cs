using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.pullupconstructorbody.afterchange
{
    class Employee
    {
        public string ID { get; protected set; }
        public string Name { get; protected set; }

        protected Employee(string iD, string name)
        {
            ID = iD;
            Name = name;
        }
    }
    class Manager : Employee
    {
        public string Age;
        public Manager(string age, string id, string name):base(age, id)
        {
            Age = age;
           
        }
    }

    class Engineer : Employee
    {
        public string Degree;
        public Engineer(string name, string id, string degree):base(name, id)
        {
            Degree = degree;
        }
    }
}
