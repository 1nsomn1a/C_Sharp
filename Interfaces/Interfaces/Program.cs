using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IDrawable
    {
        void Draw();
    }
    interface IGeometrical 
    {
        void GetPerimeter(int a, int b);
        void GetArea(int a, int b);
    }

    interface IObject : IDrawable, IGeometrical
    {
        
    }

    class Rectangle : IObject
    {
        public void Draw()
        {
            Console.WriteLine("Drawing rectangle...");
        }
        public void GetPerimeter(int a, int b)
        {
            Console.WriteLine($"Rectangle's perimeter is {(a + b) * 2}");
        }

        public void GetArea(int a, int b)
        {
            Console.WriteLine($"Rectangle's area is {a * b}");
        }
    }

    class Square : IObject
    {
        public void Draw()
        {
            Console.WriteLine("Drawing square...");
        }
        public void GetPerimeter(int a, int b)
        {
            try
            {
                if (a != b)
                {
                    throw new Exception("It's a square: A and B must be equals!");
                }
                else
                {
                    Console.WriteLine($"Square's perimeter is {4 * a}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void GetArea(int a, int b)
        {
            try
            {
                if (a != b)
                {
                    throw new Exception("It's a square: A and B must be equals!");
                }
                else
                {
                    Console.WriteLine($"Square's area is {a * b}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            (new Rectangle()).GetArea(4, 5);
            (new Square()).GetArea(3, 3);
            Console.ReadKey();

            List<IObject> figures = new List<IObject>();

            figures.Add(new Square());
            figures.Add(new Rectangle());

            foreach(IObject f in figures)
            {
                f.Draw();
                f.GetArea(4, 5);
                f.GetPerimeter(3, 4);
            }

            Console.ReadKey();
        }
    }
}
