using AutoMapper;
using occurrensBackend.Entities.DatabaseEntities;
using occurrensBackend.Models.AboutDoctorModels;

namespace occurrensBackend.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SpecializationDto, Spetialization>();

            CreateMap<AddressDto, Address>();
        }
    }
}
