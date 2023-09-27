using MecEnxovais.Domain.Entities;

namespace MecEnxovais.Domain.Interfaces;

public interface IStockMovementRepository
{
    Task<StockMovement> CreateAsync(StockMovement stockMovement);
}
