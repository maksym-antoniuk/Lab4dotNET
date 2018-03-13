using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Pong
    {
        delegate void ping();
        public static void pong()
        {
            Console.WriteLine("Понг!");
            ping p = new ping(Ping.ping);
            System.Threading.Thread.Sleep(5000);
            p.Invoke();
        }
    }
}
