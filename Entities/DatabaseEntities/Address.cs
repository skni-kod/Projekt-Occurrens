namespace occurrensBackend.Entities.DatabaseEntities
{
    public class Address
    {
        public Guid Id { get; set; }
        public string Town { get; set; }
        public string? Street { get; set; }
        public string Building_number { get; set; }
        public string? Apartament_number { get; set; }
        public string Postal_code { get; set; }
        public string City { get; set; }



        public Guid? DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        


        public Is_opened Is_opened { get; set; }


        public List<Is_opened> is_opened { get; set; }
    }
}
