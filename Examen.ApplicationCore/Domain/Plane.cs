using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Plane
    {
        
        public int Capacity { get; set; }

        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }

        public PlaneType PlaneType { get; set; }

        public virtual ICollection<Flight> Flights { get; set; }

        public Plane(PlaneType pt, int capacity, DateTime date)
        {
            PlaneType = pt;
            Capacity = capacity;
            ManufactureDate = date;
        }

        public override string ToString()
        {
            return "Plane{" +
                    "capacity=" + Capacity +
                    ", manufactureDate=" + ManufactureDate +
                    ", planeId=" + PlaneId +
                    ", planeType=" + PlaneType +
                    ", flights=" + Flights +
                    '}';
        }
    }

    public enum PlaneType
    {
        Airbus,
        Boeing,
    }
}
