public class Drone
{

    private readonly ITelemetryService _telemetry;

    public int DroneId { get; }
    public int Altitude { get; private set; }
    public int Speed { get; private set; }

    public Drone(int droneId, ITelemetryService telemetry)
    {
        DroneId = droneId;
        _telemetry = telemetry;
    }

    public void UpdateTelemetry()
    {
        Altitude = _telemetry.GetAltitude();
        Speed = _telemetry.GetSpeed();
    }

}


