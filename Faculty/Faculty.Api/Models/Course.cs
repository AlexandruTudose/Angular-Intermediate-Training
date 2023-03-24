using System.ComponentModel.DataAnnotations;

namespace Faculty.Api.Models;

public class Course: Entity
{
    [Required(AllowEmptyStrings = false)]
    [MinLength(2)]
    [MaxLength(50)]
    public string? Title { get; set; }

    [Required]
    [Range(1,4)]
    public int Year { get; set; }
    
    [Required]
    [Range(1,5)]
    public int Semester { get; set; }

    [Range(1,5)]
    public decimal? Credits { get; set; }
}