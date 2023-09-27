namespace MecEnxovais.Domain.Entities;

public abstract class Entity
{
    public Guid Id { get; protected set; }
    public DateTime DateRegistration { get; protected set; } = DateTime.Now;
    public DateTime? DateUpdate { get; protected set; }
    public Boolean Deleted { get; protected set; } = false;
}
