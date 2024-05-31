using AutoMapper;
using Final5175.Data.Interfaces;
using Final5175.Services.DTOs;
using Final5175.Data.Entities;
using Final5175.Services.Interfaces;

namespace Final5175.Services.Services
{
    public class CarService : ICarService
    {

        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public CarService(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CarDTO>> GetAllCarsAsync()
        {
            var cars = await _carRepository.GetAllCarAsync();
            return _mapper.Map<IEnumerable<CarDTO>>(cars);
        }

        public async Task<CarDTO> GetCarByIdAsync(int id)
        {
            var car= await _carRepository.GetCarByIdAsync(id);
            return _mapper.Map<CarDTO>(car);
        }

        public async Task<CarDTO> AddCarAsync(CarDTO carDto)
        {
            var car = _mapper.Map<Car>(carDto);
            var addedCar = await _carRepository.AddCarAsync(car);
            return _mapper.Map<CarDTO>(addedCar);
        }

        public async Task<CarDTO> UpdateCarAsync(CarDTO carDto)
        {
            var car = _mapper.Map<Car>(carDto);
            var updatedCar = await _carRepository.UpdateCarAsync(car);
            return _mapper.Map<CarDTO>(updatedCar);
        }

        public async Task DeleteCarAsync(int id)
        {
            await _carRepository.DeleteCarAsync(id);
        }
    }
}
