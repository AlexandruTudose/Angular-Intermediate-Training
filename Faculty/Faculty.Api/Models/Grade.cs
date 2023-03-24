using System.ComponentModel.DataAnnotations;

namespace Faculty.Api.Models;

public class Grade : Entity
{
    [Required]
    public Guid CourseId { get; set; }
    
    [Required]
    public Guid StudentId { get; set; }
    
    [Required]
    [Range(1,10)]
    public decimal Value { get; set; }
    
    [Required]
    public DateTime Date { get; set; }
}