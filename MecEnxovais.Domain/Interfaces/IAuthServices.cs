namespace MecEnxovais.Domain.Interfaces;
public interface IAuthServices
{
    string ComputeSha256Hash(string password);
    string GenerateJwtToken(string email);
}
