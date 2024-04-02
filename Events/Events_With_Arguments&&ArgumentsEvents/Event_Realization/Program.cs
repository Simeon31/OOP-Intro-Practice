using System;

namespace Event_Realization
{
    class Program
    {
        static void Main(string[] args)
        {
            Dispatcher dispatcher = new Dispatcher();
            Handler handler = new Handler();
            
            dispatcher.NameChange += handler.OnDispatcherNameChange;
         
            string cmd = null;
            while (!"End".Equals(cmd = Console.ReadLine()))
            {
                dispatcher.Name = cmd;
            }
        }
    }
}
