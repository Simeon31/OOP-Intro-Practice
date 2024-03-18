using System;

namespace EventExample03
{
    /*
     class "Publisher" which has two events - "Event1" and "Event2". 
     When the "DoSomething" method of "Publisher" is executed, two events are sent - 
    "Event1" and "Event2". The "Subscriber" class has two methods - "HandleEvent1" and "HandleEvent2"
    We then call the "DoSomething" method on "publisher", which dispatches both events.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new();
            Subscriber subscriber = new();

            publisher.Event1 += subscriber.HandleEvent1;
            publisher.Event2 += subscriber.HandleEvent2;

            publisher.DoSomething();
        }
    }
}
