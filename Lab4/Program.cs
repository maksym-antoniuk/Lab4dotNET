using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("~~~~~Task - 1~~~~~");

            Ping.ping();

            Console.WriteLine("~~~~~Task - 2~~~~~");

            Hare hare = new Lab4.Hare();
            Hunter hunter = new Hunter();

            hare.moove += hunter.message;

            Console.WriteLine("~~~~~Task - 3~~~~~");

            hare.moove += delegate
            {
                Console.WriteLine("Заяц убежал(анонимный метод)");
            };

            hare.moove += () => Console.WriteLine("Заяц убежал(лямбда)");
            hare.run();
        }
    }
}
