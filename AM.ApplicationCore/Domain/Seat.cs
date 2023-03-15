using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Seat
    {
        public int SeatId { get; set; }
        public string Name { get; set; }
        public string SeatNumber { get; set; }
        public int Size { get; set; }

        public List<Reservation> Reservations { get; set; }
        public Section Sections { get; set; }
        public Plane Plane { get; set; }
    }
}
