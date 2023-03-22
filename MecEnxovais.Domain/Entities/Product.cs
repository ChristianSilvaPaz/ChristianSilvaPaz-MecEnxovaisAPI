namespace MecEnxovais.Domain.Entities;
public sealed class Product : Entity
{
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public int Amount { get; private set; }
    public byte Image { get; private set; }

    public Guid CategoryId { get; set; }
    public Category Category { get; set; }

    public Product(string name, decimal price, int amount, byte image, Guid categoryId)
    {
        Id = Guid.NewGuid();
        Name = name;
        Price = price;
        Amount = amount;
        Image = image;
        CategoryId = categoryId;
    }

    public void Update(string name, decimal price, int amount, byte image, Guid categoryId)
    {
        DateUpdate = DateTime.Now;
        Name = name;
        Price = price;
        Amount = amount;
        Image = image;
        CategoryId = categoryId;
    }
}
