// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;




 ServiceFlight S = new ServiceFlight() { Flights = TestData.listFlights.ToList() };

Console.WriteLine("Flights:");
foreach (var item in S.Flights)
{
    Console.WriteLine(item);
}
Console.WriteLine(
    "\n---------------------\n" +
       "Flights with passengers:");
foreach (var item in S.Flights)
{
    Console.WriteLine(item);
    foreach (var item2 in item.Passengers)
    {
        Console.WriteLine(item2);
    }
}



