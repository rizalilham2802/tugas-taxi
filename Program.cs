using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            //objek taxi
            Taxi taxi = new Taxi();

            //nilai properties
            taxi.Drivername = "rizal";
            taxi.OnDuty = true;
            taxi.Numpassenger = 12;

            //panggilan method
            taxi.TaxiInfo();
            taxi.PickupPassenger();
            taxi.DropOffpassenger();

            Console.ReadKey();
        }
    }
}
