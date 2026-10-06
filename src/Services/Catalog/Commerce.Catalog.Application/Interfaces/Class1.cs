using Commerce.Catalog.Domain;
using Commerce.Catalog.Domain.Entities;
namespace Commerce.Catalog.Application.Interfaces;

public interface IProductService
{
    Product CreateProduct(string Name, string Sku, decimal Price);

    Product? GetProductById(Guid Id);
    IEnumerable<Product> GetAllProducts();

    void UpdatePrice(Guid id, decimal  price);

    void DeactivateProduct(Guid id);
}
