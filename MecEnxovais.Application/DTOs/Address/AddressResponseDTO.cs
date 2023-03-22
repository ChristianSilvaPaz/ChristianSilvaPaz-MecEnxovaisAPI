namespace MecEnxovais.Application.DTOs.Address;
public class AddressResponseDTO
{
    public Guid Id { get; set; }
    public string? PublicPlace { get; set; }
    public string? Neighborhood { get; set; }
    public string? City { get; set; }
    public string? ZipCode { get; set; }
    public string? PointReference { get; set; }
    public DateTime DateRegistration { get; set; }
    public DateTime DateUpdate { get; set; }
    public Guid ClientId { get; set; }
}
