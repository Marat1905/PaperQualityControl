namespace PaperQualityControl.Models
{
    public record SensorData
    {
        public required float Tension { get; init; }
        public required float Humidity { get; init; }
        public required float Temperature { get; init; }
        public required float Speed { get; init; }
        public required DateTime Timestamp { get; init; }
    }
}
