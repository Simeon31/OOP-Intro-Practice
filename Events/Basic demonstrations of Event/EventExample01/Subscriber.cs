using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample01
{
    class Subscriber
    {
        public void HandleEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Event handled");
        }
    }
}
