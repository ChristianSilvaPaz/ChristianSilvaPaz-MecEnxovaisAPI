using MecEnxovais.Application.DTOs.Address;

namespace MecEnxovais.Application.DTOs.Client;
public class ClientResponseDTO
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? PhoneNumber1 { get; set; }
    public string? PhoneNumber2 { get; set; }
    public string? Cpf { get; set; }
    public string? BirthDate { get; set; }
    public string? MaritalStatus { get; set; }
    public string? Sex { get; set; }
    public string? Rg { get; set; }
    public string? DispatchingAgency { get; set; }
    public string? ReferencePhone1 { get; set; }
    public string? ReferencePhone2 { get; set; }
    public string? ReferencePhone3 { get; set; }
    public DateTime DateRegistration { get; set; }
    public DateTime DateUpdate { get; set; }

    public AddressResponseDTO? Address { get; set; }
}
