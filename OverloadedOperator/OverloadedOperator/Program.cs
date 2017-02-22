using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedOperator
{
    class Money
    {
        public string Unit { get; set; }
        public int Amount { get; set; }

        public Money (int amount, string unit)
        {
            Unit = unit;
            Amount = amount;
        }

        public static Money operator +(Money a, Money b)
        {
            if(a.Unit == b.Unit)
                return new Money (a.Amount + b.Amount, a.Unit);
            else
            {
                MoneyExchange.Exchange(a, b);
                return new Money(a.Amount + b.Amount, a.Unit);
            }
        }
    }

    class MoneyExchange
    {
        private const int exchange_rate = 2; // 1 USD == 2 BYN
        public static void Exchange( Money a, Money b )
        {
            Console.WriteLine($"\n{a.Amount} {a.Unit} + {b.Amount} {b.Unit} = ?");
            Console.WriteLine("Different money units are here! In what unit do you wanna take your money, USD or BYN?");
            Console.WriteLine("Please, write \"USD\" or \"BYN\"");

            string unit = Console.ReadLine();

            Console.WriteLine("Already exchanged sum: ");

            if (unit == "USD")
            {
                if (a.Unit == "USD")
                {
                    b.Amount /= exchange_rate;
                    b.Unit = a.Unit;
                }
                else
                {
                    a.Amount /= exchange_rate;
                    a.Unit = b.Unit;
                }
            }
            else
            {
                if (a.Unit == "BYN")
                {
                    b.Amount *= exchange_rate;
                    b.Unit = a.Unit;
                }
                else
                {
                    a.Amount *= exchange_rate;
                    a.Unit = b.Unit;
                }
            }        
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Money m1 = new Money(250, "BYN");
            Money m2 = new Money(300, "BYN");
            Money m3 = new Money(150, "USD");

            Money sum1 = m1 + m2;
            Console.WriteLine($"{m1.Amount} {m1.Unit} + {m2.Amount} {m2.Unit} = {sum1.Amount} {sum1.Unit} ");
            Console.ReadKey();

            Money sum2 = m2 + m3;
            Console.WriteLine($"{m2.Amount} {m2.Unit} + {m3.Amount} {m3.Unit} = {sum2.Amount} {sum2.Unit} ");
            Console.ReadKey();
        }
    }
}
