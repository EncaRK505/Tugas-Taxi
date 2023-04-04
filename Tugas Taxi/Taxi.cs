using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasTaxi
{
    internal class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Nama Driver : {0}", DriverName);
        }
        public void PickUpPassenger()
        {
            if (OnDuty == true)
            {
                Console.WriteLine("Driver Status : Yes");
            }
            else
            {
                Console.WriteLine("Driver Status : No");
            }
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("Jumlah Penumpang : {0}", NumPassenger);
        }
    }
}
