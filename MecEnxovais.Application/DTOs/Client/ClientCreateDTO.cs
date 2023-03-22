using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using MecEnxovais.Application.Validations;
using MecEnxovais.Application.DTOs.Address;

namespace MecEnxovais.Application.DTOs.Client;
public class ClientCreateDTO
{
    [DisplayName("Nome")]
    [Required(ErrorMessage = "Nome é obrigatório")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Nome precisa ter entre 3 e 50 caracteres")]
    public string? Name { get; set; }

    [DisplayName("Número de telefone 1")]
    [Required(ErrorMessage = "Número de telefone 1 é obrigatório")]
    [StringLength(20, MinimumLength = 9, ErrorMessage = "Número de telefone 1 precisa ter entre 9 e 20 caracteres")]
    public string? PhoneNumber1 { get; set; }

    [DisplayName("Número de telefone 2")]
    [StringLength(20, MinimumLength = 9, ErrorMessage = "Número de telefone 2 precisa ter entre 9 e 20 caracteres")]
    public string? PhoneNumber2 { get; set; }

    [DisplayName("CPF")]
    [Required(ErrorMessage = "Cpf é obrigatório")]
    [CpfValidation(ErrorMessage = "Cpf inválido")]
    public string? Cpf { get; set; }

    [DisplayName("Data de Nascimento")]
    [Required(ErrorMessage = "Data de nascimento é obrigatório")]
    [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
    public DateTime? BirthDate { get; set; }

    [Required(ErrorMessage = "Estado civil é obrigatório")]
    [DisplayName("Estado Civil")]
    public string? MaritalStatus { get; set; }

    [Required(ErrorMessage = "Sexo é obrigatório")]
    [DisplayName("Sexo")]
    public string? Sex { get; set; }

    [Required(ErrorMessage = "Rg é obrigatório")]
    [DisplayName("RG")]
    public string? Rg { get;set; }

    [Required(ErrorMessage = "Orgão expedidor do Rg é obrigatório")]
    [DisplayName("Orgão Expedidor")]
    public string? DispatchingAgency { get; set; }

    [DisplayName("Número de telefone de referência 1")]
    [Required(ErrorMessage = "Número de telefone de referência 1 é obrigatório")]
    [StringLength(20, MinimumLength = 9, ErrorMessage = "Número de telefone de referência 1 precisa ter entre 8 e 20 caracteres")]
    public string? ReferencePhone1 { get; set; }

    [DisplayName("Número de telefone de referência 2")]
    [Required(ErrorMessage = "Número de telefone de referência 2 é obrigatório")]
    [StringLength(20, MinimumLength = 9, ErrorMessage = "Número de telefone de referência 2 precisa ter entre 8 e 20 caracteres")]
    public string? ReferencePhone2 { get; set; }

    [DisplayName("Número de telefone de referência 3")]
    [StringLength(20, MinimumLength = 9, ErrorMessage = "Número de telefone de referência 3 precisa ter entre 8 e 20 caracteres")]
    public string? ReferencePhone3 { get; set; }

    [DisplayName("Endereço")]
    [Required(ErrorMessage = "Endereço é obrigatório")]
    public AddressCreateDTO? Address { get; set; }
}
