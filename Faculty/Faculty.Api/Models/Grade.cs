namespace Faculty.Api.Models;

public class Grade : Entity
{
    public Guid CourseId { get; set; }
    public Guid StudentId { get; set; }
    public decimal Value { get; set; }
    public DateTime Date { get; set; }
}