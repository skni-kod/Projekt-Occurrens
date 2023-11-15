namespace occurrensBackend.Entities.DatabaseEntities
{
    public class Doctor
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Secont_name { get; set; } = string.Empty;
        public string Last_name { get; set; }
        public int Telephon_number { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateOnly Date_of_birth { get; set; }
        public string Role { get; set; } = "Doctor";
        public bool Acception { get; set; }



        public List<Spetialization> spetializations { get; set; }
        public List<Address> addresses { get; set; }
        public List<Visits> visits { get; set; }
        
      
    }
}
