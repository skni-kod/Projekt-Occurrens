using AutoMapper;
using occurrensBackend.Entities.DatabaseEntities;
using occurrensBackend.Models.AboutDoctorModels;
using occurrensBackend.Models.GetDoctorInformationsModels;

namespace occurrensBackend.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SpecializationDto, Spetialization>();

            CreateMap<AddressDto, Address>();

            CreateMap<Doctor, GetDoctorInformationsModelsDto>()
                .ForMember(r => r.Specjalization, e => e.MapFrom(t => t.spetializations.FirstOrDefault().Specjalization))
                .ForMember(a => a.Addresses, e => e.MapFrom(t => t.addresses));

            CreateMap<Address, AddressesDto>()
           .ForMember(dest => dest.Monday, opt => opt.MapFrom(src => src.is_opened.FirstOrDefault().Monday))
           .ForMember(dest => dest.Tuesday, opt => opt.MapFrom(src => src.is_opened.FirstOrDefault().Tuesday))
           .ForMember(dest => dest.Wednesday, opt => opt.MapFrom(src => src.is_opened.FirstOrDefault().Wednesday))
           .ForMember(dest => dest.Thursday, opt => opt.MapFrom(src => src.is_opened.FirstOrDefault().Thursday))
           .ForMember(dest => dest.Fridady, opt => opt.MapFrom(src => src.is_opened.FirstOrDefault().Fridady))
           .ForMember(dest => dest.Saturday, opt => opt.MapFrom(src => src.is_opened.FirstOrDefault().Saturday))
           .ForMember(dest => dest.Sunday, opt => opt.MapFrom(src => src.is_opened.FirstOrDefault().Sunday));
        }
    }
}
