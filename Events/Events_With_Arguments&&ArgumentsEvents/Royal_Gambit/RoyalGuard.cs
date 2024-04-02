using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Royal_Gambit
{
    delegate void RoyalGuardAction(object sender, RoyalGuard args);
    class RoyalGuard
    {
        public event RoyalGuardAction RoyalGuardsEvent;

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Royal Guard without name!");
                }
                name = value;
            }
        }

        public void RoyalGuardsAction(RoyalGuard args)
        {
            RoyalGuardsEvent?.Invoke(this, args);
        }
    }
}
