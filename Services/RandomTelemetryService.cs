
public class RandomTelemetryService : ITelemetryService
{

    private readonly Random _random;

    public RandomTelemetryService(Random random)
    {
        _random = random;
    }

    public int GetAltitude()
    {
        return _random.Next(2000, 8000);
    }

    public int GetSpeed()
    {
        return _random.Next(80, 160);
    }
}
