using MecEnxovais.Domain.Enums;

namespace MecEnxovais.Domain.Entities;

public sealed class FinancialMovement : Entity
{
    public Guid MovementInstalmentId { get; set; }
    public MovementInstalment MovementInstalment { get; set; }

    public Guid UserId { get; set; }
    public User User { get; set; }

    public PaymentType PaymentType { get; private set; }
    public FinancialType FinancialType { get; private set; }

    public DateTime PaymentDate { get; private set; }
    public Decimal AmountPaid { get; private set; }
    public string? Observation { get; private set; }
}
