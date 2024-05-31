using Final5175.Data.Entities;
using Final5175.Data.Interfaces;
using Final5175.Data;
using Microsoft.EntityFrameworkCore;

namespace Final5175.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly FinalContext _context;
        public ClientRepository(FinalContext context) 
        {
            _context = context;
        }

        public async Task<Client> AddClientAsync(Client client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
            return client;

        }

        public async Task DeleteClientAsync(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Client>> GetAllClientsAsync()
        {
            return await _context.Clients.ToListAsync();
        }

        public async Task<Client> GetClientByIdAsync(int id)
        {
            return await _context.Clients.FindAsync(id);
        }

   

        public async Task<Client> UpdateClientAsync(Client client)
        {
               _context.Entry(client).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return client;
        }

       
    }
}
