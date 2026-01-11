public class DroneController
{
    private readonly IEnumerable<Drone> _drones;
    private readonly ILoggerService _logger;

    public DroneController(IEnumerable<Drone> drones, ILoggerService logger)
    {
        _drones = drones;
        _logger = logger;
    }

    public void PollDrones()
    {
        foreach (var drone in _drones)
        {
            drone.UpdateTelemetry();

            _logger.LogTelemetry(
                drone.DroneId,
                drone.Altitude,
                drone.Speed
                );

            Console.WriteLine(
                $"Drone {drone.DroneId} | Altitude: {drone.Altitude} ft | Speed: {drone.Speed} kts"
                );
        }
    }
}
