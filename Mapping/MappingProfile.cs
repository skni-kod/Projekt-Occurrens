using AutoMapper;
using occurrensBackend.Entities.DatabaseEntities;
using occurrensBackend.Models.AboutDoctorModels;
using occurrensBackend.Models.AboutDoctorModels.GetSelfInformationsDtos;
using occurrensBackend.Models.GetDoctorInformationsModels;

namespace occurrensBackend.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SpecializationDto, Spetialization>();

            CreateMap<AddressDto, Address>();

            CreateMap<Is_openedDto, Is_opened>();

            CreateMap<Doctor, GetDoctorInformationsModelsDto>()
                .ForMember(r => r.Specjalization, e => e.MapFrom(t => t.spetializations.FirstOrDefault().Specjalization))
                .ForMember(a => a.Addresses, e => e.MapFrom(t => t.addresses))
                .ForMember(a => a.Name, e => e.MapFrom(t => t.Name))
                .ForMember(a => a.Second_name, e => e.MapFrom(t => t.Secont_name))
                .ForMember(a => a.Last_name, e => e.MapFrom(t => t.Last_name))
                .ForMember(a => a.Telephon_number, e => e.MapFrom(t => t.Telephon_number))
                .ReverseMap();

            CreateMap<Address, AddressesDto>()
                .ForMember(dest => dest.Monday, opt => opt.MapFrom(src => src.is_opened.FirstOrDefault().Monday))
                .ForMember(dest => dest.Tuesday, opt => opt.MapFrom(src => src.is_opened.FirstOrDefault().Tuesday))
                .ForMember(dest => dest.Wednesday, opt => opt.MapFrom(src => src.is_opened.FirstOrDefault().Wednesday))
                .ForMember(dest => dest.Thursday, opt => opt.MapFrom(src => src.is_opened.FirstOrDefault().Thursday))
                .ForMember(dest => dest.Fridady, opt => opt.MapFrom(src => src.is_opened.FirstOrDefault().Fridady))
                .ForMember(dest => dest.Saturday, opt => opt.MapFrom(src => src.is_opened.FirstOrDefault().Saturday))
                .ForMember(dest => dest.Sunday, opt => opt.MapFrom(src => src.is_opened.FirstOrDefault().Sunday))
                .ForMember(a => a.Town, b => b.MapFrom(c => c.Town))
                .ForMember(a => a.Street, b => b.MapFrom(c => c.Street))
                .ForMember(a => a.Building_number, b => b.MapFrom(c => c.Building_number))
                .ForMember(a => a.Apartament_number, b => b.MapFrom(c => c.Apartament_number))
                .ForMember(a => a.Postal_code, b => b.MapFrom(c => c.Postal_code))
                .ForMember(a => a.City, b => b.MapFrom(b => b.City));

            CreateMap<Doctor, BasicInformationsDto>()
                .ForMember(x => x.Specjalization, e => e.MapFrom(e => e.spetializations.FirstOrDefault() != null ? e.spetializations.FirstOrDefault().Specjalization : "Brak specjalizacji"))
                .ForMember(x => x.AddressInformationDto, e => e.MapFrom(e => e.addresses));

            CreateMap<Address, AddressInformationDto>()
                .ForMember(dest => dest.Monday, opt => opt.MapFrom(src => src.is_opened.FirstOrDefault().Monday))
                .ForMember(dest => dest.Tuesday, opt => opt.MapFrom(src => src.is_opened.FirstOrDefault().Tuesday))
                .ForMember(dest => dest.Wednesday, opt => opt.MapFrom(src => src.is_opened.FirstOrDefault().Wednesday))
                .ForMember(dest => dest.Thursday, opt => opt.MapFrom(src => src.is_opened.FirstOrDefault().Thursday))
                .ForMember(dest => dest.Fridady, opt => opt.MapFrom(src => src.is_opened.FirstOrDefault().Fridady))
                .ForMember(dest => dest.Saturday, opt => opt.MapFrom(src => src.is_opened.FirstOrDefault().Saturday))
                .ForMember(dest => dest.Sunday, opt => opt.MapFrom(src => src.is_opened.FirstOrDefault().Sunday))
                .ForMember(a => a.Town, b => b.MapFrom(c => c.Town))
                .ForMember(a => a.Street, b => b.MapFrom(c => c.Street))
                .ForMember(a => a.Building_number, b => b.MapFrom(c => c.Building_number))
                .ForMember(a => a.Apartament_number, b => b.MapFrom(c => c.Apartament_number))
                .ForMember(a => a.Postal_code, b => b.MapFrom(c => c.Postal_code))
                .ForMember(a => a.City, b => b.MapFrom(b => b.City));
        }
    }
}
