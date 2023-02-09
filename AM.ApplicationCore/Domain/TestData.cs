using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public static class TestData
    {

        public static Plane p1 = new Plane()
        {
            Planetype = PlaneType.Boing,
            Capacity = 150,
            ManufactureDate = new DateTime(2015, 02, 03)
        };
        public static Plane p2 = new Plane()
        {
            Planetype = PlaneType.Airbus,
            Capacity = 250,
            ManufactureDate = new DateTime(2020, 11, 2020)
        };
        public static IList<Plane> listPlanes = new List<Plane>() { p1, p2 };


        public static Staff s1 = new Staff()
        {
            FirstName = "Captain",
            LastName = "captain",
            EmailAddress = "Captain.captain@gmail.com",
            BirthDate = new DateTime(1965, 01, 01),
            EmployementDate = new DateTime(1999, 01, 01),
            Salary = 99999
        };
        public static Staff s2 = new Staff()
        {
            FirstName = "hostess1",
            LastName = "hostess1",
            EmailAddress = "hostess1.hostess1@gmail.com",
            BirthDate = new DateTime(1995, 01, 01),
            EmployementDate = new DateTime(2020, 01, 01),
            Salary = 999
        };
        public static IList<Staff> listStaff = new List<Staff>() { s1, s2 };

        public static Traveller t1 = new Traveller()
        {
            FirstName = "Traveller1",
            LastName = "Traveller1",
            EmailAddress = "Traveller1.traveller1@gmail.com",
            BirthDate = new DateTime(1980, 01, 01),
            HealthInformation = "No Troubles",
            Nationality = "American"
        };
        public static Traveller t2 = new Traveller()
        {
            FirstName = "Traveller2",
            LastName = "Traveller2",
            EmailAddress = "Traveller2.traveller2@gmail.com",
            BirthDate = new DateTime(1981, 01, 01),
            HealthInformation = "Some Troubles",
            Nationality = "French"
        };
        public static IList<Traveller> listTravellers = new List<Traveller>() { t1, t2 };


        public static Flight f1 = new Flight()
        {
            FlightDate = new DateTime(01, 01, 2022, 15, 10, 10),
            Destination = "Paris",
            EffectiveArrival = new DateTime(01, 01, 2022, 17, 10, 10),
            plane = p2,
            EstimatedDuration = 110,
            Passengers = { t1, t2 }
        };
        public static Flight f2 = new Flight()
        {
            FlightDate = new DateTime(01, 01, 2022, 21, 10, 10),
            Destination = "Paris",
            EffectiveArrival = new DateTime(01, 01, 2022, 13, 10, 10),
            plane = p1,
            EstimatedDuration = 105,
        };
        public static IList<Flight> listFlights = new List<Flight>() { f1, f2 };



    }
}
