namespace MecEnxovais.Domain.Entities;
public sealed class Address : Entity
{
    public string? PublicPlace { get; private set; }
    public string? Neighborhood { get; private set; }
    public string? City { get; private set; }
    public string? ZipCode { get; private set; }
    public string? PointReference { get; private set; }

    public Guid ClientId { get; set; }
    public Client? Client { get; set; }


    public Address(string? publicPlace, string? neighborhood, string? city, string? zipCode, string? pointReference, Guid clientId)
    {
        Id = Guid.NewGuid();
        PublicPlace = publicPlace;
        Neighborhood = neighborhood;
        City = city;
        ZipCode = zipCode;
        PointReference = pointReference;
        ClientId = clientId;
    }

    public void Update(string? publicPlace, string? neighborhood, string? city, string? zipCode, string? pointReference, Guid clientId)
    {
        PublicPlace = publicPlace;
        Neighborhood = neighborhood;
        City = city;
        ZipCode = zipCode;
        PointReference = pointReference;
        ClientId = clientId;
        DateUpdate= DateTime.Now;
        ClientId = clientId;
    }
}
