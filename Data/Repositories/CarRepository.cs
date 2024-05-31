using Final5175.Data.Entities;
using Final5175.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Final5175.Data.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly FinalContext _context;
        public CarRepository(FinalContext context)
        {
            _context = context;
        }

        public async Task<Car> AddCarAsync(Car car)
        {
            _context.Cars.Add(car);
            await _context.SaveChangesAsync();
            return car;

        }


        public async Task DeleteCarAsync(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            if (car != null)
            {
                _context.Cars.Remove(car);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Car>> GetAllCarAsync()
        {
            return await _context.Cars.ToListAsync();
        }

        public async Task<List<Car>> GetAllCarsAsync()
        {
            return await _context.Cars.ToListAsync();
        }

        public async Task<Car> GetCarByIdAsync(int id)
        {
            return await _context.Cars.FindAsync(id);
        }



        public async Task<Car> UpdateCarAsync(Car car)
        {
            _context.Entry(car).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return car;
        }

    }


}

