using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction.Models;

namespace EmotionDrawing.UI.Services.Interfaces
{
    public interface ICustomVisionService
    {
        Task<ImagePrediction> ClassificarImagemAsync(Stream imageStream);
    }
}
