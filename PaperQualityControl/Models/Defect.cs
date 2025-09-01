namespace PaperQualityControl.Models
{
    public record Defect
    {
        public required string Type { get; init; }
        public required float Confidence { get; init; }
        public required Rectangle Location { get; init; }
        public required DateTime Timestamp { get; init; }
        public string? ImagePath { get; init; }
    }
}
