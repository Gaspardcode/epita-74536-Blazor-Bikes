using AutoMapper;
using static BlazorApp.Components.Pages.Bikes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DublinBikesMock.Models
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<BikeStation, BikeStationDto>();
        }
    }
}