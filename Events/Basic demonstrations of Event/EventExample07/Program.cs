using System;

namespace EventExample07
{
    class Program
    {
        /*
         * This example demonstrates using an anonymous event handler method instead of creating a separate handler method. 
         * In this case, we create a new "handler" object of type "EventHandler<string>", 
         * which accepts two parameters - "sender" and "message". In the anonymous method we pass to the "handler", 
         * we simply print "Received message:" and the message passed as a parameter.
         * The anonymous method in "handler" receives this data and prints it to the console.
         */
        static void Main(string[] args)
        {
            EventHandler<string> eventHandler = delegate (object sender, string message)
            {
                Console.WriteLine("Received message: " + message);
            };

            Publisher publisher = new();

            publisher.Event += eventHandler;

            publisher.DoSomething("Hello, world!");
        }
    }
}
