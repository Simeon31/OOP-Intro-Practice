using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample04
{
    class Subscriber
    {
        public void HandleEvent(object sender, CustomeEventArgs e)
        {
            Console.WriteLine("Data received: " + e.Data);
        }
    }
}
