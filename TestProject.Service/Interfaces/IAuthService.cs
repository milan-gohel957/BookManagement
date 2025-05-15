using TestProject.Entity.ViewModels;

namespace TestProject.Service.Interfaces;

public interface IAuthService
{
    Task<ResultObject> LoginAsync(LoginModel loginModel, string configKey, string issuer, string audience);

}   
