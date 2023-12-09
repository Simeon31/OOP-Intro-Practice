using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Ex09
{
    class Interest
    {
        public virtual double TrueBank(double amount, double rate)
        {
            return amount + (amount * rate);
        }
    }
}
