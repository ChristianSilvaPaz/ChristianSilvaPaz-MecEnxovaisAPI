using AutoMapper;
using MecEnxovais.Application.DTOs.Address;
using MecEnxovais.Application.DTOs.Category;
using MecEnxovais.Application.DTOs.Client;
using MecEnxovais.Application.DTOs.Product;
using MecEnxovais.Application.DTOs.User;
using MecEnxovais.Domain.Entities;

namespace MecEnxovais.Application.Mappings;
public class DomainToDTOMappingProfile : Profile
{
    public DomainToDTOMappingProfile()
    {
        CreateMap<Category, CategoryResponseDTO>().ReverseMap();
        CreateMap<Product, ProductResponseDTO>().ReverseMap();
        CreateMap<User, ClientResponseDTO>().ReverseMap();
        CreateMap<Address, AddressResponseDTO>().ReverseMap();
        CreateMap<User, UserResponseDTO>().ReverseMap();
        CreateMap<Client, ClientResponseDTO>().ReverseMap();
    }
}
