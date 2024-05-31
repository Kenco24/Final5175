using Final5175.Services.DTOs;

namespace Final5175.Services.Interfaces
{

     public interface ICarService
      {
            Task<IEnumerable<CarDTO>> GetAllCarsAsync();
            Task<CarDTO> GetCarByIdAsync(int id);
            Task<CarDTO> AddCarAsync(CarDTO carDto);
            Task<CarDTO> UpdateCarAsync(CarDTO carDto);
            Task DeleteCarAsync(int id);
       
    }
}
