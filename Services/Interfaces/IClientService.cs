using Final5175.Services.DTOs;

namespace Final5175.Services.Interfaces
{
    public interface IClientService
    {
        Task<IEnumerable<ClientDTO>> GetAllClientsAsync();
        Task<ClientDTO> GetClientByIdAsync(int id);
        Task<ClientDTO> AddClientAsync(ClientDTO clientDto);
        Task<ClientDTO> UpdateClientAsync(ClientDTO clientDto);
        Task DeleteClientAsync(int id);
    }
}
