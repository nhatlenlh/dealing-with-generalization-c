using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.pullupmethod.beforechange
{
    class Animals
    {
        public void fourLeg()
        {
            Console.WriteLine("These are 4 legs animals");
        }
    }
    class Cat: Animals
    {
		public void eat()
		{
			Console.WriteLine("Animal is eating");
		}
		public void nameCat()
		{
			Console.WriteLine("This is Cat");
		}
	}
    class Dog: Animals
    {
		public void eat()
		{
			Console.WriteLine("Animal is eating");
		}
		public void nameDog()
		{
			Console.WriteLine("This is Dog");
		}
	}
}
