namespace MecEnxovais.Application.DTOs.User;
public class UserResponseDTO
{
    public string? FirstName { get; private set; }
    public string? LastName { get; private set; }
    public string? FullName { get; private set; }
    public string? Email { get; private set; }
    public string? Password { get; private set; }

    public Guid? CompanyId { get; set; }
}
