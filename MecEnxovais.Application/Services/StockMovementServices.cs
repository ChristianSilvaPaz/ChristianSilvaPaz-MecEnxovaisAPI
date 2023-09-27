using MecEnxovais.Application.DTOs.StockMovement;
using MecEnxovais.Application.Interfaces;
using MecEnxovais.Application.Result;
using MecEnxovais.Domain.Interfaces;
using System.Runtime.InteropServices;

namespace MecEnxovais.Application.Services;

public class StockMovementServices : IStockMovementServices
{
    private readonly IStockMovementRepository _stockMovementRepository;
    private readonly IProductRepository _productRepository;

    public StockMovementServices(IStockMovementRepository stockMovementRepository, IProductRepository productRepository)
    {
        _stockMovementRepository = stockMovementRepository;
        _productRepository = productRepository;
    }

    public async Task<ServicesResult<StockMovementCreateDTO>> CreateAsync(StockMovementCreateDTO stockMovement)
    {
        var result = new ServicesResult<StockMovementCreateDTO>();

        if (stockMovement.MovementType == 0)
        {
            foreach (var item in stockMovement.Items)
            {
                var product = await _productRepository.GetByIdAsync(item.ProductId);

                if (product is null)
                {
                    result.AddErrors("Produto", "Produto não encontrado");
                    return result;
                }

                var amount = product.Amount - item.Amount;
                product.Update(product, product.Name, product.Price, amount, product.CategoryId);
                await _productRepository.UpdateAsync(product);
            }
        }

        return result;
    }
}
