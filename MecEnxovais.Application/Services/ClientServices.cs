using AutoMapper;
using MecEnxovais.Application.DTOs.Client;
using MecEnxovais.Application.Interfaces;
using MecEnxovais.Application.Result;
using MecEnxovais.Domain.Entities;
using MecEnxovais.Domain.Interfaces;

namespace MecEnxovais.Application.Services;
public class ClientServices : IClientServices
{
    private readonly IClientRepository _clientRepository;
    private readonly IAddressRepository _addressRepository;
    private readonly IMapper _mapper;

    public ClientServices(IClientRepository clientRepository, IAddressRepository addressRepository, IMapper mapper)
    {
        _clientRepository = clientRepository;
        _addressRepository = addressRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ClientResponseDTO>> GetAsync()
    {
        var clientsEntity = await _clientRepository.GetAsync();
        return _mapper.Map<IEnumerable<ClientResponseDTO>>(clientsEntity);
    }

    public async Task<ClientResponseDTO> GetByIdAsync(Guid id)
    {
        var clientEntity = await _clientRepository.GetByIdAsync(id);
        clientEntity.Address = await _addressRepository.GetByIdClientAsync(id);
        return _mapper.Map<ClientResponseDTO>(clientEntity);
    }

    public async Task<ClientResponseDTO> CreateAsync(ClientCreateDTO client)
    {
        var clientEntity = new Client(client.Name, client.PhoneNumber1, client.PhoneNumber2, client.Cpf, client.BirthDate,
            client.MaritalStatus, client.Sex, client.Rg, client.DispatchingAgency, client.ReferencePhone1,
            client.ReferencePhone2, client.ReferencePhone3);

        await _clientRepository.CreateAsync(clientEntity);

        var addressEntity = new Address(client.Address.PublicPlace, client.Address.Neighborhood, client.Address.City,
            client.Address.ZipCode, client.Address.PointReference, clientEntity.Id);

        await _addressRepository.CreateAsync(addressEntity);

        clientEntity.Address = addressEntity;

        return _mapper.Map<ClientResponseDTO>(clientEntity);
    }

    public async Task<ServicesResult<ClientResponseDTO>> UpdateAsync(Guid id, ClientUpdateDTO client)
    {
        var result = new ServicesResult<ClientResponseDTO>();
        var clientEntity = await _clientRepository.GetByIdAsync(id);
        var addressEntity = await _addressRepository.GetByIdClientAsync(id);

        if (clientEntity is null)
        {
            result.AddErrors("Cliente", "Cliente não encontrado");
            return result;
        }

        clientEntity.Update(client.Name, client.PhoneNumber1, client.PhoneNumber2, client.Cpf, client.BirthDate,
            client.MaritalStatus, client.Sex, client.Rg, client.DispatchingAgency, client.ReferencePhone1,
            client.ReferencePhone2, client.ReferencePhone3);

        addressEntity.Update(client.Address.PublicPlace, client.Address.Neighborhood, client.Address.City,
            client.Address.ZipCode, client.Address.PointReference, id);

        clientEntity.Address = addressEntity;

        return result.WithData(_mapper.Map<ClientResponseDTO>(clientEntity));
    }

    public async Task<ServicesResult<ClientResponseDTO>> DeleteAsync(Guid id)
    {
        var result = new ServicesResult<ClientResponseDTO>();
        var clientEntity = await _clientRepository.GetByIdAsync(id);
        var addressEntity = await _addressRepository.GetByIdClientAsync(id);

        if (clientEntity is null)
        {
            result.AddErrors("Cliente", "Cliente não encontrado");
            return result;
        }

        await _clientRepository.DeleteAsync(clientEntity);

        clientEntity.Address = addressEntity;

        return result.WithData(_mapper.Map<ClientResponseDTO>(clientEntity));
    }
}
