using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MecEnxovais.Application.DTOs.Address;
public class AddressCreateDTO
{
    [DisplayName("Logradouro")]
    [Required(ErrorMessage = "Logradouro é obrigatório")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Logradouro precisa ter entre 3 e 100 caracteres")]
    public string? PublicPlace { get; set; }

    [DisplayName("Bairro")]
    [Required(ErrorMessage = "Bairro é obrigatório")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Bairro precisa ter entre 3 e 50 caracteres")]
    public string? Neighborhood { get; set; }

    [DisplayName("Cidade")]
    [Required(ErrorMessage = "Cidade é obrigatório")]
    [StringLength(30, MinimumLength = 3, ErrorMessage = "Cidade precisa ter entre 3 e 30 caracteres")]
    public string? City { get; set; }

    [DisplayName("CEP")]
    [Required(ErrorMessage = "CEP é obrigatório")]
    [StringLength(30, MinimumLength = 3, ErrorMessage = "CEP precisa ter entre 3 e 30 caracteres")]
    public string? ZipCode { get; set; }

    [DisplayName("Ponto de referência")]
    [Required(ErrorMessage = "Ponto de referência é obrigatório")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Ponto de referência precisa ter entre 3 e 100 caracteres")]
    public string? PointReference { get; set; }
}
