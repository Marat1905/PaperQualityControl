using PaperQualityControl.Models;

namespace PaperQualityControl.Services
{
    public interface IDataService
    {
        Task SaveImageAsync(byte[] imageData, string category, SensorData sensorData);
        Task<List<TrainingImage>> GetTrainingImagesAsync(string? category = null);
        Task<bool> ExportDatasetAsync(string exportPath);
        Task<bool> ImportDatasetAsync(string importPath);
        Task<int> GetImageCountAsync(string category);
    }
}
