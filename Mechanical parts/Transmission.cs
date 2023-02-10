namespace OOP.Mechanical_parts;

public class Transmission
{
    public string Type { get; }
    public int NumOfGears { get; }
    public string Manufacturer { get; }

    public Transmission(string type, int numOfGears, string manufacturer)
    {
        (Type, NumOfGears, Manufacturer) = (type, numOfGears, manufacturer);
        Type = !type.Equals("") ? type : throw new ArgumentException("Transmission type is empty string.");
        NumOfGears = numOfGears is > 0 and <= 20
            ? numOfGears
            : throw new ArgumentException($"At least 1 gear and at max 20 is expected. Actual: {numOfGears}.");
        Type = !manufacturer.Equals("") ? manufacturer : throw new ArgumentException("Manufacturer is empty string.");
    }
}