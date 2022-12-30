using EpamTraining.Internship.Interfaces.Accessory_objects;

namespace EpamTraining.Internship.Interfaces.Flying_objects;

public class Drone : IFlyable
{
    //Drone can fly only 10 minutes or 0.17 hours at once and then it will rest for 1 minute.
    private const double FlyLimit = 0.17;

    //Drone can fly up to 1000 kms at once with all stops.
    private const int DistanceLimit = 1000;

    //Speed is 75kms/h.
    private const int Speed = 75;

    //Drone's current position.
    private Coordinate _currentPosition;

    public Drone(double x, double y, double z) => _currentPosition = new Coordinate(x, y, z);

    public void FlyTo(Coordinate coordinate)
    {
        //First, we find the distance between our coordinates current and destination.
        double distance = _currentPosition.FindDistance(coordinate);
        //Then, we check whether our drone can fly that far if so our current position changes to destination.
        _currentPosition = distance > DistanceLimit ? _currentPosition : coordinate;
    }

    public double GetFlyTime(Coordinate coordinate)
    {
        //Total time we need to get to destination if drone did not stop at all.
        double timeWithoutStops = _currentPosition.FindDistance(coordinate) / Speed;
        //Total number of stops that we need in order to get to our destination.
        double stops = timeWithoutStops / FlyLimit;
        //Total time we need in order to get to our destination.
        double time = timeWithoutStops + stops / 60;
        return time;
    }

    public override string ToString()
    {
        return $"Drone's current position: [{_currentPosition.X}, {_currentPosition.Y}, {_currentPosition.Z}].";
    }
}