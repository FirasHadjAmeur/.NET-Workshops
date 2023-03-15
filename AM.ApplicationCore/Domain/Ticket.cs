using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Ticket
    {
        public string Siege { get; set; }
        public float Prix { get; set; }
        public bool Vip { get; set; }


        public int FlightFk { get; set; }
        public Flight Flight { get; set; }

        public int PassengerFk { get; set; }
        public Passenger Passenger { get; set; }


    }
}
