namespace Practical_Task_3;

public class Scooter : Vehicle
{
    private const string Description = "\nScooter Characteristics \n";

    public Scooter(int power, double volume, string type,
        string serialNum, int wheelsNum, int chassisNum, int maxLoad,
        string transmissionType, int numOfGears, string manufacturer) : base(power, volume, type, serialNum,
        wheelsNum, chassisNum, maxLoad, transmissionType, numOfGears, manufacturer)
    {
    }


    public override string ToString() => Description + GetEngineInfo() + GetChassisInfo() + GetTransmissionInfo();
}