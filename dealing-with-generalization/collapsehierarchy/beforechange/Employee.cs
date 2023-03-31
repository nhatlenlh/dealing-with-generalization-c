using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.collapsehierarchy.beforechange
{
    class Employee
    {
        public string name;
        public string age;
        public string getAge()
        {
            return age;
        }
        public void setAge(string age)
        {
            this.age = age;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            name = name;
        }
        public bool IsCreat()
        {
            return true;
        }
    }
}
