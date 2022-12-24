namespace Practical_Task_3;

public class Engine
{
    public int Power { get; }
    public double Volume { get; }
    public string Type { get; }
    public string SerialNum { get; }

    public Engine(int power, double volume, string type, string serialNum) =>
        (Power, Volume, Type, SerialNum) = (power, volume, type, serialNum);
}