using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Royal_Gambit
{
    delegate void KingUnderAttack(object sender, King args);
    class King
    {
        public event KingUnderAttack KingsEvent;

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
                    throw new Exception("King without name!");
                }
                name = value;
            }
        }

        public void KingsSecurity(King args)
        {
            KingsEvent?.Invoke(this, args);
        }
    }
}
