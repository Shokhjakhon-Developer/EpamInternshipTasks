namespace Collections.Mechanical_parts;

public class Engine
{
    public int Power { get; }
    public double Volume { get; }
    public string Type { get; }
    public string SerialNum { get; }

    public Engine(int power, double volume, string type, string serialNum)
    {
        Power = power is >= 50 and <= 500
            ? power
            : throw new ArgumentException($"At least 50 power and at max 500 is expected. Actual: {power}.");
        Volume = volume is >= 0.1 and <= 10
            ? volume
            : throw new ArgumentException($"At least 0.1 volume and at max 10 is expected. Actual: {volume}.");
        Type = !type.Equals("") ? type : throw new ArgumentException("Engine type is empty string.");
        SerialNum = !serialNum.Equals("") ? serialNum : throw new ArgumentException("Serial number is empty string.");
    }
}