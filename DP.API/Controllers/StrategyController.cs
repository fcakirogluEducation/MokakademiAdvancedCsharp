using DP.API.Design_Patterns.STP;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StrategyController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public StrategyController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(productRepository.GetList());
        }
    }
}
