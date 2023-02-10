using System.Xml.Linq;

namespace Collections.Xml_Data;

public static class XmlData
{
    //All information about all vehicles an engine capacity of which is more than 1.5 liters.
    public static XElement ShowByEngineCapacity()
    {
        XElement bigVehicles = new XElement("Vehicles",
            new XElement("PassengerCar",
                new XElement("Engine",
                    new XElement("SerialNum", "158859"),
                    new XElement("Power", 325),
                    new XElement("Volume", 3),
                    new XElement("Type", "Inline")),
                new XElement("Chassis",
                    new XElement("WheelsNum", 4),
                    new XElement("ChassisNum", 1),
                    new XElement("MaxLoad", 2000)),
                new XElement("Transmission",
                    new XElement("Type", "Automatic"),
                    new XElement("GearsNum", 10),
                    new XElement("Manufacturer", "Star Vehicle Production"))),
            new XElement("Truck",
                new XElement("Engine",
                    new XElement("SerialNum", "998552"),
                    new XElement("Power", 600),
                    new XElement("Volume", 10),
                    new XElement("Type", "Inline")),
                new XElement("Chassis",
                    new XElement("WheelsNum", 6),
                    new XElement("ChassisNum", 2),
                    new XElement("MaxLoad", 15000)),
                new XElement("Transmission",
                    new XElement("Type", "Automatic"),
                    new XElement("GearsNum", 15),
                    new XElement("Manufacturer", "Star Vehicle Production"))),
            new XElement("Bus",
                new XElement("Engine",
                    new XElement("SerialNum", "556589"),
                    new XElement("Power", 450),
                    new XElement("Volume", 6),
                    new XElement("Type", "Inline")),
                new XElement("Chassis",
                    new XElement("WheelsNum", 4),
                    new XElement("ChassisNum", 2),
                    new XElement("MaxLoad", 8000)),
                new XElement("Transmission",
                    new XElement("Type", "Automatic"),
                    new XElement("GearsNum", 15),
                    new XElement("Manufacturer", "Star Vehicle Production"))));
        return bigVehicles;
    }

    //Engine type, serial number and power rating for all buses and trucks.
    public static XElement ShowOnlyBusAndTruck()
    {
        XElement busAndTruck = new XElement("Vehicles",
            new XElement("Truck",
                new XElement("Engine",
                    new XElement("SerialNum", "998552"),
                    new XElement("Power", 600),
                    new XElement("Volume", 10),
                    new XElement("Type", "Inline")),
                new XElement("Bus",
                    new XElement("Engine",
                        new XElement("SerialNum", "556589"),
                        new XElement("Power", 450),
                        new XElement("Volume", 6),
                        new XElement("Type", "Inline"))
                )));
        return busAndTruck;
    }

    //All information about all vehicles, grouped by transmission type.
    public static XElement ShowByTransmissionType()
    {
        XElement bigVehicles = new XElement("Vehicles",
            new XElement("PassengerCar",
                new XElement("Transmission",
                    new XElement("Type", "Automatic"),
                    new XElement("GearsNum", 10),
                    new XElement("Manufacturer", "Star Vehicle Production")),
                new XElement("Engine",
                    new XElement("SerialNum", "158859"),
                    new XElement("Power", 325),
                    new XElement("Volume", 3),
                    new XElement("Type", "Inline")),
                new XElement("Chassis",
                    new XElement("WheelsNum", 4),
                    new XElement("ChassisNum", 1),
                    new XElement("MaxLoad", 2000))),
            new XElement("Truck",
                new XElement("Transmission",
                    new XElement("Type", "Automatic"),
                    new XElement("GearsNum", 15),
                    new XElement("Manufacturer", "Star Vehicle Production")),
                new XElement("Engine",
                    new XElement("SerialNum", "998552"),
                    new XElement("Power", 600),
                    new XElement("Volume", 10),
                    new XElement("Type", "Inline")),
                new XElement("Chassis",
                    new XElement("WheelsNum", 6),
                    new XElement("ChassisNum", 2),
                    new XElement("MaxLoad", 15000))),
            new XElement("Bus",
                new XElement("Transmission",
                    new XElement("Type", "Automatic"),
                    new XElement("GearsNum", 15),
                    new XElement("Manufacturer", "Star Vehicle Production")),
                new XElement("Engine",
                    new XElement("SerialNum", "556589"),
                    new XElement("Power", 450),
                    new XElement("Volume", 6),
                    new XElement("Type", "Inline")),
                new XElement("Chassis",
                    new XElement("WheelsNum", 4),
                    new XElement("ChassisNum", 2),
                    new XElement("MaxLoad", 8000))));
        return bigVehicles;
    }
}