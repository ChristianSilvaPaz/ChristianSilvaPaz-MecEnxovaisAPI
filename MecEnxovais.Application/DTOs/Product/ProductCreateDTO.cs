using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MecEnxovais.Application.DTOs.Product;
public class ProductCreateDTO
{
    [DisplayName("Nome")]
    [Required(ErrorMessage = "Nome é obrigatório")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Nome precisa ter entre 3 e 50 caracteres")]
    public string Name { get; set; }

    [DisplayName("Preço")]
    [DataType(DataType.Currency)]
    [DisplayFormat(DataFormatString = "{0:C2}")]
    public decimal Price { get; set; }

    [DisplayName("Quantidade")]
    [Required(ErrorMessage = "Quantidade é obrigatório")]
    [Range(1, 100, ErrorMessage = "Quantidade deve ser maior que 0")]
    public int Amount { get; set; }

    [DisplayName("ID da Categoria")]
    [Required(ErrorMessage = "Informe o ID da categoria")]
    public Guid CategoryId { get; set; }
}
