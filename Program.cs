class Program
{
    static void Main()
    {
        // 1. Create shared dependencies
        var random = new Random();

        // 2. Create services
        ITelemetryService telemetry = new RandomTelemetryService(random);
        ILoggerService logger = new LoggerService("telemetry.csv");
        // 3. Create domain objects
        var drones = new List<Drone>
        {
            new Drone(1, telemetry),
            new Drone(2, telemetry),
            new Drone(3, telemetry)
        };

        // 4. Create controller (presentation layer)
        var controller = new DroneController(drones, logger);

        // 5. Run the application
        controller.PollDrones();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
;
