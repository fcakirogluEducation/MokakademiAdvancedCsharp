namespace DP.API.DDP
{
    public class ProductLoggingDecorator(IProductService productService, ILogger<ProductLoggingDecorator> logger) : ProductServiceBaseDecorator(productService)
    {
        public override Task DeleteProductAsync(int id)
        {
            logger.LogError("Logging DeleteProductAsync");
            return base.DeleteProductAsync(id);
        }

        public override Task UpdateProductAsync(ProductDto productDto)
        {

            logger.LogError("Logging UpdateProductAsync");
            return base.UpdateProductAsync(productDto);
        }

        public override Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {

            logger.LogError("Logging GetAllProductsAsync");
            return base.GetAllProductsAsync();
        }
    }
}
