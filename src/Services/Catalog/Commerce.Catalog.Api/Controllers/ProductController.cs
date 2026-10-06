namespace Commerce.Catalog.Api.Controllers;

using Commerce.Catalog.Application.Interfaces;
using Commerce.Catalog.Application.Services;
using Commerce.Catalog.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/product")]
public class ProductController: ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public IActionResult GetAllProducts()
    {
        var products = _productService.GetAllProducts();
        return Ok(products);
    }

    [HttpPost]
    public IActionResult CreateProduct(string name, decimal price, string sku)
    {
        var product = _productService.CreateProduct(name, sku, price);
        return CreatedAtAction(nameof(CreateProduct), new {id = product.Id}, product);
    }
}
