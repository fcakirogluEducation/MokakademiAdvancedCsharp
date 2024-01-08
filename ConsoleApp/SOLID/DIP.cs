namespace ConsoleApp.SOLID;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Created { get; set; }
}

public class ProductDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Created { get; set; }
}

public class ProductRepositoryFactory

{
    public IProductRepository Create()
    {
        return new ProductRepositoryWithSqlServer();
    }

    public IProductRepository CreateOracle()
    {
        return new ProductRepositoryWithOracle();
    }
}

public interface IProductRepository

{
    List<Product> GetAll();
}

public class ProductRepositoryWithOracle : IProductRepository
{
    public List<Product> GetAll()
    {
        return new List<Product>
        {
            new() { Id = 1, Name = "Kalem 1 Oracle", Created = DateTime.Now },
            new() { Id = 2, Name = "Kalem 2 Oracle", Created = DateTime.Now }
        };
    }
}

public class ProductRepositoryWithSqlServer : IProductRepository
{
    public List<Product> GetAll()
    {
        return new List<Product>
        {
            new() { Id = 1, Name = "Kalem 1", Created = DateTime.Now },
            new() { Id = 2, Name = "Kalem 2", Created = DateTime.Now }
        };
    }
}

public class ProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }


    public List<ProductDto> GetAll()
    {
        return _productRepository.GetAll().Select(x => new ProductDto
        {
            Id = x.Id,
            Name = x.Name,
            Created = x.Created.ToShortDateString()
        }).ToList();
    }
}