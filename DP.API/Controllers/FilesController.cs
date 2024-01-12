using DP.API.ADP;
using Microsoft.AspNetCore.Mvc;

namespace DP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly IImageProcess _imageProcess;
        private readonly IServiceProvider _serviceProvider;

        public FilesController(IImageProcess imageProcess, IServiceProvider serviceProvider)
        {
            _imageProcess = imageProcess;
            _serviceProvider = serviceProvider;
        }

        [HttpPost]
        public IActionResult Upload(IFormFile file)
        {


            _imageProcess.ProcessImage(file, ".net core");


            return Ok();
        }
    }
}
