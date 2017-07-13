using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeNow = DateTime.Now;

            var people = new People(new ProxyThink(new Think()));

            if (timeNow.Hour == 9)
                people.WakeUp();

            else
                people.InWork();

            Console.ReadKey();
        }
    }
}