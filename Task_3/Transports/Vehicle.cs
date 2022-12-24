namespace Practical_Task_3;

public class Vehicle
{
    private readonly Engine _engine;
    private readonly Chassis _chassis;
    private readonly Transmission _transmission;

    protected Vehicle(int power, double volume, string type, string serialNum, int wheelsNum,
        int chassisNum, int maxLoad, string transmissionType, int numOfGears, string manufacturer)
    {
        _engine = new Engine(power, volume, type, serialNum);
        _chassis = new Chassis(wheelsNum, chassisNum, maxLoad);
        _transmission = new Transmission(transmissionType, numOfGears, manufacturer);
    }


    protected string GetEngineInfo() =>
        $"Engine Information:\nPower: {_engine.Power} hps,\nVolume: {_engine.Volume} litres," +
        $"\nType: {_engine.Type},\nSerial number: {_engine.SerialNum}.\n";

    protected string GetChassisInfo() => $"\nChassis Information:\nChassis count: {_chassis.ChassisNum},\n" +
                                         $"Wheel count: {_chassis.WheelsNum},\nMaximum load: {_chassis.MaxLoad} kg.\n";

    protected string GetTransmissionInfo() => $"\nTransmission Information:\nType: {_transmission.Type},\n" +
                                              $"Number of gears: {_transmission.NumOfGears},\nManufacturer: {_transmission.Manufacturer}.";
}