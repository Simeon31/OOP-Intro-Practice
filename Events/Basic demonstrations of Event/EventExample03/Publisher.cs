using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample03
{
    class Publisher
    {
        public event EventHandler<EventArgs> Event1;
        public event EventHandler<EventArgs> Event2;

        public void DoSomething()
        {
            Console.WriteLine("Doing something...");
            
        }

        protected virtual void OnEvent1()
        {
            if (Event1 != null)
            {
                Event1(this, EventArgs.Empty);
            }
        }

        protected virtual void OnEvent2()
        {
            if (Event2 != null)
            {
                Event2(this, EventArgs.Empty);
            }
        }
    }
}
