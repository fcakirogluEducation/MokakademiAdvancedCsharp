namespace DP.API.DDP;

//create product crud methods
public interface IProductService
{
    Task<ProductDto> CreateProductAsync(ProductDto productDto);
    Task DeleteProductAsync(int id);
    Task<IEnumerable<ProductDto>> GetAllProductsAsync();
    Task<ProductDto> GetProductByIdAsync(int id);
    Task UpdateProductAsync(ProductDto productDto);
}

public class ProductService : IProductService
{
    public async Task<ProductDto> CreateProductAsync(ProductDto productDto)
    {

        return productDto;
    }

    public async Task DeleteProductAsync(int id)
    {
        Console.WriteLine("DeleteProductAsync çalıştı");

    }

    public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
    {
        Console.WriteLine("GetAllProductsAsync çalıştı");
        return new List<ProductDto>() { new() { Id = 1, Name = "kalem 1" } };
    }

    public async Task<ProductDto> GetProductByIdAsync(int id)
    {

        Console.WriteLine("GetProductByIdAsync çalıştı");
        return new() { Id = 1, Name = "kalem 1" };
    }

    public async Task UpdateProductAsync(ProductDto productDto)
    {
        Console.WriteLine("UpdateProductAsync çalıştı");
    }
}