using MecEnxovais.Domain.Enums;

namespace MecEnxovais.Domain.Entities;

public sealed class MovementInstalment : Entity
{
    public Guid StockMovementId { get; set; }
    public StockMovement StockMovement { get; set; }

    public PaymentType PaymentType { get; private set; }

    public int InstallmentNumber { get; private set; }
    public InstalmentStatus Status { get; private set; }
    public DateTime DueDate { get; private set; }
    public Decimal Value { get; private set; }
}

