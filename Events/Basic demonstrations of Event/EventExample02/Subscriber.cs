using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample02
{
    class Subscriber
    {
        public void HandleEvent(object sender, CustomEventArgs e)
        {
            Console.WriteLine("Event handled with data: " + e.Data);
        }
    }
}
