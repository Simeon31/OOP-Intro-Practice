using System;
using System.Collections.Generic;
using System.Text;
namespace Collection_With_Restrictions
{
    public class List<T> : Shop where T : Shop
    {
        private LinkedList<string> list;

        public List()
        {
            list = new LinkedList<string>();
        }

        public void Add(string location)
        {
            list.AddLast(location);
        }

        public void Remove(string element)
        {
            list.Remove(element);
        }

        public void GetAddress(string address)
        {
            Console.WriteLine("\n Location state: " +  list.Contains(address));
        }
        public void PrintNewDetails()
        {
            foreach (string item in list)
            {
                Console.WriteLine("\n Updated info: " + item);
            }
        }
        public override void Print()
        {
            base.Print();
        }
    }
}
