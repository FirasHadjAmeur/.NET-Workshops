using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;

namespace AM.ApplicationCore.Interfaces
{
    internal interface IServiceFlight
    {

        

        public List<DateTime> GetFlightDates(string destination);
        public void GetFlights(string filterType, string filterValue);

        public void ShowFlightDetails(Plane plane);
        public int ProgrammedFlightNumber(DateTime startDate);
        public double DurationAverage(string destination);
        public IEnumerable<Flight> OrderedDurationFlights();
        public IEnumerable<String> SeniorTravellers(Flight f);
        public IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights();

    }
}
