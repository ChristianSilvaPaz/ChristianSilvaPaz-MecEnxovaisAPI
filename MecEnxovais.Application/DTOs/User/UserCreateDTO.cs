using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MecEnxovais.Application.DTOs.User;
public class UserCreateDTO
{
    [DisplayName("Nome")]
    [Required(ErrorMessage = "Nome é obrigatório")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Nome precisa ter entre 3 e 50 caracteres")]
    public string? FirstName { get; set; }

    [DisplayName("Sobrenome")]
    [Required(ErrorMessage = "Sobrenome é obrigatório")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Sobrenome precisa ter entre 3 e 50 caracteres")]
    public string? LastName { get; set; }

    [DisplayName("Nome completo")]
    [Required(ErrorMessage = "Nome completo é obrigatório")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Nome completo precisa ter entre 3 e 100 caracteres")]
    public string? FullName { get; set; }

    [DisplayName("Email")]
    [Required(ErrorMessage = "Email é obrigatório")]
    [EmailAddress(ErrorMessage = "Email inválido")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Senha é obrigatório")]
    [StringLength(10, MinimumLength = 4, ErrorMessage = "Senha precisa ter entre 4 e 10 caracteres")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }

    public Guid CompanyId { get; set; }
}
