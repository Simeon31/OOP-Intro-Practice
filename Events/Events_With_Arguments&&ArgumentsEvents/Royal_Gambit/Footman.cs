using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Royal_Gambit
{
     delegate void FootmanReaction(object sender, Footman args);
    class Footman
    {
        public event FootmanReaction FootmansEvent;

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
                    throw new Exception("Footman without name!");
                }
                name = value;
            }
        }

        public void FootmansReaction(Footman args)
        {
            FootmansEvent?.Invoke(this, args);
        }
    }
}
