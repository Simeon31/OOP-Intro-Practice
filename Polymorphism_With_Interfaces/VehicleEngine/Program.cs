using System;

namespace VehicleEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            ITransport car = new Car();
            ITransport boat = new Boat();

            car.StartEngine();
            boat.StartEngine();
        }
    }
}
