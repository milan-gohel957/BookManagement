using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using TestProject.Entity.Enums;
using TestProject.Entity.Models;
using TestProject.Entity.ViewModels;
using TestProject.Repository.Interfaces;
using TestProject.Service.Helpers;
using TestProject.Service.Interfaces;

namespace TestProject.Service.Implementations;

public class AuthService : IAuthService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public AuthService(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
        _unitOfWork = unitOfWork;
    }

    public int GetUserId()
    {
        if (_httpContextAccessor?.HttpContext?.User == null)
        {
            return -1;
        }

        string? userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        if (string.IsNullOrEmpty(userId))
        {
            return -1;
        }

        if (!int.TryParse(userId, out int result))
        {
            return -1;
        }

        return result;
    }
    public static string GenerateToken(string email, RoleType role, string configKey, string issuer, string audience, int userId, bool? isRememberMe = false)
    {
        var claims = new List<Claim>
        {
            new (ClaimTypes.Email, email),
            new (ClaimTypes.Role, role.ToString()) ,
            new (ClaimTypes.NameIdentifier, userId.ToString()),
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configKey));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: issuer,
            audience: audience,
            claims: claims,
            expires: isRememberMe == true ? DateTime.UtcNow.AddDays(15) : DateTime.UtcNow.AddMinutes(30),
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
    public async Task<ResultObject> LoginAsync(LoginModel loginModel, string configKey, string issuer, string audience)
    {
        User? user = await _unitOfWork.User.GetFirstOrDefaultAsync(expression: x => x.Email.Trim() == loginModel.Email);
        if (user == null) return new() { Status = false, Message = "User Not Found." };

        if (!Hash.VerifyPassword(user.Password, loginModel.Password.Trim()))
        {
            return new() { Status = false, Message = "Invalid Credentials." };
        }

        string accessToken = GenerateToken(user.Email, (RoleType)user.RoleId, configKey, issuer, audience, user.Id, loginModel.RememberMe);
        if (string.IsNullOrEmpty(accessToken))
        {
            return new() { Status = false, Message = "Error while generating Token." };
        }

        _httpContextAccessor?.HttpContext?.Response.Cookies.Append("accessToken", accessToken, new()
        {
            HttpOnly = true,
            Secure = true,
            SameSite = SameSiteMode.Strict,
            Expires = loginModel.RememberMe ? DateTime.UtcNow.AddDays(15) : DateTime.UtcNow.AddMinutes(30),
        });

        return new() { Status = true, Message = "User Logged In Successfully.", RedirectUrl = "/" };
    }

    public async Task<ResultObject> SignUpAsync(SignUpModel signUpModel)
    {
        try
        {
            User? user = await _unitOfWork.User.GetFirstOrDefaultAsync(expression: x => x.Email.Trim() == signUpModel.Email);
            if (user != null) return new() { Status = false, Message = "User With this Email Already Exists." };

            User newUser = new(){
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Email = signUpModel.Email,
                Password = Hash.HashPassword(signUpModel.Password),
                RoleId = (int)RoleType.User
            };

            await _unitOfWork.User.AddAsync(newUser);
            return new(){Status =true, Message = "Sign Up SuccessFull!"};
        }
        catch (Exception ex)
        {
            return new() { Status = false, Message = "Error While Signing Up" };
        }
    }


}
