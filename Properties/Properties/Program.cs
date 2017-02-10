using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class TV
    {
        private int volume;
        //private int number;

        public TV(int number) //Constructor
        {
            Number = number;
        }

        public int Number { get; private set; }

        //public int Number
        //{
        //    get
        //    {
        //        return number;
        //    }
        //}


        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value > 100)
                {
                    volume = 100;
                }
                else if (value < 0)
                {
                    volume = 0;
                }
                else
                    volume = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TV myTV = new TV(234);

            myTV.Volume = 101;
            Console.WriteLine(myTV.Volume + " " + myTV.Number );
        }
    }
}
