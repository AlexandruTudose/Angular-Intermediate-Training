namespace Faculty.Api.Models;

public class Student : Entity
{
    public string? RegistrationNumber { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public int Year { get; set; }
    public string? Group { get; set; }
    public decimal Scholarship { get; set; }
}