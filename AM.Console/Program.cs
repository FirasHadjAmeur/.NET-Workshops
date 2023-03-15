// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using AM.Infrastructure;

Console.WriteLine("Hello, World!");

AMContext context= new AMContext();
//context.Flights.Add(new Flight { 
    
//    Departure = "Tunis",
//    Destination = "Paris", 
//    EstimatedDuration = 150, 
//    FlightDate = DateTime.Now,
//    Plane = new Plane (){
       
//    Capacity = 100,
//    ManufactureDate= DateTime.Now,
//    PlaneType = PlaneType.Boing
//    }
//});
context.SaveChanges();
foreach (var flight in context.Flights.ToList())
{
    Console.WriteLine(flight.FlightId + " || " + flight.Plane.Capacity);
}



