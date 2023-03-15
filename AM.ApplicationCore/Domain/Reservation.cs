using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Reservation
    {
        public DateTime DateReservation { get; set; }

        [ForeignKey("SeatFk")]
        public int SeatFk { get; set; }
        public Seat Seat { get; set; }

        [ForeignKey("PassengerFk")]
        public int PassengerFk { get; set; }
        public Passenger Passenger { get; set; }
    }
}
