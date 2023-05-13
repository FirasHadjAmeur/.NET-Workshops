using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : IServiceFlight
    {
        public IList<Flight> Flights { get; set; }

        public ServiceFlight()
        {
            Flights = new List<Flight>();
        }

        //public List<DateTime> GetFlightDates(string destination)
        //{
        //    List<DateTime> dates = new List<DateTime>();
        //    foreach (Flight f in Flights)
        //    {
        //        if (f.Destination == destination)
        //        {
        //            dates.Add(f.FlightDate);
        //        }
        //    }
        //    return dates;
        //}

        //  GetFlightDates using LINQ

        public List<DateTime> GetFlightDates(string destination)
        {
            var dates = from f in Flights
                        where f.Destination == destination
                        select f.FlightDate;
            return dates.ToList();
        }

        public void GetFlights(string filterType, string filterValue)
        {
            foreach (Flight f in Flights)
            {
                if (filterType == "Destination")
                {
                    if (f.Destination == filterValue)
                    {
                        Console.WriteLine(f);
                    }
                }
                else if (filterType == "Departure")
                {
                    if (f.Departure == filterValue)
                    {
                        Console.WriteLine(f);
                    }
                }
                else if (filterType == "FlightDate")
                {
                    if (f.FlightDate == DateTime.Parse(filterValue))
                    {
                        Console.WriteLine(f);
                    }
                }
                else if (filterType == "EstimatedDuration")
                {
                    if (f.EstimatedDuration == float.Parse(filterValue))
                    {
                        Console.WriteLine(f);
                    }
                }
                else if (filterType == "EffectiveArrival")
                {
                    if (f.EffectiveArrival == DateTime.Parse(filterValue))
                    {
                        Console.WriteLine(f);
                    }
                }
            }
        }
    }
}
