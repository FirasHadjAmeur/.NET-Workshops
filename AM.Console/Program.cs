// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using AM.Infrastructure;

Console.WriteLine("Hello, World!");

AMContext context= new AMContext();
context.Flights.Add(new Flight { 
    FlightId = 1, 
    Departure = "Tunis",
    Destination = "Paris", 
    EstimatedDuration = 150, 
    FlightDate = DateTime.Now,
    Plane = new Plane    
});
context.SaveChanges();



