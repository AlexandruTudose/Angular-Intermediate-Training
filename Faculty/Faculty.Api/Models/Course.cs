namespace Faculty.Api.Models;

public class Course: Entity
{
    public string? Title { get; set; }
    public int Year { get; set; }
    public int Semester { get; set; }
    public decimal Credits { get; set; }
}