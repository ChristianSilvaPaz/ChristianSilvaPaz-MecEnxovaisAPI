using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MecEnxovais.Application.DTOs.Category;
public class CategoryCreateDTO
{
    [DisplayName("Nome")]
    [Required(ErrorMessage = "Nome é obrigatório")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Nome deve ter entre 3 e 50 caracteres")]
    public string Name { get; set; }
}
