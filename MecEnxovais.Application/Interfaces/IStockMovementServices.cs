using MecEnxovais.Application.DTOs.StockMovement;
using MecEnxovais.Application.Result;

namespace MecEnxovais.Application.Interfaces;

public interface IStockMovementServices
{
    Task<ServicesResult<StockMovementCreateDTO>> CreateAsync(StockMovementCreateDTO stockMovement);
}
