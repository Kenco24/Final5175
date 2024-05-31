using AutoMapper;
using Final5175.Data.Entities;
using Final5175.Services.DTOs;

namespace trialexamtest.Services.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Client, ClientDTO>().ReverseMap();
            CreateMap<Car, CarDTO>().ReverseMap();
        }
    }
}