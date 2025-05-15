using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using TestProject.Entity.Enums;

namespace TestProject.Entity.ViewModels;

public class BookModel
{
    public int? Id { get; set; }
    [MaxLength(255)]
    [Required]
    public string Title { get; set; } = string.Empty;
    [MaxLength(500, ErrorMessage = "Length must be less than 500.")]
    [Required]
    [RegularExpression("^([a-zA-Z]{2,}\\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\\s?([a-zA-Z]{1,})?)", ErrorMessage = "Valid Charactors include (A-Z) (a-z) (' space -)")]
    public string AuthorName { get; set; } = string.Empty;

    [RegularExpression("^[12][0-9]{3}$", ErrorMessage = "Please Enter Valid Year.")]
    public int PublishedYear { get; set; }
    [RegularExpression("((?:[\\dX]{13})|(?:[\\d\\-X]{17})|(?:[\\dX]{10})|(?:[\\d\\-X]{13}))", ErrorMessage ="Invalid ISBN number")]
    public string ISBN { get; set; } = string.Empty;
    public string? BookImageUrl { get; set; }
    [Range(1, 10000, ErrorMessage = "Book Can't have pages more than 10000.")]
    public int TotalPages { get; set; }
    public IFormFile? UploadedBookImage { get; set; }
    public bool IsBookImageRemoved { get; set; } = false;
    
    public BookStatusEnum BookStatus { get; set; } = BookStatusEnum.Available;
}
