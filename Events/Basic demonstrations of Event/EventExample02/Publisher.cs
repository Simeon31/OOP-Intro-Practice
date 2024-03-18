using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample02
{
    class Publisher
    {
        public event EventHandler<CustomEventArgs> Event;

        public void DoSomething()
        {
            Console.WriteLine("Doing something...");

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
