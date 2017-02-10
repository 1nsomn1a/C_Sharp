using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal
    {
        internal string Name { get; private set; }

        internal Animal(string name)
        {
            Name = name;
        }

        //public virtual void GetInfo()
        //{
        //    Console.WriteLine(Name);
        //}
    }

    class Dog : Animal
    {
        public string Color { get; set; }

        public Dog(string name, string color) : base(name)
        {
            Color = color;
        }

        public void Guard()
        {
            Console.WriteLine("Gav, Gav, Rrrrrrr");
        }
    }

    class Cat : Animal
    {
        public int Age { get; set; }

        public Cat(string name, int age) : base(name)
        {
            Age = age;
        }

        public void CatchMouse()
        {
            Console.WriteLine("MEOW!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Johny", "Black");
            Cat cat = new Cat("Barsik", 4);

            dog.Guard();
            cat.CatchMouse();

            //dog.Name = "Kolya";  // { get; private set; }

            Console.WriteLine($"Name: {dog.Name}; Color: {dog.Color}");
            Console.WriteLine($"Name: {cat.Name}; Age: { cat.Age}");
       }
    }
}
