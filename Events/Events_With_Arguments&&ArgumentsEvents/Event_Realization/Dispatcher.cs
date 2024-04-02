using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Realization
{
    delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);
    class Dispatcher
    {
        public event NameChangeEventHandler NameChange;

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                // Invoke the NameChange event with the provided arguments
                OnNameChange(new NameChangeEventArgs(value));
            }
        }

        protected virtual void OnNameChange(NameChangeEventArgs args)
        {
            NameChange?.Invoke(this, args);
        }
    }
}
