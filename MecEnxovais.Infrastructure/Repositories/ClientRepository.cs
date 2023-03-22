using MecEnxovais.Domain.Entities;
using MecEnxovais.Domain.Interfaces;
using MecEnxovais.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace MecEnxovais.Infrastructure.Repositories;
public class ClientRepository : IClientRepository
{
    private readonly ApplicationDbContext _context;

    public ClientRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Client>> GetAsync()
    {
        return await _context.Clients.ToListAsync();
    }

    public async Task<Client> GetByIdAsync(Guid id)
    {
        return await _context.Clients.FindAsync(id);
    }

    public async Task<Client> CreateAsync(Client client)
    {
        _context.Clients.Add(client);
        await _context.SaveChangesAsync();
        return client;
    }

    public async Task<Client> UpdateAsync(Client client)
    {
        _context.Clients.Update(client);
        await _context.SaveChangesAsync();
        return client;
    }

    public async Task DeleteAsync(Client client)
    {
        _context.Clients.Remove(client);
        await _context.SaveChangesAsync();
    }
}
