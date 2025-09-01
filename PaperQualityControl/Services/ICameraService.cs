using PaperQualityControl.Enums;

namespace PaperQualityControl.Services
{
    public interface ICameraService
    {
        Task<bool> InitializeAsync(string? cameraParameter = null);
        Task<byte[]?> CaptureImageAsync();
        Task StartContinuousCapture(Action<byte[]> onFrameCaptured);
        void StopContinuousCapture();
        Task<List<string>> GetAvailableCamerasAsync();
        Task<byte[]?> LoadImageFromFileAsync(string? filePath = null);

        bool IsCameraAvailable { get; }
        bool IsCapturing { get; }
        string CameraName { get; }
        CameraType SelectedCameraType { get; set; }

        event EventHandler<string>? ErrorOccurred;
        event EventHandler<string>? StatusChanged;
    }
}
