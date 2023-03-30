using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.extractsuperclass.beforechange
{
    class Cat
    {
        private string breed;
        private int age;

        public Cat(string breed, int age)
        {
            this.breed = breed;
            this.age = age;
        }

        public string getBreed()
        {
            return breed;
        }

        public void setBreed(string breed)
        {
            this.breed = breed;
        }

        public int getAge()
        {
            return age;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void meow()
        {
            Console.WriteLine("Meow meow");
        }
    }
    class Dog
    {
        private string breed;
        private int age;

        public Dog(string breed, int age)
        {
            this.breed = breed;
            this.age = age;
        }

        public string getBreed()
        {
            return breed;
        }

        public void setBreed(string breed)
        {
            this.breed = breed;
        }

        public int getAge()
        {
            return age;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void bark()
        {
            Console.WriteLine("Woof woof");
        }
    }
}
