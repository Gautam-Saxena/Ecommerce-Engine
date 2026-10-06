namespace Commerce.Catalog.Application.Services;

using Commerce.Catalog.Application.Interfaces;
using Commerce.Catalog.Domain.Entities;

public class ProductService: IProductService
{
    private readonly List<Product> _products = new();

    public Product CreateProduct(string Name,string Sku, decimal Price) {
        var newProduct = new Product(Name, Price, Sku);

        _products.Add(newProduct);
        return newProduct;
    }
    public IEnumerable<Product> GetAllProducts()
    {
        return _products;
    }

    public Product? GetProductById(Guid id)
    {
        return _products.FirstOrDefault(x => x.Id == id);
    }

    public void UpdatePrice(Guid id, decimal Price) {
        var prod = GetProductById(id);
        if(prod is null)
        {
            throw new KeyNotFoundException();
        }
        prod.UpdatePrice(Price);
    }

    public void DeactivateProduct(Guid id)
    {
        var prod = GetProductById(id);
        if (prod is null)
        {
            throw new KeyNotFoundException();
        }

        prod.DeActivate();
    }
}
