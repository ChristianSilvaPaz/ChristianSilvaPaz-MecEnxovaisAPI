using MecEnxovais.Domain.Entities;
using MecEnxovais.Domain.Interfaces;
using MecEnxovais.Infrastructure.Context;

namespace MecEnxovais.Infrastructure.Repositories;

public class StockMovementRepository : IStockMovementRepository
{
    private readonly ApplicationDbContext _context;

    public StockMovementRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<StockMovement> CreateAsync(StockMovement stockMovement)
    {
        _context.StockMovements.Add(stockMovement);
        await _context.SaveChangesAsync();
        return stockMovement;
    }
}
