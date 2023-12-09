using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Ex05
{
    class Interest
    {
        public double TrueBank(double amount, double rate)
        {
            return amount + (amount * rate);
        }

        public double TrueBank(double amount, double rate, string holdertype)
        {
            return amount + (amount * rate) + 2000;
        }
    }
}
