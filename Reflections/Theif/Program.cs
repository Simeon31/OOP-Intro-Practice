using System;

namespace Theif
{
    class Program
    {
        static void Main(string[] args)
        {
            //Spy spy = new Spy();
            //string result = spy.StealFieldInfo("Theif.Hacker", "username", "password");
            //Console.WriteLine(result);

            //Spy spy = new Spy();
            //string result = spy.AnalyzeAccessModifiers("Theif.Hacker");
            //Console.WriteLine(result);

            //Spy spy = new Spy();
            //string result = spy.RevealPrivateMethods("Theif.Hacker");
            //Console.WriteLine(result);

            Spy spy = new Spy();
            string result = spy.CollectGettersAndSetters("Theif.Hacker");
            Console.WriteLine(result);
        }
    }
}
