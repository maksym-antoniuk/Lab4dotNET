using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Hare
    {
        int x;
        int y;
        public delegate void mooveHandler();
        public event mooveHandler moove;

        public void run()
        {
            Random rand = new Random();
            while (true)
            {
                x = rand.Next();
                y = rand.Next();
                moove();
                System.Threading.Thread.Sleep(5000);
            }

        }
    }
}
