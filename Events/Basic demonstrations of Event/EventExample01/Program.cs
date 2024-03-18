using System;

namespace EventExample01
{
   /*
    In this program, we have a "Publisher" class that has an "Event" event. When "Publisher" executes the "DoSomething" method, it dispatches the "Event" event. 
   We also have a "Subscriber" class that has a "HandleEvent" method that will be called when the "Publisher" sends the "Event" event. 
   In the main method, we create the "publisher" and "subscriber" objects and bind the "HandleEvent" method to the "Event" event of "publisher". 
   We then call the "DoSomething" method on the "publisher", which dispatches the "Event" event, which causes the "HandleEvent" method on the "subscriber" to be called.
   */
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new();
            Subscriber subscriber = new();

            publisher.Event += subscriber.HandleEvent;

            publisher.DoSomething();
        }
    }
}
