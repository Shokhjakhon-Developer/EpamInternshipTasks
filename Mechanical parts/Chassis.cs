namespace Collections.Mechanical_parts;

public class Chassis
{
    public int WheelsNum { get; }
    public int ChassisNum { get; }
    public int MaxLoad { get; }

    public Chassis(int wheelsNum, int chassisNum, int maxLoad)
    {
        WheelsNum = wheelsNum is > 1 and <= 10
            ? wheelsNum
            : throw new ArgumentException($"At least 2 wheels and at max 10 is expected. Actual: {wheelsNum} wheel.");
        ChassisNum = chassisNum is > 0 and <= 4
            ? chassisNum
            : throw new ArgumentException(
                $"At least 1 chassis and at max 4 chassis is expected. Actual: {chassisNum}.");
        MaxLoad = maxLoad is >= 50 and <= 20000
            ? maxLoad
            : throw new ArgumentException($"At least 50 kg and at max 20000 kg load is expected. Actual: {maxLoad}.");
    }
}