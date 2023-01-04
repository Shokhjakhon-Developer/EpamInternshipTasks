namespace Practical_Task_3;

public class Truck : Vehicle
{
    private const string Description = "\nTruck Characteristics \n";

    public Truck(int power, double volume, string type,
        string serialNum, int wheelsNum, int chassisNum,
        int maxLoad, string transmissionType, int numOfGears, string manufacturer) : base(power, volume, type,
        serialNum, wheelsNum,
        chassisNum, maxLoad, transmissionType, numOfGears, manufacturer)
    {
    }

    public override string ToString() => Description + GetEngineInfo() + GetChassisInfo() + GetTransmissionInfo();
}