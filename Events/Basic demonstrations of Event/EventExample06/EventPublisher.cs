using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample06
{
    class EventPublisher
    {
        public event EventHandler<CustomEventArgs> Event;

        public void DoSomethint(string data) 
        {
            Console.WriteLine("Doing something with data: " + data);
            OnEvent(new CustomEventArgs(data));
        }

        protected virtual void OnEvent(CustomEventArgs e)
        {
            if (Event != null)
            {
                Event(this, e);
            }
        }
    }
}
