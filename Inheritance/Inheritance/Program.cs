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
            Console.WriteLine(Name + " Gav, Gav, Rrrrrrr");
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
            Console.WriteLine(Name + " MEOW!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            Dog dog = new Dog("Johny", "Black");
            Cat cat = new Cat("Barsik", 4);
            dog.Guard();
            cat.CatchMouse();
            //dog.Name = "Kolya";  //cant use: { get; private set; }
            Console.WriteLine($"Name: {dog.Name}; Color: {dog.Color}");
            Console.WriteLine($"Name: {cat.Name}; Age: { cat.Age}");
            */

            List<Animal> animal = new List<Animal>();

            //animal.Add(new Dog("Bim")); //cant use: { get; private set; }
            animal.Add(new Dog("Barbos", "black"));
            animal.Add(new Cat("Barsik", 3));
            animal.Add(new Cat("Lima", 4));

            /*
            foreach (Animal an in animal)
            {
                if (an is Dog)
                    ((Dog)an).Guard();
                else
                    ((Cat)an).CatchMouse();
            }
            */

            foreach (Animal an in animal)
            {
                if (an is Dog)
                    (an as Dog).Guard();
                else
                    (an as Cat).CatchMouse();
            }

            Console.ReadKey();

            


       }
    }
}
