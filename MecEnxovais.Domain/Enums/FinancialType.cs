using System.ComponentModel;

namespace MecEnxovais.Domain.Enums;

public enum FinancialType
{
    [Description("Conta a Receber")]
    Receber,
    [Description("Conta a Pagar")]
    Pagar,
}
