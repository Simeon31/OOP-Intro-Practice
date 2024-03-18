using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample01
{
    class Publisher
    {
        public event EventHandler<EventArgs> Event;

        public void DoSomething()
        {
            Console.WriteLine("Doing something...");
        }

        protected virtual void OnEvent()
        {
            if (Event != null)
            {
                Event(this, EventArgs.Empty);
            }
        }
    }
}
