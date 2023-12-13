using System.ComponentModel.DataAnnotations;

namespace occurrensBackend.Models.DiseaseModels;

public class AddDiseaseModelDto
{
    public decimal Pesel { get; set; }


    [Required(ErrorMessage = "Podaj nazw� chorody")]
    public string Name { get; set; }


    [Required(ErrorMessage = "Podaj opis choroby")]
    public string Desctiption { get; set; }


    [Required(ErrorMessage = "Podaj zalecenia dotycz�ce leczenia!")]
    public string Medicines { get; set; }
}