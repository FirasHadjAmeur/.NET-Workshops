using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public static class TestData
    {
        static Plane p1 = new Plane(150, new DateTime(02 / 05 / 2015), PlaneType.Boing);
        static Plane p2 = new Plane(250, new DateTime(11 / 11 / 2020), PlaneType.Airbus);
        static Staff s1 = new Staff { FirstName = "captain", LastName = "captain", EmailAddress = "captain@gmail", BirthDate = new DateTime(01 / 02 / 1995), EmployementDate = new DateTime(01 / 01 / 1999), Salary = 999 };
        static Staff s2 = new Staff { FirstName = "hostess1", LastName = "hostess1", EmailAddress = "hostess1@gmail", BirthDate = new DateTime(01 / 02 / 2005), EmployementDate = new DateTime(01 / 01 / 2005), Salary = 888 };
        static Traveller t1 = new Traveller { FirstName = "Traveller", LastName = "Traveller", EmailAddress = "Traveller@gmail", BirthDate = new DateTime(01 / 02 / 2005), HealthInformation = "M9a3ed", Nationality = "Bengladeshi" };
        static Traveller t2 = new Traveller { FirstName = "Ahmed", LastName = "Traveller2", EmailAddress = "Traveller2@gmail", BirthDate = new DateTime(01 / 02 / 2005), HealthInformation = "Yno55", Nationality = "BorjErroumi" };
        static Flight f1 = new Flight()
        {
            FlightDate = new DateTime(2022, 01, 01, 15, 10, 10),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 01, 02, 15, 10, 10),
            plane = p2,
            EstimatedDuration = 110,
            Passengers = new List<Passenger> { t1, t2 }
        };
        public static List<Flight> listFlights = new List<Flight>() { f1 };
    }
}
