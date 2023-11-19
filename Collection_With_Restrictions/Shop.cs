using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_With_Restrictions
{
    public class Shop
    {
        public string Location { get; set; }
        public string Name { get; set; }

        public virtual void Print() 
        {
            Console.WriteLine($" Name: {Name}\n Address: {Location}");
        }
    }
}
