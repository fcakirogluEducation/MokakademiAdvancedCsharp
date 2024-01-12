using DP.API.ADP;
using DP.API.DDP;
using Microsoft.Extensions.Caching.Memory;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMemoryCache();

builder.Services.AddScoped<IProductService>(sp =>
{


    IHttpContextAccessor httpContextAccessor = sp.GetRequiredService<IHttpContextAccessor>();

    ProductService productService = new ProductService();

    if (httpContextAccessor.HttpContext!.Request.Query["type"] == "1")
    {
        ILogger<ProductLoggingDecorator> logger = sp.GetRequiredService<ILogger<ProductLoggingDecorator>>();
        ProductLoggingDecorator loggingDecorator = new ProductLoggingDecorator(productService, logger);
        return loggingDecorator;
        ;
        //logging
    }
    else if (httpContextAccessor.HttpContext!.Request.Query["type"] == "2")
    {


        IMemoryCache memoryCache = sp.GetRequiredService<IMemoryCache>();
        ProductServiceCacheDecorator cacheDecorator = new ProductServiceCacheDecorator(productService, memoryCache);
        return cacheDecorator;
        //caching
    }
    else
    {
        IMemoryCache memoryCache = sp.GetRequiredService<IMemoryCache>();
        ProductServiceCacheDecorator cacheDecorator = new ProductServiceCacheDecorator(productService, memoryCache);
        ILogger<ProductLoggingDecorator> logger = sp.GetRequiredService<ILogger<ProductLoggingDecorator>>();
        ProductLoggingDecorator loggingDecorator = new ProductLoggingDecorator(cacheDecorator, logger);
        return loggingDecorator;
    }





});













builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<AdvancedImageProcess>();
builder.Services.AddScoped<IImageProcess>(sp =>
{

    IImageProcess process;

    IHttpContextAccessor httpContextAccessor = sp.GetRequiredService<IHttpContextAccessor>();


    if (httpContextAccessor.HttpContext!.Request.Query["type"] == "1")
    {
        process = new ImageProcess(sp.GetRequiredService<ILogger<ImageProcess>>());
    }
    else
    {
        process = new ImageAdvancedProcessAdapter(sp.GetRequiredService<AdvancedImageProcess>());
    }

    return process;

});










WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthorization();

app.MapControllers();

app.Run();
