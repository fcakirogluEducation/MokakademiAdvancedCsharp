namespace DP.API.ADP
{
    public class ImageProcess(ILogger<ImageProcess> logger) : IImageProcess
    {
        public void ProcessImage(IFormFile file, string watermark)
        {
            //type=1 /2

            // wwwroot/images/1.jpg
            // color => blue;
            logger.LogInformation($"Processing image {file.FileName} with watermark {watermark}");
        }
    }
}
