using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealing_with_generalization.extractsuperclass.afterchange
{
    class Animal {
        protected String breed;
        protected int age;

        public Animal(String breed, int age)
        {
            this.breed = breed;
            this.age = age;
        }

        public String getBreed()
        {
            return breed;
        }

        public void setBreed(String breed)
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
    }
    class Dog: Animal {
        public Dog(String breed, int age):base(breed, age) { }
        

        public void bark()
        {
            Console.WriteLine("Woof woof");
        }
    }
    class Cat : Animal
    {
        public Cat(String breed, int age):base (breed, age) { }
        

        public void meow()
        {
            Console.WriteLine("Meow meow");
        }
    }
}
