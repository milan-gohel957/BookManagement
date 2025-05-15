using System.ComponentModel.DataAnnotations;
using TestProject.Entity.Enums;

namespace TestProject.Entity.ViewModels;

public class BookModel
{
    public int? Id { get; set; }
    [MinLength(1)]
    [MaxLength(255)]
    [Required]
    public string Title { get; set; } = string.Empty;
    [MinLength(1)]
    [MaxLength(255)]
    [Required]
    [RegularExpression("^([a-zA-Z]{2,}\\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\\s?([a-zA-Z]{1,})?)", ErrorMessage = "Valid Charactors include (A-Z) (a-z) (' space -)")]
    public string AuthorFirstName { get; set; } = string.Empty;
    [MinLength(1)]
    [MaxLength(255)]
    [RegularExpression("^([a-zA-Z]{2,}\\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\\s?([a-zA-Z]{1,})?)", ErrorMessage = "Valid Charactors include (A-Z) (a-z) (' space -)")]
    public string AuthorLastName { get; set; } = string.Empty;
    [RegularExpression("^[12][0-9]{3}$", ErrorMessage = "Please Enter Valid Year.")]
    public int PublishedYear { get; set; }
    [RegularExpression("((?:[\\dX]{13})|(?:[\\d\\-X]{17})|(?:[\\dX]{10})|(?:[\\d\\-X]{13}))")]
    public int ISBN { get; set; }
    public string? BookImageUrl { get; set; }
    public BookStatusEnum BookStatus { get; set; } = BookStatusEnum.Available;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
}
