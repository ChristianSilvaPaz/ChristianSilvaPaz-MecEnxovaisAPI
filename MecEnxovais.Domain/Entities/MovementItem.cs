namespace MecEnxovais.Domain.Entities;

public sealed class MovementItem : Entity
{
    public Guid ProductId { get; set; }
    public Product? Product { get; set; }

    public Guid StockMovementId { get; set; }
    public StockMovement? StockMovement { get; set; }

    public int Amount { get; private set; }
    public int StockBalance { get; private set; }
    public decimal UnitaryValue { get; private set; }
    public decimal TotalValue { get; private set; }
    public decimal Discount { get; private set; }
    public decimal Addition { get; private set; }

    //public MovementItem(Product product, Guid stockMovimentId, int amount, decimal unitaryValue, decimal discount,
    //    decimal addition)
    //{
    //    Id = Guid.NewGuid();
    //    ProductId = product.Id;
    //    StockMovementId = stockMovimentId;
    //    Amount = amount;
    //    StockBalance = product.Amount;
    //    UnitaryValue = unitaryValue;
    //    TotalValue = unitaryValue * amount;
    //    Discount = discount;
    //    Addition = addition;
    //}
}
