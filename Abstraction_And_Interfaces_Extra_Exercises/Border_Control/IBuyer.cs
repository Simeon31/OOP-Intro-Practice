using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Border_Control
{
    public interface IBuyer
    {
        void BuyFood();
        public int Food { get; }
    }
}
