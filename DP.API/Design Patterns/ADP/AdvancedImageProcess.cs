namespace DP.API.ADP
{
    public class AdvancedImageProcess
    {

        private readonly ILogger<ImageAdvancedProcessAdapter> _logger;

        public AdvancedImageProcess(ILogger<ImageAdvancedProcessAdapter> logger)
        {
            _logger = logger;
        }

        public void ProcessImage(IFormFile file, string watermark, string color)
        {

            // wwwroot/images/1.jpg
            _logger.LogInformation($" Advanced Processing image {file.FileName} with watermark {watermark} Color= {color}");
        }
    }
}
