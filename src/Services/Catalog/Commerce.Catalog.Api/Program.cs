using Commerce.Catalog.Application.Interfaces;
using Commerce.Catalog.Application.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

app.MapControllers();



app.Run();
