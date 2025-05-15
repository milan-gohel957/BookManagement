using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestProject.Entity.Models;

public class IssuedBook
{
    [Key]
    public int Id{get;set;}
    [ForeignKey("User")]
    [Required]
    public int UserId{get;set;}
    [ForeignKey("Book")]
    [Required]
    public int BookId{get;set;}
    public bool IsIssued{get;set;} = true;
    public User User{get;set;} = null!;
    public Book Book{get;set;} = null!;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsDeleted { get; set; } = false;
}
