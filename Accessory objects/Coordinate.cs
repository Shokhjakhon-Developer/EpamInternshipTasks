namespace EpamTraining.Internship.Interfaces.Accessory_objects;

public readonly struct Coordinate
{
    public double X { get; }
    public double Y { get; }
    public double Z { get; }
    public Coordinate(double x, double y, double z) => (X, Y, Z) = (Math.Abs(x), Math.Abs(y), Math.Abs(z));


    //Method FindDistance finds a distance between two vectors using mathematical formula. 
    public double FindDistance(Coordinate coordinate)
    {
        var (x, y, z) = (X, Y, Z);
        var (x1, y1, z1) = (coordinate.X, coordinate.Y, coordinate.Z);
        var expression = Math.Pow(x - x1, 2) + Math.Pow(y - y1, 2) + Math.Pow(z - z1, 2);
        return Math.Sqrt(expression);
    }
}