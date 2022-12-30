namespace Practical_Task_3;

public class Transmission
{
    public string Type { get; }
    public int NumOfGears { get; }
    public string Manufacturer { get; }

    public Transmission(string type, int numOfGears, string manufacturer) =>
        (Type, NumOfGears, Manufacturer) = (type, numOfGears, manufacturer);
}