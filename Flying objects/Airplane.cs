using InterfaceAndAbstractClasses.Accessory_objects;

namespace InterfaceAndAbstractClasses.Flying_objects;

public class Airplane : IFlyable
{
    //Airplane can fly only 13 hours at once.
    private const int FlyLimit = 13;

    //Airplane can fly up to 10000 kms at once.
    private const int DistanceLimit = 10000;

    // Speed is 200kms/h.
    private const int Speed = 200;

    //Airplane's current position.
    private Coordinate _currentPosition;

    public Airplane(double x, double y, double z) => _currentPosition = new Coordinate(x, y, z);

    public void FlyTo(Coordinate coordinate)
    {
        //First, we find the distance between our coordinates current and destination.
        double distance = _currentPosition.FindDistance(coordinate);
        //Then, we check whether our airplane can fly through the distance without reaching distance limit, if so our current position changes to destination.
        _currentPosition = distance > DistanceLimit ? _currentPosition : coordinate;
    }

    public double GetFlyTime(Coordinate coordinate)
    {
        //First, we find total time needed to cross the distance.
        double distance = _currentPosition.FindDistance(coordinate);
        double time = FindTotalTime(distance);
        //Then, we check if needed time does not exceed out time limit.
        return time > FlyLimit ? -1 : time;
    }

    //Method FindTotalTime takes distance and divides it by speed that changes every 10 kms by 10 kms/h.
    private double FindTotalTime(double d)
    {
        var iterations = d / 10.0; //We find total number of iterations or total distance in terms of 10 kms.
        var time = 0.0;
        var speed = Speed;
        for (var i = 0; i < Math.Floor(iterations); i++)
        {
            time += 10.0 / speed; //Simple formula to find time time = distance / speed
            if (speed < 400)
            {
                speed += 10; //If our speed reaches 400 kms/h , it will not change further and will stay constant.
            }
        }

        return time;
    }

    public override string ToString()
    {
        return $"Airplane's current position: [{_currentPosition.X}, {_currentPosition.Y}, {_currentPosition.Z}].";
    }
}