using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MecEnxovais.Application.DTOs.Login;
public class LoginCreateDTO
{
    [DisplayName("Email")]
    [Required(ErrorMessage = "Email é obrigatório")]
    [EmailAddress(ErrorMessage = "Email inválido")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Senha é obrigatório")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }
}
