using EpamTraining.Internship.Interfaces.Accessory_objects;

namespace EpamTraining.Internship.Interfaces.Flying_objects;

public class Bird : IFlyable
{
    //Average bird can fly only 6 hours at once.
    private const int FlyLimit = 6;

    //Average bird can fly up to 75 kms at once.
    private const int DistanceLimit = 72;

    //Speed is 12kms/h.
    private const int Speed = 12;

    //Bird's current position.
    private Coordinate _currentPosition;

    public Bird(double x, double y, double z) => _currentPosition = new Coordinate(x, y, z);

    public void FlyTo(Coordinate coordinate)
    {
        //First, we find the distance between our current coordinates and destination.
        double distance = _currentPosition.FindDistance(coordinate);
        //Then, we check whether our bird can fly through the distance without stopping, if so our current position changes to destination.
        _currentPosition = distance > DistanceLimit ? _currentPosition : coordinate;
    }

    public double GetFlyTime(Coordinate coordinate)
    {
        //First, we find total time needed to cross the distance.
        double time = _currentPosition.FindDistance(coordinate) / Speed;
        //Then, we check if needed time does not exceed out time limit.
        return time > FlyLimit ? -1 : time;
    }

    public override string ToString()
    {
        return $"Bird's current position: [{_currentPosition.X}, {_currentPosition.Y}, {_currentPosition.Z}].";
    }
}