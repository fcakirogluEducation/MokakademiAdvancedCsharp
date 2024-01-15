namespace DP.API.DDP
{
    public class ProductServiceBaseDecorator(IProductService productService) : IProductService
    {
        public virtual async Task<ProductDto> CreateProductAsync(ProductDto productDto)
        {
            return await productService.CreateProductAsync(productDto);
        }

        public virtual async Task DeleteProductAsync(int id)
        {
            await productService.DeleteProductAsync(id);
        }

        public virtual Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            return productService.GetAllProductsAsync();
        }

        public virtual Task<ProductDto> GetProductByIdAsync(int id)
        {
            return productService.GetProductByIdAsync(id);
        }

        public virtual async Task UpdateProductAsync(ProductDto productDto)
        {
            await productService.UpdateProductAsync(productDto);
        }
    }

}
