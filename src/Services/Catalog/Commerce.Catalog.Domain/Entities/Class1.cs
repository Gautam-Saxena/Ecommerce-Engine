namespace Commerce.Catalog.Domain.Entities;

public class Products
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = "";
    public string Sku { get; private set; } = "";
    public decimal Price { get; private set; }
    public bool IsActive { get; private set; }

    private Products() { }

    public Products(string name, decimal price, string sku)
    {
        Id = Guid.NewGuid();
        Name = name;
        Price = price;
        Sku = sku;
        IsActive = true;
    }
    public void UpdatePrice(decimal price)
    {
        Price = price;
    }
    public void DeActivate()
    {
        IsActive = false;
    }
}
