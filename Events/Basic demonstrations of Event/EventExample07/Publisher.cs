using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample07
{
    class Publisher
    {
        public event EventHandler<string> Event;

        public void DoSomething(string data)
        {
            Console.WriteLine("Doing something with data: " + data);
            Event(data);
        }

        protected virtual void OnEvent(string data)
        {
            if (Event != null)
            {
                Event(this, data);
            }
        }
    }
}
