namespace Core.Account.DTOS;

public class AccountDto
{
    public Guid Id { get; set; }
    public decimal Pesel { get; set; }
    public string Name { get; set; }
    public string? Secont_name { get; set; }
    public string Last_name { get; set; }
    public string Email { get; set; }
    public int Telephon_number { get; set; }
    public DateOnly Date_of_birth { get; set; }
    public string Role { get; set; }
}