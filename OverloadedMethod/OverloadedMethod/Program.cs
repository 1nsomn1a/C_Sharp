using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedMethod
{
    class Example
    {
        public static void GetNames(List<string> names)
        {
            int tmp = names.Count;
            foreach (var n in names)
            {
                Console.Write(tmp == 1 ? n : (n + ", "), tmp--);
            }

            Console.WriteLine();
        }

        public static void GetNames(List<string> names, string s)
        {
            int tmp = names.Count;
            foreach (var n in names)
            {
                Console.Write(tmp == 1 ? n : (n + $" {s} "), tmp--);
            }

            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Kolya", "Johny", "Wolfgang", "Tomas", "Roberto" };

            Example.GetNames(names);
            Example.GetNames(names, "|");
            Console.ReadKey();

        }
    }
}
