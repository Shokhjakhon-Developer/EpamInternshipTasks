namespace Epam.InternshipTasks.Exceptions.Mechanical_parts;

public class Transmission
{
    public string Type { get; }
    public int NumOfGears { get; }
    public string Manufacturer { get; }

    public Transmission(string type, int numOfGears, string manufacturer) =>
        (Type, NumOfGears, Manufacturer) = (type, numOfGears, manufacturer);
}