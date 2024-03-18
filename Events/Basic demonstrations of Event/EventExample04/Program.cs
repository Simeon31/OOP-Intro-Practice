using System;

namespace EventExample04
{
    /*
     * In this program, we have a class "CustomEventArgs" that inherits from "EventArgs" 
     * and has a "Data" property of type "string" 
     * that stores the data that will be sent with the event. 
     * In the main method, we create the "publisher" and "subscriber" objects 
     * and bind the "HandleEvent" method to the "Event" event of "publisher". 
     * We then call the "DoSomething" method of "publisher" 
     * with a "Hello, world!" parameter that dispatches the event
    */
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new();
            Subscriber subscriber = new();

            publisher.Event += subscriber.HandleEvent;

            publisher.DoSometing("Hello, world!");
        }
    }
}
