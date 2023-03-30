using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.pullupconstructorbody.beforechange
{
    class Employee {
        public string ID { get; protected set; } 
        public string Name { get; protected set; }
    }
    class Manager: Employee
    {
        public string Age;
        public Manager(string age, string id, string name)
        {
            Age = age;
            ID = id;
            Name = name;
        }
    }

    class Engineer: Employee
    {
        public string Degree;
        public Engineer(string name, string id, string degree)
        {
            Name = name;
            ID = id;
            Degree = degree;
        }
    }
}
