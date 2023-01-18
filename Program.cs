// See https://aka.ms/new-console-template for more information

using Epam.InternshipTasks.Exceptions.Exceptions;
using Epam.InternshipTasks.Exceptions.Transports;

PassengerCar starCar;
Truck starTruck;
Bus starBus;
Scooter starScooter;
List<Vehicle> vehicles = new List<Vehicle>();
if (vehicles == null) throw new ArgumentNullException(nameof(vehicles));


try
{
    starCar = new PassengerCar(325, 3, "Inline", "158859",
        4, 1, 2000, "Automatic", 10, "Star Vehicle Production");

    starTruck = new Truck(600, 10, "Inline", "998552", 6,
        2, 15000, "Automatic", 25, "Star Vehicle Production");

    starBus = new Bus(450, 6, "Inline", "556589", 4,
        2, 8000, "Automatic", 15, "Star Vehicle Production");

    starScooter = new Scooter(30, 0.5, "Inline", "121585", 2, 1,
        120, "No", 2, "Star Vehicle Production");
}
catch (InitializationException e)
{
    throw new InitializationException("Objects can not be initialized.", e);
}


try
{
    vehicles.Add(starCar);
    vehicles.Add(starTruck);
    vehicles.Add(starBus);
    vehicles.Add(starScooter);
}
catch (AddException e)
{
    throw new AddException("Can not add vehicles to the list.", e);
}


try
{
    vehicles[5] = starBus;
}
catch (UpdateAutoException e)
{
    throw new UpdateAutoException("Can not replace vehicle due to nonexistent identifier.", e);
}

try
{
    vehicles.RemoveAt(5);
}
catch (RemoveAutoException e)
{
    throw new RemoveAutoException("Can not remove item at given index due to nonexistent index.", e);
}

//Check the implementation of this method
vehicles[0].CheckVehicleByEngine("Height", "5000");
