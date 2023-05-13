using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Flight
    {
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int FlightId { get; set; }

        public float EstimatedDuration { get; set; }

        public virtual Plane Plane { get; set; }
        public virtual List<Passenger> Passengers { get; set; }

        public override string ToString()
        {
            return "Flight{" +
                    "destination='" + Destination + '\'' +
                    ", departure='" + Departure + '\'' +
                    ", flightDate=" + FlightDate +
                    ", effectiveArrival=" + EffectiveArrival +
                    ", flightId=" + FlightId +
                    ", estimatedDuration=" + EstimatedDuration +
                    ", plane=" + Plane +
                    ", passengers=" + Passengers +
                    '}';
        }

    }
}
