using DP.API.DDP;
using Microsoft.AspNetCore.Mvc;

namespace DP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _productService.GetAllProductsAsync());
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {

            await _productService.DeleteProductAsync(id);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update()
        {

            await _productService.UpdateProductAsync(new() { Id = 1, Name = "kalem 10" });
            return Ok();
        }
    }
}
