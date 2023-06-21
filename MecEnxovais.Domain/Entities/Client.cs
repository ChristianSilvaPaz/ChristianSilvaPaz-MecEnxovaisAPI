namespace MecEnxovais.Domain.Entities;
public sealed class Client : Entity
{
    public string? Name { get; private set; }
    public string? PhoneNumber1 { get; private set; }
    public string? PhoneNumber2 { get; private set; }
    public string? Cpf { get; private set; }
    public string? BirthDate { get; private set; }
    public string? MaritalStatus { get; private set; }
    public string? Sex { get; private set; }
    public string? Rg { get; private set; }
    public string? DispatchingAgency { get; private set; }

    public string? ReferenceName1 { get; private set; }
    public string? ReferenceName2 { get; private set; }
    public string? ReferenceName3 { get; private set; }

    public string? ReferencePhone1 { get; private set; }
    public string? ReferencePhone2 { get; private set; }
    public string? ReferencePhone3 { get; private set; }

    public Address? Address { get; set; }

    public Client(string name, string phoneNumber1, string phoneNumber2, string cpf, string? birthDate,
        string maritalStatus, string sex, string rg, string dispatchingAgency, string referenceName1,
        string referenceName2, string referenceName3, string referencePhone1, string referencePhone2,
        string referencePhone3)
    {
        Id = Guid.NewGuid();
        Name = name;
        PhoneNumber1 = phoneNumber1;
        PhoneNumber2 = phoneNumber2;
        Cpf = cpf;
        BirthDate = birthDate;
        MaritalStatus = maritalStatus;
        Sex = sex;
        Rg = rg;
        DispatchingAgency = dispatchingAgency;

        ReferenceName1 = referenceName1;
        ReferenceName2 = referenceName2;
        ReferenceName3 = referenceName3;

        ReferencePhone1 = referencePhone1;
        ReferencePhone2 = referencePhone2;
        ReferencePhone3 = referencePhone3;
    }

    public void Update(string? name, string? phoneNumber1, string? phoneNumber2, string? cpf, string? birthDate,
        string? maritalStatus, string? sex, string? rg, string? dispatchingAgency, string? referenceName1,
        string? referenceName2, string? referenceName3, string? referencePhone1, string? referencePhone2,
        string? referencePhone3)
    {
        Name = name;
        PhoneNumber1 = phoneNumber1;
        PhoneNumber2 = phoneNumber2;
        Cpf = cpf;
        BirthDate = birthDate;
        MaritalStatus = maritalStatus;
        Sex = sex;
        Rg = rg;
        DispatchingAgency = dispatchingAgency;

        ReferenceName1 = referenceName1;
        ReferenceName2 = referenceName2;
        ReferenceName3 = referenceName3;

        ReferencePhone1 = referencePhone1;
        ReferencePhone2 = referencePhone2;
        ReferencePhone3 = referencePhone3;
        DateUpdate = DateTime.Now;
    }
}
