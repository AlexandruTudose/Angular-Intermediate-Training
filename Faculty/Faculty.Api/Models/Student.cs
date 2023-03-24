using System.ComponentModel.DataAnnotations;

namespace Faculty.Api.Models;

public class Student : Entity
{
    [Required(AllowEmptyStrings = false)]
    [MinLength(6)]
    [MaxLength(6)]
    public string? RegistrationNumber { get; set; }

    [Required(AllowEmptyStrings = false)]
    [MinLength(2)]
    [MaxLength(50)]
    public string? FirstName { get; set; }

    [Required(AllowEmptyStrings = false)]
    [MinLength(2)]
    [MaxLength(50)]
    public string? LastName { get; set; }

    [Required]
    public DateTime BirthDate { get; set; }

    [Required]
    [Range(1, 5)]
    public int Year { get; set; }

    [Required(AllowEmptyStrings = false)]
    [MinLength(6)]
    [MaxLength(6)]
    public string? Group { get; set; }

    [Range(0, 1000)]
    public decimal Scholarship { get; set; }
}