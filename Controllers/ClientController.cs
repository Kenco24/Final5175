using Microsoft.AspNetCore.Mvc;
using Final5175.Data.Repositories;
using Final5175.Data.Interfaces;
using Final5175.Services.Interfaces;
using Final5175.Services.DTOs;



namespace Final5175.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientDTO>>> GetAllClients()
        {
            var clients = await _clientService.GetAllClientsAsync();
            return Ok(clients);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CarDTO>> GetClientById(int id)
        {
            var client = await _clientService.GetClientByIdAsync(id);
            if (client == null)
            {
                return NotFound();
            }
            return Ok(client);
        }

        [HttpPost]
        public async Task<ActionResult<ClientDTO>> AddClient(ClientDTO clientDto)
        {
            var car = await _clientService.AddClientAsync(clientDto);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateClient(int id, ClientDTO clientDto)
        {
            if (id != clientDto.Id)
            {
                return BadRequest();
            }
            await _clientService.UpdateClientAsync(clientDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClients(int id)
        {
            var client = await _clientService.GetClientByIdAsync(id);
            if (client == null)
            {
                return NotFound();
            }
            await _clientService.DeleteClientAsync(id);
            return NoContent();
        }
    }

}
