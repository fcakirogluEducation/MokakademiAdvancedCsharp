namespace DP.API.ADP
{
    public interface IImageProcess
    {


        void ProcessImage(IFormFile file, string watermark);
    }
}
