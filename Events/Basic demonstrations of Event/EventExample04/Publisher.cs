using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample04
{
    class Publisher
    {
        public event EventHandler<CustomeEventArgs> Event;

        public void DoSometing(string data)
        {
            Console.WriteLine("Doing something with data: " + data);
            OnEvent(new CustomeEventArgs(data));
        }

        protected virtual void OnEvent(CustomeEventArgs e)
        {
            if (Event != null)
            {
                Event(this, e);
            }
        }
    }
}
