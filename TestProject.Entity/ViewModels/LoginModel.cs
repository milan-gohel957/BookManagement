using System.ComponentModel.DataAnnotations;

namespace TestProject.Entity.ViewModels;

public class LoginModel
{
    [Required(ErrorMessage = "Email is Required.")]
    [RegularExpression(@"^[\w\.-]+@[a-zA-Z0-9\.-]+\.[a-zA-Z]{2,4}$", ErrorMessage = "Please Enter a valid Email.")]
    public string Email { get; set; } = null!;
    [Required(ErrorMessage = "Password is Required.")]
    public string Password { get; set; } = null!;
    public bool RememberMe{get;set;}
}
