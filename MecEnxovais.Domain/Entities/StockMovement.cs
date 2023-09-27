using MecEnxovais.Domain.Enums;

namespace MecEnxovais.Domain.Entities;

public sealed class StockMovement : Entity
{
    public List<MovementItem> MovementsItems { get; private set; }
    public List<MovementInstalment> MovementInstalments { get; private set; }

    public Guid UserId { get; set; }
    public User? User { get; set; }

    public Guid ClientId { get; set; }
    public Client? Client { get; set; }

    public MovementType MovementType { get; private set; }

    public decimal TotalValue { get; private set; }
    public decimal Discount { get; private set; }
    public decimal Addition { get; private set; }

    public StockMovement(Guid userId, Guid clientId, MovementType movementType, decimal totalValue,
        decimal discount, decimal addition)
    {
        Id = Guid.NewGuid();
        UserId = userId;
        ClientId = clientId;
        MovementType = movementType;
        Discount = discount;
        Addition = addition;
        TotalValue = totalValue;
    }
}
