
using Microsoft.AspNetCore.Mvc;
using TestProject.Entity.ViewModels;
using TestProject.Service.Interfaces;

namespace TestProject.Web.Controllers;

public class AuthController : Controller
{
    private readonly IAuthService _authService;
    private readonly IConfiguration _configuration;
    public AuthController(IAuthService authService, IConfiguration configuration)
    {
        _configuration = configuration;
        _authService = authService;
    }
    public IActionResult Login()
    {
        if(User.Identity != null && User.Identity.IsAuthenticated)
        {
            return RedirectToAction("Index", "Home");
        }
        
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Login(LoginModel loginModel)
    {
        if(!ModelState.IsValid){
            TempData["error"] = "Model State is invalid";
            return View(loginModel);
        }

        var key = _configuration["JwtConfig:Key"] ?? string.Empty;
        var issuer = _configuration["JwtConfig:Issuer"] ?? string.Empty;
        var audience = _configuration["JwtConfig:Issuer"] ?? string.Empty;
        ResultObject resultObject = await _authService.LoginAsync(loginModel, key, issuer, audience);
        
        if(!resultObject.Status)
        {
            TempData["error"] = resultObject.Message;
            return View(loginModel);
        }
        TempData["success"] = "Login Successfull!";
        return RedirectToAction("Index", "Home");
    }
    public IActionResult LogOut()
    {
        Response.Cookies.Append("accessToken", "", new()
        {
            Expires = DateTime.UtcNow.AddDays(-1)
        });
        TempData["success"] = "Logged Out";
        return RedirectToAction("Login");
    }
}
