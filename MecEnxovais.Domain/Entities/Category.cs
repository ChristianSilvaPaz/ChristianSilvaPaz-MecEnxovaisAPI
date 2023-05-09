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

    public void Update(Category category, string name)
    {
        category.DateUpdate = DateTime.Now;
        Name = name;
    }
}
