using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperQualityControl.Models
{
    public record TrainingImage
    {
        public required string ImagePath { get; init; }
        public required string Category { get; init; }
        public required SensorData SensorData { get; init; }
        public required DateTime Timestamp { get; init; }
    }
}
