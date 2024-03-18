using System;

namespace EventExample05
{
    /*
     * Here we use delegates to bind two methods, "Method1" and "Method2", 
     * to "MyDelegate". When "del" is called with a "Hello, world!" parameter, 
     * it will also call "Method1" and "Method2", which will print "Hello, world! Method1" 
     * and "Hello, world! Method2" to the console.
     */
    class Program
    {
        delegate void MyDelegate(string message);

        static void Main(string[] args)
        {
            MyDelegate del = new MyDelegate(Method1);

            del += Method2;

            del("Hello, world!");
        }
        private static void Method1(string message)
        {
            Console.WriteLine(message + " Method1");
        }

        private static void Method2(string message)
        {
            Console.WriteLine(message + " Method2");
        }
    }
}
