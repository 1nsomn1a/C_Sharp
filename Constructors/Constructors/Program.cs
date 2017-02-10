using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Student
    {
        internal string Name;
        internal int Year;
        internal bool Stipend;

        public Student()
        {
            Name = "unavailable";
            Year = 0;
            Stipend = false;
        }

        public Student(string name, int year)
        {
            Name = name;
            Year = year;
            //Stipend = false;
        }
        public Student(string Name, int Year, bool Stipend)
        {
            this.Name = Name;
            this.Year = Year;
            this.Stipend = Stipend;
        }

        public void GetInfo()
        {
            Console.WriteLine(Name + ", year - " + Year + ", presence of stipend - " + Stipend);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student newStudent1 = new Student();
            Student newStudent2 = new Student("Nikolay", 4);
            Student newStudent3 = new Student("Vasiliy", 2, true);

            newStudent1.GetInfo();
            newStudent2.GetInfo();
            newStudent3.GetInfo();
        }
    }
}
