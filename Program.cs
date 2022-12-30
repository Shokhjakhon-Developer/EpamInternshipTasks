// See https://aka.ms/new-console-template for more information

using EpamTraining.Internship.Interfaces.Accessory_objects;
using EpamTraining.Internship.Interfaces.Flying_objects;

Bird bird = new Bird(1, 1, 1);
Airplane airplane = new Airplane(1, 1, 1);
Drone drone = new Drone(1, 1, 1);
Coordinate coordinate = new Coordinate(548, 548, 548);

bird.FlyTo(coordinate);
airplane.FlyTo(coordinate);
drone.FlyTo(coordinate);

Console.WriteLine($"{bird}\n{airplane}\n{drone}");