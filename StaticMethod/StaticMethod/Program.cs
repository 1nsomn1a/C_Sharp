using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    class TV
    {
        private static int currentChannel = 0;

        public static void CurrentChannel()
        {
            Console.WriteLine(currentChannel);
        }
        public static void NextChannel()
        {
            currentChannel++;
        }
        public static void PrevChannel()
        {
            if(currentChannel == 0)
            {
                currentChannel = 0;
            }
            else
            {
                currentChannel--;
            }
        }
        public static void PressChannel(int n)
        {
                currentChannel = n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TV.CurrentChannel();
            TV.NextChannel();
            TV.CurrentChannel();
            TV.PressChannel(0);
            TV.CurrentChannel();
            TV.PrevChannel();
            TV.CurrentChannel();
        }
    }
}
