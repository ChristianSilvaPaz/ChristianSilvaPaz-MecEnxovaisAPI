using System.ComponentModel;

namespace MecEnxovais.Domain.Enums;

public enum PaymentType
{
    [Description("Á Vista")]
    AVista,
    [Description("Cartão de Crédito")]
    Credito,
    [Description("Cartão de Débito")]
    Debito,
    [Description("Crediário")]
    Crediario,
}
