using MecEnxovais.Application.DTOs.MovementInstalment;
using MecEnxovais.Application.DTOs.MovementItem;
using MecEnxovais.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MecEnxovais.Application.DTOs.StockMovement;

public class StockMovementCreateDTO
{
    [DisplayName("Items")]
    [Required(ErrorMessage = "Items é obrigatório")]
    public List<MovementItemCreateDTO> Items{ get; set; }

    [DisplayName("Parcelas")]
    [Required(ErrorMessage = "Parcelas é obrigatório")]
    public List<MovementInstalmentCreateDTO> Instalments { get; set; }

    [DisplayName("Usuário Id")]
    [Required(ErrorMessage = "Usuário Id é obrigatório")]
    public Guid UserId { get; set; }


    [DisplayName("Cliente Id")]
    [Required(ErrorMessage = "Cliente Id é obrigatório")]
    public Guid ClientId { get; set; }

    [DisplayName("Tipo do movimento")]
    [Required(ErrorMessage = "Tipo do movimento é obrigatório")]
    public MovementType MovementType { get; private set; }

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
