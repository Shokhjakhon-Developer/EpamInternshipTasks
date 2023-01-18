using System.Globalization;
using Epam.InternshipTasks.Exceptions.Exceptions;
using Epam.InternshipTasks.Exceptions.Mechanical_parts;

namespace Epam.InternshipTasks.Exceptions.Transports;

public class Vehicle
{
    private Engine Engine { get; }
    private Chassis Chassis { get; }
    private Transmission Transmission { get; }

    protected Vehicle(int power, double volume, string type, string serialNum, int wheelsNum,
        int chassisNum, int maxLoad, string transmissionType, int numOfGears, string manufacturer)
    {
        Engine = new Engine(power, volume, type, serialNum);
        Chassis = new Chassis(wheelsNum, chassisNum, maxLoad);
        Transmission = new Transmission(transmissionType, numOfGears, manufacturer);
    }


    protected string GetEngineInfo() =>
        $"Engine Information:\nPower: {Engine.Power} hps,\nVolume: {Engine.Volume} litres," +
        $"\nType: {Engine.Type},\nSerial number: {Engine.SerialNum}.\n";

    protected string GetChassisInfo() => $"\nChassis Information:\nChassis count: {Chassis.ChassisNum},\n" +
                                         $"Wheel count: {Chassis.WheelsNum},\nMaximum load: {Chassis.MaxLoad} kg.\n";

    protected string GetTransmissionInfo() => $"\nTransmission Information:\nType: {Transmission.Type},\n" +
                                              $"Number of gears: {Transmission.NumOfGears},\nManufacturer: {Transmission.Manufacturer}.";

    public bool CheckVehicleByEngine(string param, string value)
    {
        switch (param)
        {
            case "Power":
                return Engine.Power.ToString().Equals(value);
            case "Volume":
                return Engine.Volume.ToString(CultureInfo.InvariantCulture).Equals(value);
            case "Type":
                return Engine.Type.Equals(value);
            case "SerialNum":
                return Engine.SerialNum.Equals(value);
            default:
                throw new GetAutoByParameterException("Can not check vehicle by parameter due to nonexistent parameter");
        }
    }
}