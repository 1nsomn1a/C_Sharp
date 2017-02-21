using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod
{
    abstract class Human
    {
        public string Name { get; set; }
        public string Type { get; protected set; }

        public abstract void SayHello();
    }

    class AmericanBoy : Human
    {
        public AmericanBoy( string name )
        {
            Name = name;
            Type = "Американец";
        }

        public override void SayHello()
        {
            Console.WriteLine($"{Type} {Name} говорит Hello!");
        }
    }

    class RussianMan : Human
    {
        public RussianMan(string name)
        {
            Name = name;
            Type = "Русский человек";
        }

        public override void SayHello()
        {
            Console.WriteLine($"{Type} {Name} говорит Привет!");
        }
    }

    class GermanMan : Human
    {
        public GermanMan(string name)
        {
            Name = name;
            Type = "Немец";
        }

        public override void SayHello()
        {
            Console.WriteLine($"{Type} {Name} говорит Hallo!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> humans = new List<Human>();

            humans.Add(new AmericanBoy("Johny"));
            humans.Add(new RussianMan("Бронеслав"));
            humans.Add(new GermanMan("Wolfgang"));

            foreach (Human h in humans)
                h.SayHello();

            Console.ReadKey();

            AmericanBoy boy = new AmericanBoy("Tony");
            boy.SayHello();

            (new RussianMan("Medved")).SayHello();


            Console.ReadKey();
        }
    }
}
