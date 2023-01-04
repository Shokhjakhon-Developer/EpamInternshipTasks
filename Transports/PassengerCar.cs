namespace Practical_Task_3;

public class PassengerCar : Vehicle
{
    private const string Description = "Passenger Car Characteristics \n";

    public PassengerCar(int power, double volume, string type, string serialNum,
        int wheelsNum, int chassisNum, int maxLoad,
        string transmissionType, int numOfGears, string manufacturer) : base(power, volume, type, serialNum,
        wheelsNum, chassisNum, maxLoad, transmissionType, numOfGears, manufacturer)
    {
    }


    public override string ToString() => Description + GetEngineInfo() + GetChassisInfo() + GetTransmissionInfo();
}