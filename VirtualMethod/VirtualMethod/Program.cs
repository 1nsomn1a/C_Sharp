using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    class Person
    {
        internal string Name { get; set; }
        internal int Age { get; set; }

        internal protected Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        internal virtual void ShowInfo()
        {
            Console.Write($"Man: {Name}, age: {Age}");
        }
    }

    class Student : Person
    {
        private string Univer { get; set; }

        internal protected Student(string name, int age, string univer) : base(name, age)
        {
            Univer = univer;
        }

        internal override void ShowInfo()
        {
            Console.WriteLine($"\nStudent: {Name}, age: {Age}, univer: {Univer}");
        }
    }

    class Pupil : Person
    {
        internal string Grade { get; set; }
        internal protected Pupil(string name, int age, string grade) : base(name, age)
        {
            Grade = grade;
        }

        internal override void ShowInfo()
        {
            base.ShowInfo();
            Console.Write($", grade: {Grade}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> person = new List<Person>();

            person.Add(new Person("Vasya", 27));
            person.Add(new Student("Stas", 25, "BSUIR"));
            person.Add(new Pupil("Dima", 12, "7A"));

            foreach(Person p in person)
            {
                p.ShowInfo();
            }

            Console.ReadKey();
        }
    }
}
