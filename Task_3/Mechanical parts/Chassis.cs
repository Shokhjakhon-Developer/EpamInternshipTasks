namespace Practical_Task_3;

public class Chassis
{
    public int WheelsNum { get; }
    public int ChassisNum { get; }
    public int MaxLoad { get; }

    public Chassis(int wheelsNum, int chassisNum, int maxLoad) =>
        (WheelsNum, ChassisNum, MaxLoad) = (wheelsNum, chassisNum, maxLoad);
}