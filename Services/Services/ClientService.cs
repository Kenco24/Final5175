using AutoMapper;
using Final5175.Services.Interfaces;
using Final5175.Data.Interfaces;
using Final5175.Services.DTOs;
using Final5175.Data.Entities;

namespace Final5175.Services.Services
{
    public class ClientService : IClientService
    {

        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public ClientService(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ClientDTO>> GetAllClientsAsync()
        {
            var clients = await _clientRepository.GetAllClientsAsync();
            return _mapper.Map<IEnumerable<ClientDTO>>(clients);
        }

        public async Task<ClientDTO> GetClientByIdAsync(int id)
        {
            var client = await _clientRepository.GetClientByIdAsync(id);
            return _mapper.Map<ClientDTO>(client);
        }

        public async Task<ClientDTO> AddClientAsync(ClientDTO clientDto)
        {
            var client = _mapper.Map<Client>(clientDto);
            var addedClient = await _clientRepository.AddClientAsync(client);
            return _mapper.Map<ClientDTO>(addedClient);
        }

        public async Task<ClientDTO> UpdateClientAsync(ClientDTO clientDto)
        {
            var client= _mapper.Map<Client>(clientDto);
            var updatedClient = await _clientRepository.UpdateClientAsync(client);
            return _mapper.Map<ClientDTO>(updatedClient);
        }

        public async Task DeleteClientAsync(int id)
        {
            await _clientRepository.DeleteClientAsync(id);
        }

        
    }
}
