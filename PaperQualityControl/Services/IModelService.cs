using PaperQualityControl.Models;

namespace PaperQualityControl.Services
{
    public interface IModelService
    {
        Task<bool> LoadModelAsync(string modelPath);
        Task<List<Defect>> AnalyzeImageAsync(byte[] imageData);
        Task TrainModelAsync(string datasetPath, string outputModelPath);
        Task<double> ValidateModelAsync(string testDatasetPath);
        Task<bool> IncrementalTrainAsync(string newDataPath, string baseModelPath, string outputModelPath);
        Task<bool> FineTuneModelAsync(string datasetPath, string baseModelPath, string outputModelPath, double learningRate = 0.001);

        bool IsTraining { get; }
        double TrainingProgressPercentage { get; }

        event EventHandler<string>? TrainingProgress;
    }
}
