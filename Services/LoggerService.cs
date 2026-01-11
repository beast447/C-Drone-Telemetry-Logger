using System;
using System.IO;


public class LoggerService : ILoggerService
{
    private readonly string _filepath;

    public LoggerService(string filepath)
    {
        _filepath = filepath;

        if (!File.Exists(_filepath))
        {
            File.WriteAllText(_filepath, "Timestamp,DroneId,Altitude,Speed\n");
        }
    }

    public void LogTelemetry(int DroneId, int Altitude, int Speed)
    {
        var timestamp = DateTime.UtcNow.ToString("o");

        var line = $"{timestamp},{DroneId},{Altitude},{Speed}";
        File.AppendAllText(_filepath, line + Environment.NewLine);
    }
}

