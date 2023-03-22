using System.ComponentModel;

namespace MecEnxovais.Application.DTOs.Product;
public class ProductResponseDTO
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Amount { get; set; }
    public byte Image { get; set; }
    public DateTime DateRegistration { get; set; }
    public DateTime DateUpdate { get; set; }

    public Guid CategoryId { get; set; }
}