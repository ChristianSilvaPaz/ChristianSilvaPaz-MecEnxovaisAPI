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
    [StringLength(10, MinimumLength = 4, ErrorMessage = "Senha precisa ter entre 4 e 10 caracteres")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }
}
