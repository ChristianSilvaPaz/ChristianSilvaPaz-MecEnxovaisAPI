using System.Collections.ObjectModel;

namespace MecEnxovais.Domain.Entities;
public sealed class Category : Entity
{
    public string Name { get; private set; }
    public ICollection<Product> Products { get; private set; }

    public Category(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
        Products = new Collection<Product>();
    }

    public void Update(string name)
    {
        DateUpdate = DateTime.Now;
        Name = name;
    }
}
