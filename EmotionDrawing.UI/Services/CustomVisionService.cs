using EmotionDrawing.UI.Services.Interfaces;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction.Models;

namespace EmotionDrawing.UI.Services
{
    public class CustomVisionService : ICustomVisionService
    {
        private readonly CustomVisionPredictionClient _client;
        private readonly Guid _projectId;
        private readonly string _publishedName;
        public CustomVisionService(IConfiguration config)
        {
            var predictionKey = config["CustomVision:PredictionKey"];
            var predictionEndpointFile = config["CustomVision:PredictionEndpointFile"];
            _projectId = Guid.Parse(config["CustomVision:ProjectId"]);
            _publishedName = config["CustomVision:PublishedName"];

            _client = new CustomVisionPredictionClient(new ApiKeyServiceClientCredentials(predictionKey))
            {
                Endpoint = predictionEndpointFile
            };
        }

        public async Task<ImagePrediction> ClassificarImagemAsync(Stream imageStream)
         {
            try
            {
                return await _client.ClassifyImageAsync(  _projectId
                                                        , _publishedName
                                                        , imageStream);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Erro ao analisar desenho, tente novamente mais tarde.", ex);
            }
        }

    }
}
