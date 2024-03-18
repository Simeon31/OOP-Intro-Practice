using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample06
{
    class EventSubscriber
    {
        public void HandleEvent(object sender, CustomEventArgs e)
        {
            Console.WriteLine("Data received: " + e.Data);
        }
    }
}
