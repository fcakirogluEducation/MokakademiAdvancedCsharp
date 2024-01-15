using DP.API.Design_Patterns.STP;

namespace DP.API.Extensions
{
    public static class ProgramExt
    {

        public static void AddRepositoryStrategy(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository>(sp =>
            {

                var httpContextAccessor = sp.GetRequiredService<IHttpContextAccessor>();

                if (httpContextAccessor.HttpContext!.Request.Query["type"] == "1")
                {
                    return new ProductRepositoryWithOracle();
                }
                return new ProductRepositoryWithSqlServer();


            });
        }
    }
}
