namespace occurrensBackend.Models.DiseaseModels;

public class AddDiseaseModelDto
{
    public decimal Pesel { get; set; }
    public string Name { get; set; }
    public string Desctiption { get; set; }
    public string Medicines { get; set; }
}