// See https://aka.ms/new-console-template for more information

using OOP.Transports;

PassengerCar starCar = new PassengerCar(325, 3, "Inline", "158859",
    4, 1, 2000, "Automatic", 10, "Star Vehicle Production");

Truck starTruck = new Truck(500, 10, "Inline", "998552", 6,
    2, 15000, "Automatic", 20, "Star Vehicle Production");

Bus starBus = new Bus(450, 6, "Inline", "556589", 6,
    2, 8000, "Automatic", 15, "Star Vehicle Production");

Scooter starScooter = new Scooter(60, 0.5, "Inline", "121585", 2, 1,
    120, "No", 2, "Star Vehicle Production");

Console.WriteLine(starCar);
Console.WriteLine(starTruck);
Console.WriteLine(starBus);
Console.WriteLine(starScooter);