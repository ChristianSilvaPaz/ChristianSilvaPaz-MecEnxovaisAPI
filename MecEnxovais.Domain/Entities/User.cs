namespace MecEnxovais.Domain.Entities;
public sealed class User : Entity
{
    public string? FirstName { get; private set; }
    public string? LastName { get; private set; }
    public string? FullName { get; private set; }
    public string? Email { get; private set; }
    public string? Password { get; private set; }

    public Guid? CompanyId { get; set; }
    public Company? Company { get; set; }

    public User(string? firstName, string? lastName, string? fullName, string? email, string? password, Guid? companyId)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        FullName = fullName;
        Email = email;
        Password = password;
        CompanyId = companyId;
    }
}
