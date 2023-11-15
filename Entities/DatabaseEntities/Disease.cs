namespace occurrensBackend.Entities.DatabaseEntities
{
    public class Disease
    {
        public Guid Id { get; set; }
        public int Id_disease { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Medicines { get; set; }


        public Guid? PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}
