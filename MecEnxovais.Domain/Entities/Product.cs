namespace MecEnxovais.Domain.Entities;

public sealed class Product : Entity
{
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public int Amount { get; private set; }

    public Guid CategoryId { get; set; }
    public Category Category { get; set; }

    public Product(string name, decimal price, int amount, Guid categoryId)
    {
        Id = Guid.NewGuid();
        Name = name;
        Price = price;
        Amount = amount;
        CategoryId = categoryId;
    }

    public void Update(Product product, string name, decimal price, int amount, Guid categoryId)
    {
        product.DateUpdate = DateTime.Now;
        product.Name = name;
        product.Price = price;
        product.Amount = amount;
        product.CategoryId = categoryId;
    }
}
