using System.Text.Json.Serialization;

namespace PaperQualityControl.Models
{
    public record Rectangle(int X, int Y, int Width, int Height)
    {
        public static Rectangle Empty { get; } = new(0, 0, 0, 0);

        [JsonIgnore]
        public int Area => Width * Height;
    }
}
