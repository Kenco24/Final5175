using Microsoft.AspNetCore.Mvc;
using Final5175.Data.Repositories;
using Final5175.Data.Interfaces;
using Final5175.Services.Interfaces;
using Final5175.Services.DTOs;



namespace Final5175.Controllers
{

    
        [Route("api/[controller]")]
        [ApiController]
        public class CarController : ControllerBase
        {
        private readonly ICarService _carService;

            public CarController(ICarService carService)
            {
                _carService = carService;
            }

            [HttpGet]
            public async Task<ActionResult<IEnumerable<CarDTO>>> GetAllCars()
            {
                var cars = await _carService.GetAllCarsAsync();
                return Ok(cars);
            }

            [HttpGet("{id}")]
            public async Task<ActionResult<CarDTO>> GetCarById(int id)
            {
                var car = await _carService.GetCarByIdAsync(id);
                if (car == null)
                {
                    return NotFound();
                }
                return Ok(car);
            }

            [HttpPost]
            public async Task<ActionResult<CarDTO>> AddCar(CarDTO carDto)
            {
                var car = await _carService.AddCarAsync(carDto);
                return NoContent();
            }

            [HttpPut("{id}")]
            public async Task<IActionResult> UpdateCar(int id, CarDTO carDto)
            {
                if (id != carDto.Id)
                {
                    return BadRequest();
                }
            await _carService.UpdateCarAsync(carDto);
                return NoContent();
            }

            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteCar(int id)
            {
                var car = await _carService.GetCarByIdAsync(id);
                if (car == null)
                {
                    return NotFound();
                }
            await _carService.DeleteCarAsync(id);
                return NoContent();
            }
        }
    
}
