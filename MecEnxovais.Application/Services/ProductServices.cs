using AutoMapper;
using MecEnxovais.Application.DTOs.Product;
using MecEnxovais.Application.Interfaces;
using MecEnxovais.Application.Result;
using MecEnxovais.Domain.Entities;
using MecEnxovais.Domain.Interfaces;

namespace MecEnxovais.Application.Services;
public class ProductServices : IProductServices
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public ProductServices(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ProductResponseDTO>> GetAsync()
    {
        var productsEntity = await _productRepository.GetAsync();
        return _mapper.Map<IEnumerable<ProductResponseDTO>>(productsEntity);
    }

    public async Task<ProductResponseDTO> GetByIdAsync(Guid id)
    {
        var productEntity = await _productRepository.GetByIdAsync(id);
        return _mapper.Map<ProductResponseDTO>(productEntity);
    }

    public async Task<ProductResponseDTO> CreateAsync(ProductCreateDTO product)
    {
        var productEntity = new Product(product.Name, product.Price, product.Amount, product.Image, product.CategoryId);

        await _productRepository.CreateAsync(productEntity);
        return _mapper.Map<ProductResponseDTO>(productEntity);
    }

    public async Task<ServicesResult<ProductResponseDTO>> UpdateAsync(Guid id, ProductUpdateDTO product)
    {
        var result = new ServicesResult<ProductResponseDTO>();
        var productEntity = await _productRepository.GetByIdAsync(id);

        if (productEntity is null)
        {
            result.AddErrors("Produto", "Produto não encontrado");
            return result;
        }

        productEntity.Update(product.Name, product.Price, product.Amount, product.Image, product.CategoryId);

        return result.WithData(_mapper.Map<ProductResponseDTO>(productEntity));
    }

    public async Task<ServicesResult<ProductResponseDTO>> DeleteAsync(Guid id)
    {
        var result = new ServicesResult<ProductResponseDTO>();
        var productEntity = await _productRepository.GetByIdAsync(id);

        if (productEntity is null)
        {
            result.AddErrors("Produto", "Produto não encontrado");
            return result;
        }

        return result.WithData(_mapper.Map<ProductResponseDTO>(productEntity));
    }
}
