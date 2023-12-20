using AutoMapper;
using Microsoft.EntityFrameworkCore;
using occurrensBackend.Entities;
using occurrensBackend.Entities.DatabaseEntities;
using occurrensBackend.Models.GetDoctorInformationsModels;

namespace occurrensBackend.Services.ShowAllDoctorsService
{
    public class ShowAllDoctorsService : IShowAllDoctorsService
    {
        private readonly DatabaseDbContext _dbContext;
        private readonly IMapper _mapper;

        public ShowAllDoctorsService(DatabaseDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }


        public PagedResult<GetDoctorInformationsModelsDto> GetAllDoctors(DoctorQuery query)
        {
            
            var baseQuery = _dbContext
                .Doctors
                .Include(r => r.spetializations)
                .Include(r => r.addresses)
                .ThenInclude(a => a.is_opened)
                .Where(r => query.SearchPhrase == null ||
                (r.spetializations.Any(g => g.Specjalization.ToLower().Contains(query.SearchPhrase.ToLower()))) ||
                (r.Name.ToLower().Contains(query.SearchPhrase.ToLower())) ||
                (r.Last_name.ToLower().Contains(query.SearchPhrase.ToLower())) ||
                (r.addresses.Any(g => g.Street.ToLower().Contains(query.SearchPhrase.ToLower())))
                );

            var doctors = baseQuery
                .Skip(query.PageSize * (query.PageNumber - 1))
                .Take(query.PageSize)
                .ToList();

            var totalItemCount = baseQuery.Count();

            var doctorDtos = _mapper.Map<List<GetDoctorInformationsModelsDto>>(doctors);

            var result = new PagedResult<GetDoctorInformationsModelsDto>(doctorDtos, totalItemCount, query.PageSize, query.PageNumber);

            return result;
            
        }
    }
}
