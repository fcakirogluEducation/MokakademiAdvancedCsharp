using Microsoft.Extensions.Caching.Memory;

namespace DP.API.DDP
{
    public class ProductServiceCacheDecorator(IProductService productService, IMemoryCache memoryCache) : ProductServiceBaseDecorator(productService)
    {

        private readonly IMemoryCache _memoryCache = memoryCache;
        public override async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {

            Console.WriteLine("Cache'den geldi");
            //Aside cache design pattern;
            if (_memoryCache.TryGetValue<IEnumerable<ProductDto>>("products", out IEnumerable<ProductDto>? products))
            {

                return products;
            }

            products = await base.GetAllProductsAsync();

            _memoryCache.Set("products", products, TimeSpan.FromMinutes(1));

            return products;
        }
    }
}
