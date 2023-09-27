using MecEnxovais.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MecEnxovais.Application.DTOs.MovementInstalment;

public class MovementInstalmentCreateDTO
{
    [DisplayName("Tipo de pagamento")]
    [Required(ErrorMessage = "Tipo de pagamento é obrigatório")]
    public PaymentType PaymentType { get; private set; }

    [DisplayName("Número da parcela")]
    [Required(ErrorMessage = "Número da parcela é obrigatório")]
    public int InstallmentNumber { get; private set; }

    [DisplayName("Data de vencimento")]
    [Required(ErrorMessage = "Data de vencimento é obrigatório")]
    [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
    public DateTime DueDate { get; private set; }

    [DisplayName("Valor")]
    [DataType(DataType.Currency)]
    [DisplayFormat(DataFormatString = "{0:C2}")]
    public Decimal Value { get; private set; }
}
