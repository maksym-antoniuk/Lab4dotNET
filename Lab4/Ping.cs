using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Ping
    {
        delegate void pong();
        public static void ping()
        {
            Console.WriteLine("Пинг!");
            pong p = new pong(Pong.pong);
            System.Threading.Thread.Sleep(5000);
            p.Invoke();
        }
    }
}
