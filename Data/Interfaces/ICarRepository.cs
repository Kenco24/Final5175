using Final5175.Data.Entities;

namespace Final5175.Data.Interfaces
{
    public interface ICarRepository
    {
  
            Task<List<Car>> GetAllCarAsync();
            Task<Car> GetCarByIdAsync(int id);
            Task<Car> AddCarAsync(Car car);
            Task<Car> UpdateCarAsync(Car car);
            Task DeleteCarAsync(int id);
        
    }
}
