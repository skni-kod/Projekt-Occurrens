using Microsoft.EntityFrameworkCore;
using occurrensBackend.Entities.DatabaseEntities;

namespace occurrensBackend.Entities
{
    public class DatabaseDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Spetialization> Spetializations { get; set;}
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Is_opened> Is_opened { get; set; }
        public DbSet<Visits> Visits { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Disease> Diseases { get; set; }


        private readonly IConfiguration _configuration;

        public DatabaseDbContext(IConfiguration configuration) 
        {
            _configuration = configuration;
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("WebApiDatabase"));
        }
    }
}
