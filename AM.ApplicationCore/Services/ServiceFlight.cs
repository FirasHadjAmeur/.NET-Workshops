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
        

        public ServiceFlight()
        {
            DurationAverageDel = DurationAverage;
            FlightDetailsDel = ShowFlightDetails;
        }

        public List<Flight> Flights { get; set; } = new List<Flight>();


        public IEnumerable<DateTime> GetFlightDates(string destination)
        {
            /* List<DateTime> result = new List<DateTime>();
            foreach (var flight in Flights)
             {
                 if ( destination== flight.Destination ) {
                     yield return flight.FlightDate;
                 }
             } */
            IEnumerable<DateTime> req = from f in Flights
                                        where f.Destination.Equals(destination)
                                        select f.FlightDate;
            return req.ToList();


        }
        List<DateTime> IServiceFlight.GetFlightDates(string destination)
        {
            throw new NotImplementedException();
        }

        void IServiceFlight.GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    foreach (Flight f in Flights)
                    {
                        if (f.Destination.Equals(filterValue))
                            Console.WriteLine(f);
                    }
                    break;
                case "FlightDate":
                    foreach (Flight f in Flights)
                    {
                        if (f.FlightDate == DateTime.Parse(filterValue))
                            Console.WriteLine(f);
                    }
                    break;
                case "EffectiveArrival":
                    foreach (Flight f in Flights)
                    {
                        if (f.EffectiveArrival == DateTime.Parse(filterValue))
                            Console.WriteLine(f);
                    }
                    break;
            }
        }

        public void ShowFlightDetails(Plane plane) {
            var req = from f in Flights
                      where f.plane == plane
                      select new { f.FlightDate, f.Destination };
            foreach (var v in req)
                Console.WriteLine("Flight Date; " + v.FlightDate + " Flight destination: " + v.Destination);
        }
        public int ProgrammedFlightNumber(DateTime startDate) {
            var req = from f in Flights
                      where DateTime.Compare(f.FlightDate, startDate) > 0 && (f.FlightDate - startDate).TotalDays < 7
                      select f;
            return req.Count();
        }
        public double DurationAverage(string destination) {
            return (from f in Flights
                    where f.Destination.Equals(destination)
                    select f.EstimatedDuration).Average();
        }
        public IEnumerable<Flight> OrderedDurationFlights() {
            var req = from f in Flights
                      orderby f.EstimatedDuration descending
                      select f;
            return req;
        }
        public IEnumerable<String> SeniorTravellers(Flight f) {
            var oldTravellers = from p in f.Passengers.OfType<Traveller>()
                                orderby p.BirthDate
                                select p.Nationality;
            return oldTravellers.Take(3);
            //if we want to skip 3
            //return oldTravellers.Skip(3);
        }

        public IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights()
        {
            var req = from f in Flights
                      group f by f.Destination;
            foreach (var g in req)
            {
                Console.WriteLine("Destination: " + g.Key);
                foreach (var f in g)
                    Console.WriteLine("Décollage: " + f.FlightDate);
            }
            return req;
        }

        public Action<Plane> FlightDetailsDel = p =>
        {
            List<Flight> Flights  = new List<Flight>();
            var req = from f in Flights
                      where f.plane == p
                      select new { f.FlightDate, f.Destination };
            foreach (var v in req)
                Console.WriteLine("Flight Date; " + v.FlightDate + " Flight destination: " + v.Destination);
        };

        public Func<string, double> DurationAverageDel = dest =>
        {
            List<Flight> Flights = new List<Flight>();
            return (from f in Flights
                    where f.Destination.Equals(dest)
                    select f.EstimatedDuration).Average();
        };

    }
}

