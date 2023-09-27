using MecEnxovais.Domain.Entities;
using MecEnxovais.Domain.Interfaces;
using MecEnxovais.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace MecEnxovais.Infrastructure.Repositories;

public class AddressRepository : IAddressRepository
{
    private readonly ApplicationDbContext _context;

    public AddressRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Address>> GetAsync()
    {
        return await _context.Addresses.ToListAsync();
    }

    public async Task<Address> GetByIdClientAsync(Guid id)
    {
        return await _context.Addresses.FirstOrDefaultAsync(a => a.ClientId == id);
    }

    public async Task<Address> CreateAsync(Address address)
    {
        _context.Addresses.Add(address);
        await _context.SaveChangesAsync();
        return address;
    }

    public async Task<Address> UpdateAsync(Address address)
    {
        _context.Addresses.Update(address);
        await _context.SaveChangesAsync();
        return address;
    }

    public async Task DeleteAsync(Address address)
    {
        _context.Addresses.Remove(address);
        await _context.SaveChangesAsync();
    }
}
