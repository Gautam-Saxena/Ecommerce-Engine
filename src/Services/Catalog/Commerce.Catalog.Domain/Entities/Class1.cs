namespace Commerce.Catalog.Domain.Entities;

public class Product
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = "";
    public string Sku { get; private set; } = "";
    public decimal Price { get; private set; }
    public bool IsActive { get; private set; }

    private Product() { }

    public Product(string name, decimal price, string sku)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Invalid name",nameof(name));
        if (string.IsNullOrWhiteSpace(sku)) throw new ArgumentException("Invalid sku", nameof(sku));
        if (price < 0) throw new ArgumentException("Invalid price", nameof(price));
        Id = Guid.NewGuid();
        Name = name;
        Price = price;
        Sku = sku;
        IsActive = true;
    }
    public void UpdatePrice(decimal price)
    {
        if (price < 0) throw new ArgumentException("Invalid price", nameof(price));
        Price = price;
    }
    public void DeActivate()
    {
        IsActive = false;
    }
}
