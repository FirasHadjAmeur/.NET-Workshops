// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;





Plane p1 = new Plane();

p1.Capacity = 200;
p1.ManufactureDate = new DateTime(2015, 01, 16);
p1.Planetype = PlaneType.Boing;
p1.PlaneId = 2;

Console.WriteLine(p1);

Plane p2 = new Plane(10, new DateTime(2015, 01, 16), 0);


Console.WriteLine(p2);

Plane p3 = new Plane()
{
    Capacity = 200,
    ManufactureDate = new DateTime(),
    Planetype = 0,
    PlaneId = 3
};

Passenger passenger = new Passenger();
passenger.PassengerType();

Staff staff = new Staff();
staff.PassengerType();

Traveller traveller = new Traveller();
traveller.PassengerType();

Console.WriteLine("Hello, World!");


