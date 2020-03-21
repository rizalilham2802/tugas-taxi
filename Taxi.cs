using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    public class Taxi
    {
        //properties
        public string Drivername { get; set; }
        public bool OnDuty { get; set; }
        public float Numpassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Drivername: {0}", Drivername);
            Console.WriteLine("OnDuty: {0}", OnDuty);
            Console.WriteLine("Numpassenger: {0}", Numpassenger);

        }
        public void PickupPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang ", Drivername);

        }
        public void DropOffpassenger()
        {
            Console.WriteLine("{0} sedang antar penumpang ", Drivername);

        }
    }
}
