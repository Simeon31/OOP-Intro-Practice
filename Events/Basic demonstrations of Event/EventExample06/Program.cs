using System;

namespace EventExample06
{
    class Program
    {
        /*
         * Here we use a custom event of "EventPublisher" instead of using delegates. 
         * When we call the "DoSomething" method of "publisher", it sends the event "Event" with the data "Hello, world!". 
         * "EventSubscriber" receives the event and prints the data to the console.
         */
        static void Main(string[] args)
        {
            EventPublisher eventPublisher = new();
            EventSubscriber eventSubscriber = new();

            eventPublisher.Event += eventSubscriber.HandleEvent;

            eventPublisher.DoSomethint("Hello, world!");
        }
    }
}
