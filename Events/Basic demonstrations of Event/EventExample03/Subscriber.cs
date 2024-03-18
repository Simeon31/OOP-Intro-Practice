using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample03
{
    class Subscriber
    {
        public void HandleEvent1(object sender, EventArgs e)
        {
            Console.WriteLine("Event 1 handled");
        }

        public void HandleEvent2(object sender, EventArgs e)
        {
            Console.WriteLine("Event 2 handled");
        }
    }
}
