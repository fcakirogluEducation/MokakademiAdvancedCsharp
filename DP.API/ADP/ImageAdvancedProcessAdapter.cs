namespace DP.API.ADP
{
    public class ImageAdvancedProcessAdapter : IImageProcess
    {
        private AdvancedImageProcess _advancedImageProcess;

        public ImageAdvancedProcessAdapter(AdvancedImageProcess advancedImageProcess)
        {
            _advancedImageProcess = advancedImageProcess;
        }


        public void ProcessImage(IFormFile file, string watermark)
        {



            _advancedImageProcess.ProcessImage(file, watermark, "blue");

        }
    }
}
