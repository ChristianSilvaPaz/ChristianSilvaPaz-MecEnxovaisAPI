using MecEnxovais.Application.DTOs.Product;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MecEnxovais.Application.DTOs.MovementItem;

public class MovementItemCreateDTO
{
    [DisplayName("Produto Id")]
    [Required(ErrorMessage = "Produto Id é obrigatório")]
    public Guid ProductId { get; set; }

    [DisplayName("Quantidade")]
    [Required(ErrorMessage = "Quantidade é obrigatório")]
    [Range(1, 100, ErrorMessage = "Quantidade deve ser maior que 0")]
    public int Amount { get; set; }

    [DisplayName("Quantidade em estoque")]
    [Required(ErrorMessage = "Quantidade em estoque é obrigatório")]
    [Range(1, 100, ErrorMessage = "Quantidade em estoque deve ser maior que 0")]
    public int StockBalance { get; set; }

    [DisplayName("Valor unitário")]
    [DataType(DataType.Currency)]
    [DisplayFormat(DataFormatString = "{0:C2}")]
    public decimal UnitaryValue { get; set; }

    [DisplayName("Valor total")]
    [DataType(DataType.Currency)]
    [DisplayFormat(DataFormatString = "{0:C2}")]
    public decimal TotalValue { get; set; }

    [DisplayName("Desconto")]
    [DataType(DataType.Currency)]
    [DisplayFormat(DataFormatString = "{0:C2}")]
    public decimal Discount { get; set; }

    [DisplayName("Acréscimo")]
    [DataType(DataType.Currency)]
    [DisplayFormat(DataFormatString = "{0:C2}")]
    public decimal Addition { get; set; }
}
