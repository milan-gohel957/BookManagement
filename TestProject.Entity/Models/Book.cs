using System.ComponentModel.DataAnnotations;
using TestProject.Entity.Enums;
namespace TestProject.Entity.Models;

public partial class Book
{
    [Key]
    public int Id { get; set; }
    [MinLength(1)]
    [MaxLength(255)]
    [Required]
    public string Title { get; set; } = string.Empty;
    [MinLength(1)]
    [MaxLength(500)]
    [Required]
    [RegularExpression("^([a-zA-Z]{2,}\\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\\s?([a-zA-Z]{1,})?)", ErrorMessage = "Valid Charactors include (A-Z) (a-z) (' space -)")]
    public string AuthorName { get; set; } = string.Empty;
    [RegularExpression("^[12][0-9]{3}$", ErrorMessage = "Please Enter Valid Year.")]
    public int PublishedYear { get; set; }
    [RegularExpression("((?:[\\dX]{13})|(?:[\\d\\-X]{17})|(?:[\\dX]{10})|(?:[\\d\\-X]{13}))")]
    public string ISBN { get; set; } = string.Empty;
    [Range(1, 10000, ErrorMessage = "Book Can't have pages more than 10000.")]
    public int TotalPages{get;set;}
    public string? BookImageUrl{get;set;}
    public BookStatusEnum BookStatus { get; set; } = BookStatusEnum.Available;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public virtual ICollection<User> UsersIssued{get;set;} = new List<User>();


}
