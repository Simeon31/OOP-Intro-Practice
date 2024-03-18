using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample06
{
    class CustomEventArgs : EventArgs
    {
        public string Data { get; set; }

        public CustomEventArgs(string data)
        {
            Data = data;
        }
    }
}
