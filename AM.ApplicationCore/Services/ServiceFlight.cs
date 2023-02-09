using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight:IServiceFlight
    {
      
        public List<Flight> Flights { get; set; } = new List<Flight>();

        public IEnumerable<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> result = new List<DateTime>();
           foreach (var flight in Flights)
            {
                if ( destination== flight.Destination ) {
                    yield return flight.FlightDate;
                //    result.Add(flight.FlightDate);
                }
            }
           // return result;
        }

        public void GetFlights(string filterType, string filterValue)
        {
           
        }
    }
}
