using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleEngine
{
    class Car : ITransport
    {
        public void StartEngine()
        {
            Console.WriteLine("Starting car engine...");
        }
    }
}
