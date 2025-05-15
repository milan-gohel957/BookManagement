using System.ComponentModel.DataAnnotations;

namespace TestProject.Entity.ViewModels;

public class SignUpModel
{
    [Required(ErrorMessage = "Email is Required.")]
    [RegularExpression(@"^[\w\.-]+@[a-zA-Z0-9\.-]+\.[a-zA-Z]{2,4}$", ErrorMessage = "Please Enter a valid Email.")]
    public string Email { get; set; } = null!;
    [Required(ErrorMessage = "Password is Required.")]
    [MinLength(6, ErrorMessage = "Password Must be greater than 6 length.")]
    [MaxLength(18, ErrorMessage = "Password can not exceed 18 length.")]
    public string Password { get; set; } = null!;
    public bool RememberMe { get; set; }
}
