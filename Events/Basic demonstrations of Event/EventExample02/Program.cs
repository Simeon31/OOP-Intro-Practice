using System;

namespace EventExample02
{
    /*
     The "CustomEventArgs" class inherits from "EventArgs" and adds a "Data" 
     property that will be used to transfer the data associated with the event. 
     The "Publisher" class has a variable of type "event" with delegate type "EventHandler<CustomEventArgs>" 
     that will send objects of type "CustomEventArgs" as event data.
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
