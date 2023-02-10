namespace InterfaceAndAbstractClasses.Accessory_objects;

public interface IFlyable
{
    public void FlyTo(Coordinate coordinate);
    public double GetFlyTime(Coordinate coordinate);
}