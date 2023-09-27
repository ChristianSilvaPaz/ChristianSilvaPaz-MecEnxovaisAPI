namespace MecEnxovais.Domain.Entities;

public sealed class Company : Entity
{
    public string? Name { get; private set; }
    public ICollection<User>? Users { get; private set; }

    public Company(string name) 
    {
        Id = Guid.NewGuid();
        Name = name;
    }
}
