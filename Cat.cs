using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Abstraction_And_Interfaces
{
    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }

        public override string  MakeNoise()
        {
            return "Meow! " + base.MakeNoise();
        }

        public override string MakeTrick()
        {
            return "No trick for you! I'm too lazy!";
        }
    }
}
