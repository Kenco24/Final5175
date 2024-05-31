using Final5175.Data.Entities;

namespace Final5175.Data.Interfaces
{
    public interface IClientRepository
    {
            Task<List<Client>> GetAllClientsAsync();
            Task<Client> GetClientByIdAsync(int id);
            Task<Client> AddClientAsync(Client client);
            Task<Client> UpdateClientAsync(Client client);
            Task DeleteClientAsync(int id);
    }
}

