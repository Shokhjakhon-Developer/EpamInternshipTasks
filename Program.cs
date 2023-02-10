// See https://aka.ms/new-console-template for more information

using Collections.Transports;
using Collections.Xml_Data;

Vehicle[] collection =
{
    new PassengerCar(325, 3, "Inline", "158859",
        4, 1, 2000, "Automatic", 10, "Star Vehicle Production"),

    new Truck(500, 10, "Inline", "998552", 6,
        2, 15000, "Automatic", 18, "Star Vehicle Production"),

    new Bus(450, 6, "Inline", "556589", 4,
        2, 8000, "Automatic", 15, "Star Vehicle Production"),

    new Scooter(60, 0.5, "Inline", "121585", 2, 1,
        120, "No", 2, "Star Vehicle Production")
};

//For task 1.
Console.WriteLine(collection[0]);
Console.WriteLine(collection[1]);
Console.WriteLine(collection[2]);
Console.WriteLine(collection[3]);

//For task 2.
Console.WriteLine(XmlData.ShowByEngineCapacity());
Console.WriteLine("////////////////////////////");
Console.WriteLine(XmlData.ShowOnlyBusAndTruck());
Console.WriteLine("////////////////////////////");
Console.WriteLine(XmlData.ShowByTransmissionType());